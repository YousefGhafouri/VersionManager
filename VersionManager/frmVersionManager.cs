using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VersionManager.DataControl.Controllers;
using VersionManager.Model;
using VersionManager.Utilities;

namespace VersionManager
{
    public partial class frmVersionManager : Form
    {
        #region Private Properties
        private VersionsController versionsController;
        List<VersionsDto> versions;
        private int currentId { get => gridVersionManager.GetValue("Id").ToInteger(0); }
        private string currentVersionName { get => gridVersionManager.GetValue("VersionName").ToString(); }
        WaitingWindows waitingWindows = new WaitingWindows();
        #endregion

        #region Method
        public frmVersionManager()
        {
            InitializeComponent();
            versionsController = new VersionsController();
        }

        private void FillData()
        {
            versions = versionsController.GetAll();
            bsVersions.DataSource = versions;
        }

        private void CopyAllFilesFolders(DirectoryInfo sourceDirectory, DirectoryInfo destinationDirectory)
        {
            foreach (FileInfo fileInfo in sourceDirectory.GetFiles())
            {
                fileInfo.CopyTo(Path.Combine(destinationDirectory.FullName, fileInfo.Name),true);
            }

            foreach (DirectoryInfo diSourceSubDirectory in sourceDirectory.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                   destinationDirectory.CreateSubdirectory(diSourceSubDirectory.Name);
                CopyAllFilesFolders(diSourceSubDirectory, nextTargetSubDir);
            }
        }
        #endregion

