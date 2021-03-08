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
            this.gridVersionManager = new Janus.Windows.GridEX.GridEX();
            this.btnCreateUserPack = new System.Windows.Forms.Button();
            this.btnCreateCustomPack = new System.Windows.Forms.Button();
            this.btnCreateFullPack = new System.Windows.Forms.Button();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.groupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bsVersions = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridVersionManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVersions)).BeginInit();
            this.SuspendLayout();
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
            this.gridVersionManager.Location = new System.Drawing.Point(3, 8);
            this.gridVersionManager.Name = "gridVersionManager";
            this.gridVersionManager.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridVersionManager.SettingsKey = "dgrdVersionManager";
            this.gridVersionManager.Size = new System.Drawing.Size(975, 418);
            this.gridVersionManager.TabIndex = 0;
            this.gridVersionManager.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.gridVersionManager.Click += new System.EventHandler(this.gridVersionManager_Click);
            // 
            // btnCreateUserPack
            // 
            this.btnCreateUserPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUserPack.Location = new System.Drawing.Point(466, 14);
            this.btnCreateUserPack.Name = "btnCreateUserPack";
            this.btnCreateUserPack.Size = new System.Drawing.Size(134, 30);
            this.btnCreateUserPack.TabIndex = 7;
            this.btnCreateUserPack.Text = "ساخت پک با فایل کاربر";
            this.btnCreateUserPack.UseVisualStyleBackColor = true;
            this.btnCreateUserPack.Click += new System.EventHandler(this.btnCreateUserPack_Click);
            // 
            // btnCreateCustomPack
            // 
            this.btnCreateCustomPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateCustomPack.Location = new System.Drawing.Point(606, 14);
            this.btnCreateCustomPack.Name = "btnCreateCustomPack";
            this.btnCreateCustomPack.Size = new System.Drawing.Size(117, 30);
            this.btnCreateCustomPack.TabIndex = 6;
            this.btnCreateCustomPack.Text = "ساخت پک انتخابی";
            this.btnCreateCustomPack.UseVisualStyleBackColor = true;
            this.btnCreateCustomPack.Click += new System.EventHandler(this.btnCreateCustomPack_Click);
            // 
            // btnCreateFullPack
            // 
            this.btnCreateFullPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateFullPack.Location = new System.Drawing.Point(729, 14);
            this.btnCreateFullPack.Name = "btnCreateFullPack";
            this.btnCreateFullPack.Size = new System.Drawing.Size(100, 30);
            this.btnCreateFullPack.TabIndex = 5;
            this.btnCreateFullPack.Text = "ساخت پک کامل";
            this.btnCreateFullPack.UseVisualStyleBackColor = true;
            this.btnCreateFullPack.Click += new System.EventHandler(this.btnCreateFullPack_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.gridVersionManager);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(5, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(981, 429);
            this.uiGroupBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateUserPack);
            this.groupBox1.Controls.Add(this.btnCreateCustomPack);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCreateFullPack);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(5, 434);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(981, 50);
            this.groupBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(7, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "انصراف";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::VersionManager.Properties.Resources.add_24;
            this.btnAdd.Location = new System.Drawing.Point(943, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = global::VersionManager.Properties.Resources.refresh_20;
            this.btnRefresh.Location = new System.Drawing.Point(835, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = global::VersionManager.Properties.Resources.edit_24;
            this.btnEdit.Location = new System.Drawing.Point(907, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::VersionManager.Properties.Resources.delete16;
            this.btnDelete.Location = new System.Drawing.Point(871, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bsVersions
            // 
            this.bsVersions.DataSource = typeof(VersionManager.Model.VersionDto);
            // 
            // frmVersionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 489);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVersionManager";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت ورژن";
            this.Load += new System.EventHandler(this.frmVersionManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVersionManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsVersions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Janus.Windows.GridEX.GridEX gridVersionManager;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.BindingSource bsVersions;
        private System.Windows.Forms.Button btnCreateFullPack;
        private System.Windows.Forms.Button btnCreateCustomPack;
        private System.Windows.Forms.Button btnCreateUserPack;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIGroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}