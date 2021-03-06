﻿namespace PresentationLayer
{
    partial class ucListTeamDemo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelSeason = new DevExpress.XtraEditors.LabelControl();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.cbxSeason = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bntDelTeam = new DevExpress.XtraEditors.SimpleButton();
            this.bntUpdateTeam = new DevExpress.XtraEditors.SimpleButton();
            this.bntAddTeam = new DevExpress.XtraEditors.SimpleButton();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbxTeamList = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bntAddIntoSeason = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSeason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTeamList.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.labelSeason);
            this.panelControl1.Controls.Add(this.labelTitle);
            this.panelControl1.Controls.Add(this.cbxSeason);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1171, 39);
            this.panelControl1.TabIndex = 0;
            // 
            // labelSeason
            // 
            this.labelSeason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeason.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelSeason.Location = new System.Drawing.Point(576, 12);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(25, 16);
            this.labelSeason.TabIndex = 6;
            this.labelSeason.Text = "Text";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelTitle.Location = new System.Drawing.Point(334, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(236, 17);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "DANH SÁCH CÁC ĐỘI BÓNG MÙA GIẢI ";
            // 
            // cbxSeason
            // 
            this.cbxSeason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSeason.Location = new System.Drawing.Point(1025, 13);
            this.cbxSeason.Name = "cbxSeason";
            this.cbxSeason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSeason.Size = new System.Drawing.Size(127, 20);
            this.cbxSeason.TabIndex = 4;
            this.cbxSeason.SelectedIndexChanged += new System.EventHandler(this.cbxSeason_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(938, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn mùa giải: ";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.tileControl1);
            this.panelControl2.Location = new System.Drawing.Point(0, 39);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(893, 619);
            this.panelControl2.TabIndex = 1;
            // 
            // tileControl1
            // 
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.IndentBetweenItems = 30;
            this.tileControl1.Location = new System.Drawing.Point(2, 2);
            this.tileControl1.MaxId = 1;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(889, 615);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Location = new System.Drawing.Point(897, 39);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(274, 619);
            this.panelControl3.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bntAddIntoSeason);
            this.groupControl1.Controls.Add(this.cbxTeamList);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.bntDelTeam);
            this.groupControl1.Controls.Add(this.bntUpdateTeam);
            this.groupControl1.Controls.Add(this.bntAddTeam);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(270, 615);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "TÁC VỤ";
            // 
            // bntDelTeam
            // 
            this.bntDelTeam.Location = new System.Drawing.Point(87, 482);
            this.bntDelTeam.Name = "bntDelTeam";
            this.bntDelTeam.Size = new System.Drawing.Size(98, 52);
            this.bntDelTeam.TabIndex = 2;
            this.bntDelTeam.Text = "Xóa TT Đội Bóng";
            this.bntDelTeam.Click += new System.EventHandler(this.bntDelTeam_Click);
            // 
            // bntUpdateTeam
            // 
            this.bntUpdateTeam.Location = new System.Drawing.Point(87, 391);
            this.bntUpdateTeam.Name = "bntUpdateTeam";
            this.bntUpdateTeam.Size = new System.Drawing.Size(98, 52);
            this.bntUpdateTeam.TabIndex = 1;
            this.bntUpdateTeam.Text = "Sửa TT Đội Bóng";
            this.bntUpdateTeam.Click += new System.EventHandler(this.bntUpdateTeam_Click);
            // 
            // bntAddTeam
            // 
            this.bntAddTeam.Location = new System.Drawing.Point(87, 299);
            this.bntAddTeam.Name = "bntAddTeam";
            this.bntAddTeam.Size = new System.Drawing.Size(98, 52);
            this.bntAddTeam.TabIndex = 0;
            this.bntAddTeam.Text = "Thêm Mới Đội Bóng";
            this.bntAddTeam.Click += new System.EventHandler(this.bntAddTeam_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelControl1);
            this.panelMain.Controls.Add(this.panelControl3);
            this.panelMain.Controls.Add(this.panelControl2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1174, 658);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "DS Đội Bóng:";
            // 
            // cbxTeamList
            // 
            this.cbxTeamList.Location = new System.Drawing.Point(16, 71);
            this.cbxTeamList.Name = "cbxTeamList";
            this.cbxTeamList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTeamList.Size = new System.Drawing.Size(237, 20);
            this.cbxTeamList.TabIndex = 4;
            this.cbxTeamList.SelectedIndexChanged += new System.EventHandler(this.cbxTeamList_SelectedIndexChanged);
            // 
            // bntAddIntoSeason
            // 
            this.bntAddIntoSeason.Location = new System.Drawing.Point(16, 124);
            this.bntAddIntoSeason.Name = "bntAddIntoSeason";
            this.bntAddIntoSeason.Size = new System.Drawing.Size(98, 52);
            this.bntAddIntoSeason.TabIndex = 5;
            this.bntAddIntoSeason.Text = "Thêm Đội Vào Mùa";
            this.bntAddIntoSeason.Click += new System.EventHandler(this.bntAddIntoSeason_Click);
            // 
            // ucListTeamDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "ucListTeamDemo";
            this.Size = new System.Drawing.Size(1174, 658);
            this.Load += new System.EventHandler(this.ucListTeamDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSeason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxTeamList.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbxSeason;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bntDelTeam;
        private DevExpress.XtraEditors.SimpleButton bntUpdateTeam;
        private DevExpress.XtraEditors.SimpleButton bntAddTeam;
        private DevExpress.XtraEditors.LabelControl labelSeason;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraEditors.SimpleButton bntAddIntoSeason;
        private DevExpress.XtraEditors.ComboBoxEdit cbxTeamList;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
