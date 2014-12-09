namespace PresentationLayer
{
    partial class frmConnectionSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnectionSQL));
            this.labServerName = new DevExpress.XtraEditors.LabelControl();
            this.cmbServerName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labAuthorites = new DevExpress.XtraEditors.LabelControl();
            this.labPass = new DevExpress.XtraEditors.LabelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.labUserName = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labData = new DevExpress.XtraEditors.LabelControl();
            this.cmbAuthorities = new DevExpress.XtraEditors.ComboBoxEdit();
            this.picClose = new DevExpress.XtraEditors.PictureEdit();
            this.picminimize = new DevExpress.XtraEditors.PictureEdit();
            this.txtData = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAuthorities.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picminimize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labServerName
            // 
            this.labServerName.Location = new System.Drawing.Point(29, 52);
            this.labServerName.Name = "labServerName";
            this.labServerName.Size = new System.Drawing.Size(59, 13);
            this.labServerName.TabIndex = 0;
            this.labServerName.Text = "Chọn sever:";
            // 
            // cmbServerName
            // 
            this.cmbServerName.Location = new System.Drawing.Point(169, 49);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbServerName.Size = new System.Drawing.Size(216, 20);
            this.cmbServerName.TabIndex = 1;
            // 
            // labAuthorites
            // 
            this.labAuthorites.Location = new System.Drawing.Point(29, 87);
            this.labAuthorites.Name = "labAuthorites";
            this.labAuthorites.Size = new System.Drawing.Size(79, 13);
            this.labAuthorites.TabIndex = 0;
            this.labAuthorites.Text = "Quyền truy cập:";
            // 
            // labPass
            // 
            this.labPass.Location = new System.Drawing.Point(46, 160);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(48, 13);
            this.labPass.TabIndex = 0;
            this.labPass.Text = "Mật khẩu:";
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(193, 153);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPass.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtPass.Size = new System.Drawing.Size(192, 20);
            this.txtPass.TabIndex = 2;
            // 
            // labUserName
            // 
            this.labUserName.Location = new System.Drawing.Point(46, 124);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(65, 13);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "Tên truy cập:";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(193, 121);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUserName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtUserName.Size = new System.Drawing.Size(192, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(193, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy bỏ";
            // 
            // labData
            // 
            this.labData.Location = new System.Drawing.Point(46, 190);
            this.labData.Name = "labData";
            this.labData.Size = new System.Drawing.Size(104, 13);
            this.labData.TabIndex = 0;
            this.labData.Text = "Tên cơ sở dữ liệu mới:";
            // 
            // cmbAuthorities
            // 
            this.cmbAuthorities.Location = new System.Drawing.Point(169, 84);
            this.cmbAuthorities.Name = "cmbAuthorities";
            this.cmbAuthorities.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAuthorities.Properties.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cmbAuthorities.Size = new System.Drawing.Size(216, 20);
            this.cmbAuthorities.TabIndex = 1;
            this.cmbAuthorities.SelectedIndexChanged += new System.EventHandler(this.cmbAuthorities_SelectedIndexChanged);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(376, 6);
            this.picClose.Name = "picClose";
            this.picClose.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.picClose.Properties.Appearance.Options.UseBackColor = true;
            this.picClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picClose.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picClose.Size = new System.Drawing.Size(28, 26);
            this.picClose.TabIndex = 5;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picminimize
            // 
            this.picminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picminimize.Location = new System.Drawing.Point(347, 6);
            this.picminimize.Name = "picminimize";
            this.picminimize.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.picminimize.Properties.Appearance.Options.UseBackColor = true;
            this.picminimize.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picminimize.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picminimize.Size = new System.Drawing.Size(29, 26);
            this.picminimize.TabIndex = 4;
            this.picminimize.Click += new System.EventHandler(this.picminimize_Click);
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(193, 183);
            this.txtData.Name = "txtData";
            this.txtData.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this.txtData.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtData.Size = new System.Drawing.Size(192, 20);
            this.txtData.TabIndex = 2;
            // 
            // frmConnectionSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 267);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picminimize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.cmbAuthorities);
            this.Controls.Add(this.cmbServerName);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labAuthorites);
            this.Controls.Add(this.labData);
            this.Controls.Add(this.labServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConnectionSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kết nối cơ sở dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.cmbServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAuthorities.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picminimize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labServerName;
        private DevExpress.XtraEditors.ComboBoxEdit cmbServerName;
        private DevExpress.XtraEditors.LabelControl labAuthorites;
        private DevExpress.XtraEditors.LabelControl labPass;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl labUserName;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labData;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAuthorities;
        private DevExpress.XtraEditors.PictureEdit picClose;
        private DevExpress.XtraEditors.PictureEdit picminimize;
        private DevExpress.XtraEditors.TextEdit txtData;
    }
}