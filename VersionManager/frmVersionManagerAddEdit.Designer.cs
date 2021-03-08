namespace VersionManager
{
    partial class frmVersionManagerAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVersionManagerAddEdit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtAlterScriptPath = new Janus.Windows.GridEX.EditControls.EditBox();
            this.bsVersions = new System.Windows.Forms.BindingSource(this.components);
            this.txtStructureScriptPath = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtDllPath = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtVersionCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVersionName = new System.Windows.Forms.TextBox();
            this.txtVersionDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVersions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiGroupBox1);
            this.panel1.Controls.Add(this.uiGroupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 309);
            this.panel1.TabIndex = 0;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.txtAlterScriptPath);
            this.uiGroupBox1.Controls.Add(this.txtStructureScriptPath);
            this.uiGroupBox1.Controls.Add(this.txtDllPath);
            this.uiGroupBox1.Controls.Add(this.txtVersionCode);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.txtVersionName);
            this.uiGroupBox1.Controls.Add(this.txtVersionDescription);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.label6);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(731, 259);
            this.uiGroupBox1.TabIndex = 15;
            // 
            // txtAlterScriptPath
            // 
            this.txtAlterScriptPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlterScriptPath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtAlterScriptPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "AlterScriptPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAlterScriptPath.Location = new System.Drawing.Point(14, 95);
            this.txtAlterScriptPath.Name = "txtAlterScriptPath";
            this.txtAlterScriptPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAlterScriptPath.Size = new System.Drawing.Size(585, 22);
            this.txtAlterScriptPath.TabIndex = 14;
            this.txtAlterScriptPath.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
            this.txtAlterScriptPath.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.txtAlterScriptPath.ButtonClick += new System.EventHandler(this.btnBrowsAlterScript_Click);
            // 
            // bsVersions
            // 
            this.bsVersions.DataSource = typeof(VersionManager.Model.VersionDto);
            // 
            // txtStructureScriptPath
            // 
            this.txtStructureScriptPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStructureScriptPath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtStructureScriptPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "StructureScriptPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtStructureScriptPath.Location = new System.Drawing.Point(14, 67);
            this.txtStructureScriptPath.Name = "txtStructureScriptPath";
            this.txtStructureScriptPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStructureScriptPath.Size = new System.Drawing.Size(585, 22);
            this.txtStructureScriptPath.TabIndex = 13;
            this.txtStructureScriptPath.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
            this.txtStructureScriptPath.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.txtStructureScriptPath.ButtonClick += new System.EventHandler(this.btnBrowsStructureScript_Click);
            // 
            // txtDllPath
            // 
            this.txtDllPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDllPath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtDllPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "DllPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDllPath.Location = new System.Drawing.Point(14, 39);
            this.txtDllPath.Name = "txtDllPath";
            this.txtDllPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDllPath.Size = new System.Drawing.Size(585, 22);
            this.txtDllPath.TabIndex = 12;
            this.txtDllPath.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
            this.txtDllPath.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.txtDllPath.ButtonClick += new System.EventHandler(this.btnBrowsDll_Click);
            // 
            // txtVersionCode
            // 
            this.txtVersionCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersionCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "VersionCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVersionCode.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsVersions, "VersionCode", true));
            this.txtVersionCode.Location = new System.Drawing.Point(499, 12);
            this.txtVersionCode.Name = "txtVersionCode";
            this.txtVersionCode.Size = new System.Drawing.Size(100, 22);
            this.txtVersionCode.TabIndex = 1;
            this.txtVersionCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVersionCode.TextChanged += new System.EventHandler(this.txtVersionCode_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره ورژن :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام ورژن :";
            // 
            // txtVersionName
            // 
            this.txtVersionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersionName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "VersionName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVersionName.Location = new System.Drawing.Point(277, 12);
            this.txtVersionName.Name = "txtVersionName";
            this.txtVersionName.Size = new System.Drawing.Size(131, 22);
            this.txtVersionName.TabIndex = 3;
            this.txtVersionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVersionDescription
            // 
            this.txtVersionDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersionDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "VersionDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVersionDescription.Location = new System.Drawing.Point(14, 124);
            this.txtVersionDescription.Multiline = true;
            this.txtVersionDescription.Name = "txtVersionDescription";
            this.txtVersionDescription.Size = new System.Drawing.Size(585, 123);
            this.txtVersionDescription.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "مسیر فایلهای ورژن :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(666, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "توضیحات :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "فایل اسکریپت ساختار :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "فایل اسکریپت تغییرات :";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.btnClose);
            this.uiGroupBox2.Controls.Add(this.btnSave);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 259);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(731, 50);
            this.uiGroupBox2.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::VersionManager.Properties.Resources.Logout_icon;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(7, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "انصراف";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::VersionManager.Properties.Resources.save_20;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(75, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ذخیره";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmVersionManagerAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 319);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVersionManagerAddEdit";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورژن جدید";
            this.Load += new System.EventHandler(this.frmVersionManagerAddEdit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVersions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVersionDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVersionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVersionCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsVersions;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.GridEX.EditControls.EditBox txtAlterScriptPath;
        private Janus.Windows.GridEX.EditControls.EditBox txtStructureScriptPath;
        private Janus.Windows.GridEX.EditControls.EditBox txtDllPath;
    }
}