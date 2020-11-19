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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowsAlterScript = new System.Windows.Forms.Button();
            this.btnBrowsStructureScript = new System.Windows.Forms.Button();
            this.btnBrowsDll = new System.Windows.Forms.Button();
            this.txtVersionDescription = new System.Windows.Forms.TextBox();
            this.bsVersions = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlterScriptPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStructureScriptPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDllPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVersionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVersionCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVersions)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBrowsAlterScript);
            this.panel1.Controls.Add(this.btnBrowsStructureScript);
            this.panel1.Controls.Add(this.btnBrowsDll);
            this.panel1.Controls.Add(this.txtVersionDescription);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAlterScriptPath);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtStructureScriptPath);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDllPath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtVersionName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtVersionCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 236);
            this.panel1.TabIndex = 0;
            // 
            // btnBrowsAlterScript
            // 
            this.btnBrowsAlterScript.Location = new System.Drawing.Point(11, 96);
            this.btnBrowsAlterScript.Name = "btnBrowsAlterScript";
            this.btnBrowsAlterScript.Size = new System.Drawing.Size(43, 22);
            this.btnBrowsAlterScript.TabIndex = 14;
            this.btnBrowsAlterScript.Text = "...";
            this.btnBrowsAlterScript.UseCompatibleTextRendering = true;
            this.btnBrowsAlterScript.UseVisualStyleBackColor = true;
            this.btnBrowsAlterScript.Click += new System.EventHandler(this.btnBrowsAlterScript_Click);
            // 
            // btnBrowsStructureScript
            // 
            this.btnBrowsStructureScript.Location = new System.Drawing.Point(11, 68);
            this.btnBrowsStructureScript.Name = "btnBrowsStructureScript";
            this.btnBrowsStructureScript.Size = new System.Drawing.Size(43, 22);
            this.btnBrowsStructureScript.TabIndex = 13;
            this.btnBrowsStructureScript.Text = "...";
            this.btnBrowsStructureScript.UseCompatibleTextRendering = true;
            this.btnBrowsStructureScript.UseVisualStyleBackColor = true;
            this.btnBrowsStructureScript.Click += new System.EventHandler(this.btnBrowsStructureScript_Click);
            // 
            // btnBrowsDll
            // 
            this.btnBrowsDll.Location = new System.Drawing.Point(11, 40);
            this.btnBrowsDll.Name = "btnBrowsDll";
            this.btnBrowsDll.Size = new System.Drawing.Size(43, 22);
            this.btnBrowsDll.TabIndex = 12;
            this.btnBrowsDll.Text = "...";
            this.btnBrowsDll.UseCompatibleTextRendering = true;
            this.btnBrowsDll.UseVisualStyleBackColor = true;
            this.btnBrowsDll.Click += new System.EventHandler(this.btnBrowsDll_Click);
            // 
            // txtVersionDescription
            // 
            this.txtVersionDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersionDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "VersionDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVersionDescription.Location = new System.Drawing.Point(60, 124);
            this.txtVersionDescription.Multiline = true;
            this.txtVersionDescription.Name = "txtVersionDescription";
            this.txtVersionDescription.Size = new System.Drawing.Size(561, 100);
            this.txtVersionDescription.TabIndex = 11;
            // 
            // bsVersions
            // 
            this.bsVersions.DataSource = typeof(VersionManager.Model.VersionsDto);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "توضیحات :";
            // 
            // txtAlterScriptPath
            // 
            this.txtAlterScriptPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlterScriptPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "AlterScriptPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAlterScriptPath.Location = new System.Drawing.Point(60, 96);
            this.txtAlterScriptPath.Name = "txtAlterScriptPath";
            this.txtAlterScriptPath.Size = new System.Drawing.Size(561, 22);
            this.txtAlterScriptPath.TabIndex = 9;
            this.txtAlterScriptPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "فایل اسکریپت تغییرات :";
            // 
            // txtStructureScriptPath
            // 
            this.txtStructureScriptPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStructureScriptPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "StructureScriptPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtStructureScriptPath.Location = new System.Drawing.Point(60, 68);
            this.txtStructureScriptPath.Name = "txtStructureScriptPath";
            this.txtStructureScriptPath.Size = new System.Drawing.Size(561, 22);
            this.txtStructureScriptPath.TabIndex = 7;
            this.txtStructureScriptPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "فایل اسکریپت ساختار :";
            // 
            // txtDllPath
            // 
            this.txtDllPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDllPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "DllPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDllPath.Location = new System.Drawing.Point(60, 40);
            this.txtDllPath.Name = "txtDllPath";
            this.txtDllPath.Size = new System.Drawing.Size(561, 22);
            this.txtDllPath.TabIndex = 5;
            this.txtDllPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "مسیر فایلهای ورژن :";
            // 
            // txtVersionName
            // 
            this.txtVersionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersionName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "VersionName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVersionName.Location = new System.Drawing.Point(299, 12);
            this.txtVersionName.Name = "txtVersionName";
            this.txtVersionName.Size = new System.Drawing.Size(131, 22);
            this.txtVersionName.TabIndex = 3;
            this.txtVersionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام ورژن :";
            // 
            // txtVersionCode
            // 
            this.txtVersionCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersionCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersions, "VersionCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVersionCode.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsVersions, "VersionCode", true));
            this.txtVersionCode.Location = new System.Drawing.Point(521, 12);
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
            this.label1.Location = new System.Drawing.Point(627, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره ورژن :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(11, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "انصراف";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(92, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmVersionManagerAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmVersionManagerAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورژن جدید";
            this.Load += new System.EventHandler(this.frmVersionManagerAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVersions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtVersionDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlterScriptPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStructureScriptPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDllPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVersionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVersionCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowsAlterScript;
        private System.Windows.Forms.Button btnBrowsStructureScript;
        private System.Windows.Forms.Button btnBrowsDll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsVersions;
    }
}