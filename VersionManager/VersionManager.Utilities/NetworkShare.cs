using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Net.FtpClient;
using System.Text.RegularExpressions;

namespace VersionManager.Utilities
{
    public static class NetworkShare
    {

        public static string host = ConfigurationManager.AppSettings.Get("FTPAddress");
        public static string UserId = ConfigurationManager.AppSettings.Get("FTPUser");
        public static string Password = ConfigurationManager.AppSettings.Get("FTPPassword");

        public static void CopyAllFilesToFTP(string sourcePath, string destinationPath, bool isRoot)
        {
            if (!DoesFtpDirectoryExist(destinationPath))
            {
                CreateFolder(host + destinationPath);

            }
            if (isRoot)
            {
                if (!DoesFtpDirectoryExist(destinationPath + "/Dlls"))
                    CreateFolder(host + destinationPath + "/Dlls");
                if (!DoesFtpDirectoryExist(destinationPath + "/Scripts"))
                    CreateFolder(host + destinationPath + "/Scripts");
                destinationPath += "/Dlls";
            }
            //else
            //{
            DirectoryInfo directoryInfo = new DirectoryInfo(sourcePath);
            foreach (FileInfo item in directoryInfo.GetFiles())
            {
                string strFileName = "";
                GetFileName(sourcePath, item.FullName, ref strFileName);
                if (!string.IsNullOrWhiteSpace(strFileName))
                {
                    WriteFilesToFtp(item.FullName, host + destinationPath + "/" + strFileName);
                }

            }

            foreach (DirectoryInfo diSourceSubDir in directoryInfo.GetDirectories())
            {
                string strDirectory = diSourceSubDir.FullName;
                string strDestDirectory = destinationPath + "/" + diSourceSubDir.Name;
                CopyAllFilesToFTP(strDirectory, strDestDirectory, false);
            }
            //}
        }

