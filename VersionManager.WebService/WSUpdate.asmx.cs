using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using VersionManager.DataControl.Controllers;
using VersionManager.Model;
using System.IO;
using System.IO.Compression;
using System.Globalization;
using Newtonsoft.Json;
using static VersionManager.Utilities.DataStructure;
using VersionManager.Utilities;
using System.Security.AccessControl;
using System.Web.Services.Description;

namespace VersionManager.WebService
{
    /// <summary>
    /// Summary description for WSUpdate
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSUpdate : System.Web.Services.WebService
    {
        private VersionsController versionsController = new VersionsController();
        private List<VersionDto> versions;
        /// <summary>
        /// مسیر فایلهایی که در برنامه مدیریت ورژن روی هاست بارگذاری شده
        /// </summary>
        private string strVersionPath = @"\Versions";
        /// <summary>
        /// مسیری که فایل پک درون آن ساخته می شود و کاربر میتواند از این مسیر فایل پک را دانلود کند
        /// </summary>
        private string strZipFilePath = string.Format(@"{0}\ZipFilePath", AppDomain.CurrentDomain.BaseDirectory + "DownloadFtp");

        public WSUpdate()
        {
            versionsController = new VersionsController();
        }

        [WebMethod]
        public string GetUpdate(string customerId, string version)
        {
            System.Security.AccessControl.DirectorySecurity DirPermission = new System.Security.AccessControl.DirectorySecurity();
            System.Security.AccessControl.FileSystemAccessRule FRule = new System.Security.AccessControl.FileSystemAccessRule
                ("Everyone", System.Security.AccessControl.FileSystemRights.FullControl, System.Security.AccessControl.AccessControlType.Allow);
            DirPermission.AddAccessRule(FRule);
            try
            {
                versions = versionsController.GetForUpdate(version);
                if (versions != null && versions.Count > 0)
                {
                    PersianCalendar persianCalendar = new PersianCalendar();

                    string currentDate = string.Format("{0}-{1}-{2}_{3}_{4}_{5}"
                        , persianCalendar.GetYear(DateTime.Now)
                        , persianCalendar.GetMonth(DateTime.Now).ToString().PadLeft(2, '0')
                        , persianCalendar.GetDayOfMonth(DateTime.Now).ToString().PadLeft(2, '0')
                        , DateTime.Now.Hour.ToString().PadLeft(2, '0')
                        , DateTime.Now.Minute.ToString().PadLeft(2, '0')
                        , DateTime.Now.Second.ToString().PadLeft(2, '0'));
                    string strPackPath = string.Format(@"{0}UpdatePacks\{1}_{2}", AppDomain.CurrentDomain.BaseDirectory, customerId, currentDate);
                    if (!Directory.Exists(strPackPath))
                    {

                        Directory.CreateDirectory(strPackPath, DirPermission);
                    }
                    string strFinalStruct = "";
                    string strFinalAlter = "";

                    if (!Directory.Exists(string.Format(@"{0}\Dlls", strPackPath)))
                        Directory.CreateDirectory(string.Format(@"{0}\Dlls", strPackPath), DirPermission);
                    if (!Directory.Exists(string.Format(@"{0}\Scripts", strPackPath)))
                        Directory.CreateDirectory(string.Format(@"{0}\\Scripts", strPackPath), DirPermission);

                    foreach (VersionDto item in versions)
                    {
                        if (!string.IsNullOrWhiteSpace(item.VersionName) && Directory.Exists(string.Format(@"{0}\{1}\Dlls", strVersionPath, item.VersionName)))
                        {
                            DirectoryInfo diSource = new DirectoryInfo(string.Format(@"{0}\{1}\Dlls", strVersionPath, item.VersionName));
                            DirectoryInfo diDestination = new DirectoryInfo(string.Format(@"{0}\Dlls", strPackPath));
                            CopyAllFilesFolders(diSource, diDestination);
                        }
                        if (!string.IsNullOrWhiteSpace(item.StructureScriptPath) && File.Exists(string.Format(@"{0}\{1}\Scripts\__Structure.sql", strVersionPath, item.VersionName)))
                        {
                            StreamReader streamReader1 = new StreamReader(string.Format(@"{0}\{1}\Scripts\__Structure.sql", strVersionPath, item.VersionName));
                            string strItem = streamReader1.ReadToEnd();
                            strFinalStruct += strItem;
                            streamReader1.Close();
                            //streamReader1.Close();
                        }
                        if (!string.IsNullOrWhiteSpace(item.AlterScriptPath) && File.Exists(string.Format(@"{0}\{1}\Scripts\__Alter.sql", strVersionPath, item.VersionName)))
                        {
                            StreamReader streamReader1 = new StreamReader(string.Format(@"{0}\{1}\Scripts\__Alter.sql", strVersionPath, item.VersionName));
                            string strItem = streamReader1.ReadToEnd();
                            strFinalAlter += strItem;
                            streamReader1.Close();
                        }
                    }
                    VersionInfo versionInfo = new VersionInfo()
                    {
                        AppVersionCode = version,
                        PackVersionCode = versions.Last().VersionCode,
                        CustomerId = customerId,
                        PackType = ServicePackType.UserDiffPack
                    };

                    //create json from class versionInfo
                    //create ini from json 
                    StreamWriter streamWriterINI = new StreamWriter(string.Format(@"{0}\VersionInfo.ini", strPackPath));
                    streamWriterINI.Write(versionInfo.ToJSON());
                    streamWriterINI.Close();

                    StreamWriter streamWriter = new StreamWriter(string.Format(@"{0}\Scripts\__Struct.sql", strPackPath));
                    streamWriter.Write(strFinalStruct);
                    streamWriter.Close();
                    streamWriter = new StreamWriter(string.Format(@"{0}\Scripts\__Alter.sql", strPackPath));
                    streamWriter.Write(strFinalAlter);
                    streamWriter.Close();
                    if (!Directory.Exists(strZipFilePath))
                        Directory.CreateDirectory(strZipFilePath, DirPermission);
                    ZipFile.CreateFromDirectory(strPackPath, string.Format(@"{0}\{1}_{2}.zip", strZipFilePath, customerId, currentDate), CompressionLevel.Optimal, false);

                    return string.Format("{0}_{1}.zip", customerId, currentDate);//اسم فایلی که مخصوص این کاربر ساخته شده و میتواد در برنامه آنرا دانلود کند
                }
                else
                {
                    return "-1";//کاربرآخرین آپدیت را دارد
                }

            }
            catch (Exception ex)
            {
                return "-2";//خطا در عملیات مجددا تلاش نمایید
            }
        }

        [WebMethod]
        public VersionDto UpdateExist(string customerId, string version)
        {
            try
            {
                versions = versionsController.GetForUpdate(version);
                if (versions != null && versions.Count > 0)
                {
                    return versions.Last();
                }
                else
                {
                    return new VersionDto() {  VersionStatus = VersionStatus.NotExists };
                }
            }
            catch (Exception ex)
            {
                throw;// return new VersionsDto() {  VersionStatus =  VersionStatus.Error };
            }
        }

        [WebMethod]
        public string CheckConnection()
        {
            return "1";
        }

        private void CopyAllFilesFolders(DirectoryInfo sourceDirectory, DirectoryInfo destinationDirectory)
        {
            foreach (FileInfo fileInfo in sourceDirectory.GetFiles())
            {
                fileInfo.CopyTo(Path.Combine(destinationDirectory.FullName, fileInfo.Name), true);
            }

            foreach (DirectoryInfo diSourceSubDirectory in sourceDirectory.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                   destinationDirectory.CreateSubdirectory(diSourceSubDirectory.Name);
                CopyAllFilesFolders(diSourceSubDirectory, nextTargetSubDir);
            }
        }
    }
}