        #region Event
        private void frmVersionManager_Load(object sender, EventArgs e)
        {
            waitingWindows.Show(this);
            FillData();
            waitingWindows.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmVersionManagerAddEdit frmVersionManagerAddEdit = new frmVersionManagerAddEdit(DataStructure.FormAction.Add))
                {
                    frmVersionManagerAddEdit.ShowDialog();
                    FillData();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmVersionManagerAddEdit frmVersionManagerAddEdit = new frmVersionManagerAddEdit(DataStructure.FormAction.Edit, currentId))
                {
                    frmVersionManagerAddEdit.ShowDialog();
                    FillData();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            waitingWindows.Show(this);
            FillData();
            waitingWindows.Close();
            //string addr = @"F:\Programming\Ghafouri\VersionManager\TempFolder";
            //string desAddr = @"/TempFolder";
            //NetworkShare.CopyAllFiles(addr, desAddr);
            //NetworkShare.DeleteFilesAndFolders("/Version_1");
            //NetworkShare.DeleteFolder("/Version_1");
            //var s = NetworkShare.ListFiles();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا قصد حذف ورژن انتخاب شده را دارید", "حذف ورژن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    waitingWindows.Show(this);
                    versionsController.Delete(currentId);
                    if (NetworkShare.DoesFtpDirectoryExist("/" + currentVersionName))
                    {
                        NetworkShare.DeleteFilesAndFolders("/" + currentVersionName);
                        NetworkShare.DeleteFolder("/" + currentVersionName);
                    }
                    VersionsDto versionsDto = (VersionsDto)bsVersions.Current;
                    FillData();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                waitingWindows.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnCreateFullPack_Click(object sender, EventArgs e)
        {
            if(bsVersions.Count == 0)
            {
                MessageBox.Show("رکوردی برای ساخت پک کامل وجود ندارد");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "ذخیره فایل پک کامل";
            saveFileDialog.Filter = "ZIP Files (.ZIP)|*.zip";
            saveFileDialog.FileName = "VersionManager-FullPack";
            string strFullPackPath = string.Format(@"{0}\FullPack", Application.StartupPath);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strFinalStruct = "";
                string strFinalAlter = "";
                try
                {
                    if (Directory.Exists(strFullPackPath))
                        Directory.Delete(strFullPackPath,true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (!Directory.Exists(strFullPackPath))
                    Directory.CreateDirectory(strFullPackPath);
                if (!Directory.Exists(string.Format(@"{0}\Dlls", strFullPackPath)))
                    Directory.CreateDirectory(string.Format(@"{0}\Dlls", strFullPackPath));
                if (!Directory.Exists(string.Format(@"{0}\Scripts", strFullPackPath)))
                    Directory.CreateDirectory(string.Format(@"{0}\\Scripts", strFullPackPath));
                foreach (VersionsDto item in (List<VersionsDto>)bsVersions.DataSource)
                {
                    if (!string.IsNullOrWhiteSpace(item.DllPath) && Directory.Exists(item.DllPath))
                    {
                        DirectoryInfo diSource = new DirectoryInfo(item.DllPath);
                        DirectoryInfo diDestination = new DirectoryInfo(string.Format(@"{0}\Dlls", strFullPackPath));
                        CopyAllFilesFolders(diSource, diDestination);
                    }
                    if (!string.IsNullOrWhiteSpace(item.StructureScriptPath) && File.Exists(item.StructureScriptPath))
                    {
                        StreamReader streamReader = new StreamReader(item.StructureScriptPath);
                        string strItem = streamReader.ReadToEnd();
                        strFinalStruct += strItem;
                        streamReader.Close();
                    }
                    if (!string.IsNullOrWhiteSpace(item.AlterScriptPath) && File.Exists(item.AlterScriptPath))
                    {
                        StreamReader streamReader = new StreamReader(item.AlterScriptPath);
                        string strItem = streamReader.ReadToEnd();
                        strFinalAlter += strItem;
                        streamReader.Close();
                    }
                }

                StreamWriter streamWriter = new StreamWriter(string.Format(@"{0}\Scripts\__Struct.sql", strFullPackPath));
                streamWriter.Write(strFinalStruct);
                streamWriter.Close();
                streamWriter = new StreamWriter(string.Format(@"{0}\Scripts\__Alter.sql", strFullPackPath));
                streamWriter.Write(strFinalAlter);
                streamWriter.Close();
                if (File.Exists(saveFileDialog.FileName))
                    File.Delete(saveFileDialog.FileName);
                ZipFile.CreateFromDirectory(strFullPackPath, saveFileDialog.FileName, CompressionLevel.Optimal, false);
                MessageBox.Show(string.Format("فایل پک کامل با موفقیت در مسیر {0} ساخته شد",saveFileDialog.FileName));
            }
        }

        private void gridVersionManager_Click(object sender, EventArgs e)
        {
            if(gridVersionManager.RowCount > 0 && gridVersionManager.CurrentRow != null
                && gridVersionManager.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                if(gridVersionManager.CurrentColumn != null && gridVersionManager.CurrentColumn.Key == "IsSelect")
                {
                    ((VersionsDto)bsVersions.Current).IsSelect = !((VersionsDto)bsVersions.Current).IsSelect;
                    gridVersionManager.UpdateData();
                }
            }
        }

        private void btnCreateCustomPack_Click(object sender, EventArgs e)
        {
            if (bsVersions.Count == 0)
            {
                MessageBox.Show("رکوردی برای ساخت پک انتخابی وجود ندارد");
                return;
            }
            List<VersionsDto> lstSelectedRecords = new List<VersionsDto>();
            foreach (VersionsDto item in (List<VersionsDto>)bsVersions.DataSource)
            {
                if (item.IsSelect)
                    lstSelectedRecords.Add(item);
            }
            if(lstSelectedRecords.Count == 0)
            {
                MessageBox.Show("رکوردی برای ساخت پک انتخاب نشده است");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "ذخیره فایل پک انتخابی";
            saveFileDialog.Filter = "ZIP Files (.ZIP)|*.zip";
            saveFileDialog.FileName = "VersionManager-CustomPack";
            string strCustomPackPath = string.Format(@"{0}\CustomPack", Application.StartupPath);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strFinalStruct = "";
                string strFinalAlter = "";
                try
                {
                    if (Directory.Exists(strCustomPackPath))
                        Directory.Delete(strCustomPackPath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (!Directory.Exists(strCustomPackPath))
                    Directory.CreateDirectory(strCustomPackPath);
                if (!Directory.Exists(string.Format(@"{0}\Dlls", strCustomPackPath)))
                    Directory.CreateDirectory(string.Format(@"{0}\Dlls", strCustomPackPath));
                if (!Directory.Exists(string.Format(@"{0}\Scripts", strCustomPackPath)))
                    Directory.CreateDirectory(string.Format(@"{0}\\Scripts", strCustomPackPath));
                foreach (VersionsDto item in lstSelectedRecords)
                {
                    if (!string.IsNullOrWhiteSpace(item.DllPath) && Directory.Exists(item.DllPath))
                    {
                        DirectoryInfo diSource = new DirectoryInfo(item.DllPath);
                        DirectoryInfo diDestination = new DirectoryInfo(string.Format(@"{0}\Dlls", strCustomPackPath));
                        CopyAllFilesFolders(diSource, diDestination);
                    }
                    if (!string.IsNullOrWhiteSpace(item.StructureScriptPath) && File.Exists(item.StructureScriptPath))
                    {
                        StreamReader streamReader = new StreamReader(item.StructureScriptPath);
                        string strItem = streamReader.ReadToEnd();
                        strFinalStruct += strItem;
                        streamReader.Close();
                    }
                    if (!string.IsNullOrWhiteSpace(item.AlterScriptPath) && File.Exists(item.AlterScriptPath))
                    {
                        StreamReader streamReader = new StreamReader(item.AlterScriptPath);
                        string strItem = streamReader.ReadToEnd();
                        strFinalAlter += strItem;
                        streamReader.Close();
                    }
                }

                StreamWriter streamWriter = new StreamWriter(string.Format(@"{0}\Scripts\__Struct.sql", strCustomPackPath));
                streamWriter.Write(strFinalStruct);
                streamWriter.Close();
                streamWriter = new StreamWriter(string.Format(@"{0}\Scripts\__Alter.sql", strCustomPackPath));
                streamWriter.Write(strFinalAlter);
                streamWriter.Close();
                if (File.Exists(saveFileDialog.FileName))
                    File.Delete(saveFileDialog.FileName);
                ZipFile.CreateFromDirectory(strCustomPackPath, saveFileDialog.FileName, CompressionLevel.Optimal, false);
                MessageBox.Show(string.Format("فایل پک انتخابی با موفقیت در مسیر {0} ساخته شد", saveFileDialog.FileName));
            }
        }

        private void btnCreateUserPack_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "INI Files (.INI)|*.ini";
            openFileDialog.Title = "انتخاب فایل کاربر";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                string strUserVersion = streamReader.ReadToEnd();
                int intUserVersion = strUserVersion.ToInteger();
                List<VersionsDto> lstVersions = (List<VersionsDto>)bsVersions.DataSource;
                if(lstVersions != null && lstVersions.Count > 0)
                {
                    List<VersionsDto> lstUserVersions = lstVersions.Where(x => x.VersionCodeInt > intUserVersion).ToList();
                    if(lstUserVersions != null && lstUserVersions.Count > 0)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Title = "ذخیره فایل پک کاربر";
                        saveFileDialog.Filter = "ZIP Files (.ZIP)|*.zip";
                        saveFileDialog.FileName = "VersionManager-UserPack";
                        string strUserPackPath = string.Format(@"{0}\UserPack", Application.StartupPath);
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string strFinalStruct = "";
                            string strFinalAlter = "";
                            try
                            {
                                if (Directory.Exists(strUserPackPath))
                                    Directory.Delete(strUserPackPath, true);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            if (!Directory.Exists(strUserPackPath))
                                Directory.CreateDirectory(strUserPackPath);
                            if (!Directory.Exists(string.Format(@"{0}\Dlls", strUserPackPath)))
                                Directory.CreateDirectory(string.Format(@"{0}\Dlls", strUserPackPath));
                            if (!Directory.Exists(string.Format(@"{0}\Scripts", strUserPackPath)))
                                Directory.CreateDirectory(string.Format(@"{0}\\Scripts", strUserPackPath));
                            foreach (VersionsDto item in lstUserVersions)
                            {
                                if (!string.IsNullOrWhiteSpace(item.DllPath) && Directory.Exists(item.DllPath))
                                {
                                    DirectoryInfo diSource = new DirectoryInfo(item.DllPath);
                                    DirectoryInfo diDestination = new DirectoryInfo(string.Format(@"{0}\Dlls", strUserPackPath));
                                    CopyAllFilesFolders(diSource, diDestination);
                                }
                                if (!string.IsNullOrWhiteSpace(item.StructureScriptPath) && File.Exists(item.StructureScriptPath))
                                {
                                    StreamReader streamReader1 = new StreamReader(item.StructureScriptPath);
                                    string strItem = streamReader1.ReadToEnd();
                                    strFinalStruct += strItem;
                                    streamReader1.Close();
                                }
                                if (!string.IsNullOrWhiteSpace(item.AlterScriptPath) && File.Exists(item.AlterScriptPath))
                                {
                                    StreamReader streamReader1 = new StreamReader(item.AlterScriptPath);
                                    string strItem = streamReader1.ReadToEnd();
                                    strFinalAlter += strItem;
                                    streamReader1.Close();
                                }
                            }

                            StreamWriter streamWriter = new StreamWriter(string.Format(@"{0}\Scripts\__Struct.sql", strUserPackPath));
                            streamWriter.Write(strFinalStruct);
                            streamWriter.Close();
                            streamWriter = new StreamWriter(string.Format(@"{0}\Scripts\__Alter.sql", strUserPackPath));
                            streamWriter.Write(strFinalAlter);
                            streamWriter.Close();
                            if (File.Exists(saveFileDialog.FileName))
                                File.Delete(saveFileDialog.FileName);
                            ZipFile.CreateFromDirectory(strUserPackPath, saveFileDialog.FileName, CompressionLevel.Optimal, false);
                            MessageBox.Show(string.Format("فایل پک کاربر با موفقیت در مسیر {0} ساخته شد", saveFileDialog.FileName));
                        }
                    }
                    else
                    {
                        MessageBox.Show("فایل کاربر شامل آخرین بروزرسانی می باشد");
                    }
                }
                else
                {
                    MessageBox.Show("رکوردی برای ساختن فایل پک یافت نشد");
                }

            }
        }
    }
}