        public static void GetFileName(string sourcePath, string filePath, ref string fileName)
        {
            fileName = filePath.Replace(sourcePath, "").Replace(@"\", "");
        }

        public static bool CreateFolder(string path)
        {
            bool IsCreated = true;
            try
            {
                WebRequest request = WebRequest.Create(path);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = new NetworkCredential(UserId, Password);
                using (var resp = (FtpWebResponse)request.GetResponse())
                {
                    Console.WriteLine(resp.StatusCode);
                }
            }
            catch (Exception ex)
            {
                IsCreated = false;
            }
            return IsCreated;
        }


        public static bool DoesFtpDirectoryExist(string dirPath)
        {
            bool isexist = false;

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host + dirPath);
                request.Credentials = new NetworkCredential(UserId, Password);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    isexist = true;
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        return false;
                    }
                }
            }
            return isexist;
        }


        public static void UploadFile()
        {
            string From = @"D:\Ali\TestFtp\ali.txt";
            string To = host + "/Versions/ali.txt";

            using (WebClient client = new WebClient())
            {
                client.Credentials = new NetworkCredential(UserId, Password);
                client.UploadFile(To, WebRequestMethods.Ftp.UploadFile, From);
            }
        }

        public static void WriteFilesToFtp(string sourceFile, string destinationFile)
        {
            //Create FTP request
            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(destinationFile);

            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(UserId, Password);
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = true;

            //Load the file
            FileStream stream = File.OpenRead(sourceFile);
            byte[] buffer = new byte[stream.Length];

            stream.Read(buffer, 0, buffer.Length);
            stream.Close();

            //Upload file
            Stream reqStream = request.GetRequestStream();
            reqStream.Write(buffer, 0, buffer.Length);
            reqStream.Close();

            request = null;
        }


        public static List<string> GetAllFtpFiles(string ParentFolderpath)
        {
            try
            {
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(host +"/"+ ParentFolderpath);
                ftpRequest.Credentials = new NetworkCredential(UserId, Password);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
                StreamReader streamReader = new StreamReader(response.GetResponseStream());

                List<string> directories = new List<string>();

                string line = streamReader.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    var lineArr = line.Split('/');
                    line = lineArr[lineArr.Count() - 1];
                    directories.Add(line);
                    line = streamReader.ReadLine();
                }

                streamReader.Close();

                return directories;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteFtpDirectoryAndContent(string url)
        {
            using (FtpClient conn = new FtpClient())
            {
                conn.Host = host;
                conn.Credentials = new NetworkCredential(UserId, Password);

                foreach (FtpListItem item in conn.GetListing(url, FtpListOption.AllFiles | FtpListOption.ForceList))
                {

                    switch (item.Type)
                    {
                        case FtpFileSystemObjectType.Directory:
                            conn.DeleteDirectory(item.FullName, true, FtpListOption.AllFiles | FtpListOption.ForceList);
                            break;
                        case FtpFileSystemObjectType.File:
                            //if (!dontDeleteFileUrl.EndsWith(item.FullName, StringComparison.InvariantCultureIgnoreCase))
                            conn.DeleteFile(item.FullName);
                            break;
                    }
                }

            }
        }

        public static void DeleteFilesAndFolders(string path)
        {
            if (path != null && (path.StartsWith(@"\\") || path.StartsWith("//")))
                path = path.Remove(0, 1);
            List<FileObject> files = DirectoryListing(path);

            foreach (FileObject file in files.Where(file => !file.IsDirectory))
            {
                if (!string.IsNullOrWhiteSpace(file.FileName))
                    DeleteFile(path, file.FileName);
            }

            foreach (FileObject file in files.Where(file => file.IsDirectory))
            {
                DeleteFilesAndFolders(path + "/" + file.FileName);
                DeleteFolder(path + "/" + file.FileName);
            }
        }

        private static void DeleteFile(string path, string file)
        {
            var clsRequest = (FtpWebRequest)WebRequest.Create(host + path + "/" + file);
            clsRequest.Credentials = new NetworkCredential(UserId, Password);

            clsRequest.Method = WebRequestMethods.Ftp.DeleteFile;

            using (var response = (FtpWebResponse)clsRequest.GetResponse())
            {
                using (Stream datastream = response.GetResponseStream())
                {
                    if (datastream == null)
                        return;
                    using (var sr = new StreamReader(datastream))
                    {
                        sr.ReadToEnd();
                        sr.Close();
                    }
                    datastream.Close();
                    response.Close();
                }
            }
        }

        public static void DeleteFolder(string path)
        {
            var clsRequest = (FtpWebRequest)WebRequest.Create(host + path);
            clsRequest.Credentials = new NetworkCredential(UserId, Password);

            clsRequest.Method = WebRequestMethods.Ftp.RemoveDirectory;

            using (var response = (FtpWebResponse)clsRequest.GetResponse())
            {
                using (Stream datastream = response.GetResponseStream())
                {
                    if (datastream == null)
                        return;
                    using (var sr = new StreamReader(datastream))
                    {
                        sr.ReadToEnd();
                        sr.Close();
                    }
                    datastream.Close();
                    response.Close();
                }
            }
        }

        private static List<FileObject> DirectoryListing(string path)
        {
            var regex = new Regex(@"^(\d+-\d+-\d+\s+\d+:\d+(?:AM|PM))\s+(<DIR>|\d+)\s+(.+)$",
                //@"^([d-])([rwxt-]{3}){3}\s+\d{1,}\s+.*?(\d{1,})\s+(\w+\s+\d{1,2}\s+(?:\d{4})?)(\d{1,2}:\d{2})?\s+(.+?)\s?$",
                RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            var request = (FtpWebRequest)WebRequest.Create(host + path);
            request.Credentials = new NetworkCredential(UserId, Password);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            var result = new List<FileObject>();

            using (var response = (FtpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream == null)
                        return null;
                    using (var reader = new StreamReader(responseStream))
                    {
                        while (!reader.EndOfStream)
                        {
                            string r = reader.ReadLine();
                            if (string.IsNullOrWhiteSpace(r))
                                continue;
                            string[] ssss = r.Split(' ');
                            var reg = regex.Match(r);
                            var c = new FileObject
                            {
                                FileName = reg.Groups[3].Value,
                                IsDirectory = reg.Groups[2].Value.ToLower() == "<dir>"
                            };
                            result.Add(c);
                        }
                        reader.Close();
                    }
                    response.Close();
                }
            }

            return result;
        }
    }
    internal class FileObject
    {
        public bool IsDirectory { get; set; }
        public string FileName { get; set; }
    }
}
