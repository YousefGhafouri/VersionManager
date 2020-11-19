using Janus.Windows.GridEX;
using VersionManager.Utilities;

namespace VersionManager
{
    partial class frmVersionManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout gridVersionManager_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVersionManager));
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gridVersionManager = new Janus.Windows.GridEX.GridEX();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnCreateFullPack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreateCustomPack = new System.Windows.Forms.Button();
            this.btnCreateUserPack = new System.Windows.Forms.Button();
            this.bsVersions = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVersionManager)).BeginInit();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVersions)).BeginInit();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            this.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.pnlMain);
            this.spcMain.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.pnlTools);
            this.spcMain.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcMain.Size = new System.Drawing.Size(967, 445);
            this.spcMain.SplitterDistance = 391;
            this.spcMain.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gridVersionManager);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(967, 391);
            this.pnlMain.TabIndex = 0;
            // 
            // gridVersionManager
            // 
            this.gridVersionManager.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridVersionManager.DataSource = this.bsVersions;
            gridVersionManager_DesignTimeLayout.LayoutString = resources.GetString("gridVersionManager_DesignTimeLayout.LayoutString");
            this.gridVersionManager.DesignTimeLayout = gridVersionManager_DesignTimeLayout;
            this.gridVersionManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVersionManager.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridVersionManager.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed;
            this.gridVersionManager.GroupByBoxVisible = false;
            this.gridVersionManager.Location = new System.Drawing.Point(0, 0);
            this.gridVersionManager.Name = "gridVersionManager";
            this.gridVersionManager.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridVersionManager.SettingsKey = "dgrdVersionManager";
            this.gridVersionManager.Size = new System.Drawing.Size(967, 391);
            this.gridVersionManager.TabIndex = 0;
            this.gridVersionManager.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            this.gridVersionManager.Click += new System.EventHandler(this.gridVersionManager_Click);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.pnlTools.Controls.Add(this.btnCreateUserPack);
            this.pnlTools.Controls.Add(this.btnCreateCustomPack);
            this.pnlTools.Controls.Add(this.btnCreateFullPack);
            this.pnlTools.Controls.Add(this.btnRefresh);
            this.pnlTools.Controls.Add(this.btnExit);
            this.pnlTools.Controls.Add(this.btnDelete);
            this.pnlTools.Controls.Add(this.btnEdit);
            this.pnlTools.Controls.Add(this.btnAdd);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(967, 50);
            this.pnlTools.TabIndex = 0;
            // 
            // btnCreateFullPack
            // 
            this.btnCreateFullPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateFullPack.Location = new System.Drawing.Point(501, 8);
            this.btnCreateFullPack.Name = "btnCreateFullPack";
            this.btnCreateFullPack.Size = new System.Drawing.Size(130, 34);
            this.btnCreateFullPack.TabIndex = 5;
            this.btnCreateFullPack.Text = "ساخت پک کامل";
            this.btnCreateFullPack.UseVisualStyleBackColor = true;
            this.btnCreateFullPack.Click += new System.EventHandler(this.btnCreateFullPack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(637, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(12, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(718, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(799, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 34);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(880, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "جدید";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCreateCustomPack
            // 
            this.btnCreateCustomPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateCustomPack.Location = new System.Drawing.Point(355, 8);
            this.btnCreateCustomPack.Name = "btnCreateCustomPack";
            this.btnCreateCustomPack.Size = new System.Drawing.Size(140, 34);
            this.btnCreateCustomPack.TabIndex = 6;
            this.btnCreateCustomPack.Text = "ساخت پک انتخابی";
            this.btnCreateCustomPack.UseVisualStyleBackColor = true;
            this.btnCreateCustomPack.Click += new System.EventHandler(this.btnCreateCustomPack_Click);
            // 
            // btnCreateUserPack
            // 
            this.btnCreateUserPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUserPack.Location = new System.Drawing.Point(182, 8);
            this.btnCreateUserPack.Name = "btnCreateUserPack";
            this.btnCreateUserPack.Size = new System.Drawing.Size(167, 34);
            this.btnCreateUserPack.TabIndex = 7;
            this.btnCreateUserPack.Text = "ساخت پک با فایل کاربر";
            this.btnCreateUserPack.UseVisualStyleBackColor = true;
            this.btnCreateUserPack.Click += new System.EventHandler(this.btnCreateUserPack_Click);
            // 
            // bsVersions
            // 
            this.bsVersions.DataSource = typeof(VersionManager.Model.VersionsDto);
            // 
            // frmVersionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 445);
            this.Controls.Add(this.spcMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmVersionManager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت ورژن";
            this.Load += new System.EventHandler(this.frmVersionManager_Load);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVersionManager)).EndInit();
            this.pnlTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsVersions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTools;
        private Janus.Windows.GridEX.GridEX gridVersionManager;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.BindingSource bsVersions;
        private System.Windows.Forms.Button btnCreateFullPack;
        private System.Windows.Forms.Button btnCreateCustomPack;
        private System.Windows.Forms.Button btnCreateUserPack;
    }
}