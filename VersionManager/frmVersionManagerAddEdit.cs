using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VersionManager.DataControl.Controllers;
using VersionManager.Model;
using VersionManager.Utilities;
using static VersionManager.Utilities.DataStructure;

namespace VersionManager
{
    public partial class frmVersionManagerAddEdit : Form
    {
        #region Private Properties
        VersionsController versionsController;
        VersionsDto versions;
        private int _versionsId;
        FormAction _formAction;
        WaitingWindows waitingWindows = new WaitingWindows();
        #endregion

        public frmVersionManagerAddEdit(FormAction formAction, int versionId) : this(formAction)
        {
            _versionsId = versionId;
        }

        public frmVersionManagerAddEdit(FormAction formAction)
        {
            versionsController = new VersionsController();
            _formAction = formAction;
            InitializeComponent();

        }


        #region Methods
        private void FillData()
        {
            versions = versionsController.GetById(_versionsId);
            bsVersions.DataSource = versions;
        }

        private void SetFormState()
        {
            FillData();
            if (_formAction == FormAction.Add)
            {
                txtVersionCode.Text = versionsController.MaxCode();
            }

        }
        #endregion

        #region Events

        private void frmVersionManagerAddEdit_Load(object sender, EventArgs e)
        {
            SetFormState();
        }

        private void btnBrowsDll_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDllPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnBrowsStructureScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "انتخاب فایل اسکریپت ساختار";
            openFileDialog.Filter = "Sql Query Files (*.sql)|*.sql|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtStructureScriptPath.Text = openFileDialog.FileName;
            }
        }

        private void btnBrowsAlterScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "انتخاب فایل اسکریپت تغییرات";
            openFileDialog.Filter = "Sql Query Files (*.sql)|*.sql|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtAlterScriptPath.Text = openFileDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                waitingWindows.Show(this);
                versions = (VersionsDto)bsVersions.Current;
                versionsController.Save(_formAction, versions);
                string strDestinationDllPath = "/" + versions.VersionName;
                string strDestinationScriptPath = NetworkShare.host + strDestinationDllPath + "/Scripts";
                if (_formAction == FormAction.Edit)
                {
                    if (NetworkShare.DoesFtpDirectoryExist("/" + versions.VersionName))
                    {
                        NetworkShare.DeleteFilesAndFolders("/" + versions.VersionName);
                        NetworkShare.DeleteFolder("/" + versions.VersionName);
                    }
                }
                NetworkShare.CopyAllFilesToFTP(versions.DllPath, strDestinationDllPath, true);
                NetworkShare.WriteFilesToFtp(versions.StructureScriptPath, strDestinationScriptPath + "/__Structure.sql");
                NetworkShare.WriteFilesToFtp(versions.AlterScriptPath, strDestinationScriptPath + "/__Alter.sql");
                waitingWindows.Close();
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("خطا در انجام عملیات{0}", Environment.NewLine + ex.Message));
            }
            finally
            {
                waitingWindows.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void txtVersionCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
