namespace PresentationLayer
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.pnlHead = new DevExpress.XtraEditors.PanelControl();
            this.drBtnClose = new DevExpress.XtraEditors.DropDownButton();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.ppMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbtnSingup = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlHome = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.picBG = new DevExpress.XtraEditors.PictureEdit();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.picStanding = new DevExpress.XtraEditors.PictureEdit();
            this.picMatchResult = new DevExpress.XtraEditors.PictureEdit();
            this.picRefreze = new DevExpress.XtraEditors.PictureEdit();
            this.picTeam = new DevExpress.XtraEditors.PictureEdit();
            this.picPlayer = new DevExpress.XtraEditors.PictureEdit();
            this.picSeason = new DevExpress.XtraEditors.PictureEdit();
            this.picFixture = new DevExpress.XtraEditors.PictureEdit();
            this.picBackGround = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHead)).BeginInit();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHome)).BeginInit();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStanding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatchResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefreze.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFixture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Glass Oceans";
            // 
            // pnlHead
            // 
            this.pnlHead.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlHead.Appearance.Options.UseBackColor = true;
            this.pnlHead.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlHead.Controls.Add(this.drBtnClose);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1342, 69);
            this.pnlHead.TabIndex = 0;
            // 
            // drBtnClose
            // 
            this.drBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drBtnClose.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.drBtnClose.Appearance.Options.UseBackColor = true;
            this.drBtnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.drBtnClose.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.drBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("drBtnClose.Image")));
            this.drBtnClose.Location = new System.Drawing.Point(1205, 32);
            this.drBtnClose.MenuManager = this.barManager;
            this.drBtnClose.Name = "drBtnClose";
            this.barManager.SetPopupContextMenu(this.drBtnClose, this.ppMenu);
            this.drBtnClose.Size = new System.Drawing.Size(41, 37);
            this.drBtnClose.TabIndex = 1;
            this.drBtnClose.ShowDropDownControl += new DevExpress.XtraEditors.ShowDropDownControlEventHandler(this.drBtnClose_ShowDropDownControl);
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtnSingup});
            this.barManager.MaxItemId = 1;
            // 
            // ppMenu
            // 
            this.ppMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnSingup)});
            this.ppMenu.Manager = this.barManager;
            this.ppMenu.Name = "ppMenu";
            // 
            // bbtnSingup
            // 
            this.bbtnSingup.Caption = "Đăng xuất";
            this.bbtnSingup.Id = 0;
            this.bbtnSingup.Name = "bbtnSingup";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1342, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 780);
            this.barDockControlBottom.Size = new System.Drawing.Size(1342, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 780);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1342, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 780);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Appearance.Options.UseBackColor = true;
            this.pnlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 69);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(124, 711);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Appearance.Options.UseBackColor = true;
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1205, 69);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(137, 711);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlHome
            // 
            this.pnlHome.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlHome.Appearance.Options.UseBackColor = true;
            this.pnlHome.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlHome.Controls.Add(this.xtraTabControl1);
            this.pnlHome.Controls.Add(this.picBG);
            this.pnlHome.Controls.Add(this.pnlBottom);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(124, 69);
            this.pnlHome.LookAndFeel.TouchScaleFactor = 5F;
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1081, 711);
            this.pnlHome.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1081, 576);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1075, 550);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1075, 550);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // picBG
            // 
            this.picBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBG.EditValue = ((object)(resources.GetObject("picBG.EditValue")));
            this.picBG.Location = new System.Drawing.Point(9, 82);
            this.picBG.MenuManager = this.barManager;
            this.picBG.Name = "picBG";
            this.picBG.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picBG.Properties.Appearance.Options.UseBackColor = true;
            this.picBG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picBG.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.picBG.Properties.ZoomPercent = 150;
            this.picBG.Size = new System.Drawing.Size(506, 488);
            this.picBG.TabIndex = 2;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlBottom.Controls.Add(this.picStanding);
            this.pnlBottom.Controls.Add(this.picMatchResult);
            this.pnlBottom.Controls.Add(this.picRefreze);
            this.pnlBottom.Controls.Add(this.picTeam);
            this.pnlBottom.Controls.Add(this.picPlayer);
            this.pnlBottom.Controls.Add(this.picSeason);
            this.pnlBottom.Controls.Add(this.picFixture);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 576);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1081, 135);
            this.pnlBottom.TabIndex = 1;
            // 
            // picStanding
            // 
            this.picStanding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picStanding.EditValue = ((object)(resources.GetObject("picStanding.EditValue")));
            this.picStanding.Location = new System.Drawing.Point(876, 23);
            this.picStanding.Name = "picStanding";
            this.picStanding.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picStanding.Properties.Appearance.Options.UseBackColor = true;
            this.picStanding.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picStanding.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.picStanding.Properties.ZoomPercent = 70;
            this.picStanding.Properties.MouseHover += new System.EventHandler(this.picHome_Properties_MouseHover);
            this.picStanding.Properties.MouseLeave += new System.EventHandler(this.picHome_Properties_MouseLeave);
            this.picStanding.Size = new System.Drawing.Size(90, 88);
            this.picStanding.TabIndex = 0;
            // 
            // picMatchResult
            // 
            this.picMatchResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picMatchResult.EditValue = ((object)(resources.GetObject("picMatchResult.EditValue")));
            this.picMatchResult.Location = new System.Drawing.Point(684, 23);
            this.picMatchResult.Name = "picMatchResult";
            this.picMatchResult.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picMatchResult.Properties.Appearance.Options.UseBackColor = true;
            this.picMatchResult.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picMatchResult.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.picMatchResult.Properties.ZoomPercent = 70;
            this.picMatchResult.Properties.MouseHover += new System.EventHandler(this.picHome_Properties_MouseHover);
            this.picMatchResult.Properties.MouseLeave += new System.EventHandler(this.picHome_Properties_MouseLeave);
            this.picMatchResult.Size = new System.Drawing.Size(90, 88);
            this.picMatchResult.TabIndex = 0;
            // 
            // picRefreze
            // 
            this.picRefreze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picRefreze.EditValue = ((object)(resources.GetObject("picRefreze.EditValue")));
            this.picRefreze.Location = new System.Drawing.Point(110, 23);
            this.picRefreze.Name = "picRefreze";
            this.picRefreze.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picRefreze.Properties.Appearance.Options.UseBackColor = true;
            this.picRefreze.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picRefreze.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.picRefreze.Properties.ZoomPercent = 70;
            this.picRefreze.Properties.MouseHover += new System.EventHandler(this.picHome_Properties_MouseHover);
            this.picRefreze.Properties.MouseLeave += new System.EventHandler(this.picHome_Properties_MouseLeave);
            this.picRefreze.Size = new System.Drawing.Size(90, 88);
            this.picRefreze.TabIndex = 0;
            // 
            // picTeam
            // 
            this.picTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTeam.EditValue = ((object)(resources.GetObject("picTeam.EditValue")));
            this.picTeam.Location = new System.Drawing.Point(289, 23);
            this.picTeam.Name = "picTeam";
            this.picTeam.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picTeam.Properties.Appearance.Options.UseBackColor = true;
            this.picTeam.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picTeam.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.picTeam.Properties.ZoomPercent = 70;
            this.picTeam.Properties.MouseHover += new System.EventHandler(this.picHome_Properties_MouseHover);
            this.picTeam.Properties.MouseLeave += new System.EventHandler(this.picHome_Properties_MouseLeave);
            this.picTeam.Size = new System.Drawing.Size(90, 88);
            this.picTeam.TabIndex = 0;
            // 
            // picPlayer
            // 
            this.picPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPlayer.EditValue = ((object)(resources.GetObject("picPlayer.EditValue")));
            this.picPlayer.Location = new System.Drawing.Point(193, 23);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Properties.Appearance.Options.UseBackColor = true;
            this.picPlayer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picPlayer.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.picPlayer.Properties.ZoomPercent = 70;
            this.picPlayer.Properties.MouseHover += new System.EventHandler(this.picHome_Properties_MouseHover);
            this.picPlayer.Properties.MouseLeave += new System.EventHandler(this.picHome_Properties_MouseLeave);
            this.picPlayer.Size = new System.Drawing.Size(90, 88);
            this.picPlayer.TabIndex = 0;
            // 
            // picSeason
            // 
            this.picSeason.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSeason.EditValue = ((object)(resources.GetObject("picSeason.EditValue")));
            this.picSeason.Location = new System.Drawing.Point(493, 23);
            this.picSeason.Name = "picSeason";
            this.picSeason.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picSeason.Properties.Appearance.Options.UseBackColor = true;
            this.picSeason.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picSeason.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.picSeason.Properties.ZoomPercent = 70;
            this.picSeason.Properties.MouseHover += new System.EventHandler(this.picHome_Properties_MouseHover);
            this.picSeason.Properties.MouseLeave += new System.EventHandler(this.picHome_Properties_MouseLeave);
            this.picSeason.Size = new System.Drawing.Size(90, 88);
            this.picSeason.TabIndex = 0;
            // 
            // picFixture
            // 
            this.picFixture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picFixture.EditValue = ((object)(resources.GetObject("picFixture.EditValue")));
            this.picFixture.Location = new System.Drawing.Point(780, 23);
            this.picFixture.MenuManager = this.barManager;
            this.picFixture.Name = "picFixture";
            this.picFixture.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picFixture.Properties.Appearance.Options.UseBackColor = true;
            this.picFixture.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picFixture.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.picFixture.Properties.ZoomPercent = 70;
            this.picFixture.Properties.MouseHover += new System.EventHandler(this.picHome_Properties_MouseHover);
            this.picFixture.Properties.MouseLeave += new System.EventHandler(this.picHome_Properties_MouseLeave);
            this.picFixture.Size = new System.Drawing.Size(90, 88);
            this.picFixture.TabIndex = 0;
            // 
            // picBackGround
            // 
            this.picBackGround.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBackGround.EditValue = ((object)(resources.GetObject("picBackGround.EditValue")));
            this.picBackGround.Location = new System.Drawing.Point(114, -7);
            this.picBackGround.MenuManager = this.barManager;
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picBackGround.Properties.Appearance.Options.UseBackColor = true;
            this.picBackGround.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picBackGround.Size = new System.Drawing.Size(364, 319);
            this.picBackGround.TabIndex = 2;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1342, 780);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.SkinName = "Dark Side";
            this.Name = "frmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlHead)).EndInit();
            this.pnlHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHome)).EndInit();
            this.pnlHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStanding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatchResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefreze.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFixture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.PanelControl pnlHead;
        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.PanelControl pnlHome;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.DropDownButton drBtnClose;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu ppMenu;
        private DevExpress.XtraBars.BarButtonItem bbtnSingup;
        private DevExpress.XtraEditors.PictureEdit picFixture;
        private DevExpress.XtraEditors.PictureEdit picBG;
        private DevExpress.XtraEditors.PictureEdit picBackGround;
        private DevExpress.XtraEditors.PictureEdit picStanding;
        private DevExpress.XtraEditors.PictureEdit picSeason;
        private DevExpress.XtraEditors.PictureEdit picPlayer;
        private DevExpress.XtraEditors.PictureEdit picMatchResult;
        private DevExpress.XtraEditors.PictureEdit picTeam;
        private DevExpress.XtraEditors.PictureEdit picRefreze;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
    }
}