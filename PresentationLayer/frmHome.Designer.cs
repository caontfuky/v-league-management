namespace PresentationLayer
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.bbtnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnUserInfo = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnConnectionData = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnBackupData = new DevExpress.XtraBars.BarButtonItem();
            this.bbtAddPlayer = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnNational = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnPosition = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTeamInfo = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnStaditum = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnListTeam = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnMatch = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnFixture = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnStanding = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnCoach = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSeasonInfo = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnResult = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnReferee = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bitemFont = new DevExpress.XtraBars.BarEditItem();
            this.rItemFontEdit = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.ribPSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribPGUserInfo = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPGDataBase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribPGPlayerManager = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPGTeamManger = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPGSeasonManager = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rinPReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribPTool = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribGInterface = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPGFont = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemFontEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbtnLogin,
            this.bbtnLogout,
            this.bbtnUserInfo,
            this.bbtnConnectionData,
            this.bbtnRestore,
            this.bbtnBackupData,
            this.bbtAddPlayer,
            this.bbtnNational,
            this.bbtnPosition,
            this.bbtnTeamInfo,
            this.bbtnStaditum,
            this.bbtnListTeam,
            this.bbtnMatch,
            this.bbtnFixture,
            this.bbtnStanding,
            this.bbtnCoach,
            this.bbtnSeasonInfo,
            this.bbtnResult,
            this.bbtnReferee,
            this.skinRibbonGalleryBarItem,
            this.bitemFont});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribPSystem,
            this.ribPManager,
            this.rinPReport,
            this.ribPTool});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rItemFontEdit});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.Size = new System.Drawing.Size(896, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // bbtnLogin
            // 
            this.bbtnLogin.Caption = "Đăng nhập";
            this.bbtnLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnLogin.Glyph")));
            this.bbtnLogin.Id = 1;
            this.bbtnLogin.Name = "bbtnLogin";
            // 
            // bbtnLogout
            // 
            this.bbtnLogout.Caption = "Đăng xuất";
            this.bbtnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnLogout.Glyph")));
            this.bbtnLogout.Id = 2;
            this.bbtnLogout.Name = "bbtnLogout";
            // 
            // bbtnUserInfo
            // 
            this.bbtnUserInfo.Caption = "Thông tin của bạn";
            this.bbtnUserInfo.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnUserInfo.Glyph")));
            this.bbtnUserInfo.Id = 3;
            this.bbtnUserInfo.Name = "bbtnUserInfo";
            this.bbtnUserInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbtnConnectionData
            // 
            this.bbtnConnectionData.Caption = "Kết nối CSDL";
            this.bbtnConnectionData.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnConnectionData.Glyph")));
            this.bbtnConnectionData.Id = 4;
            this.bbtnConnectionData.Name = "bbtnConnectionData";
            this.bbtnConnectionData.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbtnRestore
            // 
            this.bbtnRestore.Caption = "Phục hồi CSDL";
            this.bbtnRestore.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnRestore.Glyph")));
            this.bbtnRestore.Id = 6;
            this.bbtnRestore.Name = "bbtnRestore";
            // 
            // bbtnBackupData
            // 
            this.bbtnBackupData.Caption = "Sao lưu CSDL";
            this.bbtnBackupData.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnBackupData.Glyph")));
            this.bbtnBackupData.Id = 5;
            this.bbtnBackupData.Name = "bbtnBackupData";
            // 
            // bbtAddPlayer
            // 
            this.bbtAddPlayer.Caption = "Thông tin\r\ncầu thủ";
            this.bbtAddPlayer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtAddPlayer.Glyph")));
            this.bbtAddPlayer.Id = 7;
            this.bbtAddPlayer.Name = "bbtAddPlayer";
            this.bbtAddPlayer.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbtnNational
            // 
            this.bbtnNational.Caption = "Quốc gia";
            this.bbtnNational.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnNational.Glyph")));
            this.bbtnNational.Id = 8;
            this.bbtnNational.Name = "bbtnNational";
            // 
            // bbtnPosition
            // 
            this.bbtnPosition.Caption = "Vị trí";
            this.bbtnPosition.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnPosition.Glyph")));
            this.bbtnPosition.Id = 9;
            this.bbtnPosition.Name = "bbtnPosition";
            // 
            // bbtnTeamInfo
            // 
            this.bbtnTeamInfo.Caption = "Thông tin đội bóng";
            this.bbtnTeamInfo.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnTeamInfo.Glyph")));
            this.bbtnTeamInfo.Id = 10;
            this.bbtnTeamInfo.Name = "bbtnTeamInfo";
            this.bbtnTeamInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbtnStaditum
            // 
            this.bbtnStaditum.Caption = "Sân bóng";
            this.bbtnStaditum.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnStaditum.Glyph")));
            this.bbtnStaditum.Id = 11;
            this.bbtnStaditum.Name = "bbtnStaditum";
            // 
            // bbtnListTeam
            // 
            this.bbtnListTeam.Caption = "Đội bóng tham dự";
            this.bbtnListTeam.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnListTeam.Glyph")));
            this.bbtnListTeam.Id = 12;
            this.bbtnListTeam.Name = "bbtnListTeam";
            this.bbtnListTeam.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbtnMatch
            // 
            this.bbtnMatch.Caption = "Kết quả trận đấu";
            this.bbtnMatch.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnMatch.Glyph")));
            this.bbtnMatch.Id = 13;
            this.bbtnMatch.Name = "bbtnMatch";
            this.bbtnMatch.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbtnFixture
            // 
            this.bbtnFixture.Caption = "Lịch thi đấu";
            this.bbtnFixture.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnFixture.Glyph")));
            this.bbtnFixture.Id = 14;
            this.bbtnFixture.Name = "bbtnFixture";
            this.bbtnFixture.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbtnStanding
            // 
            this.bbtnStanding.Caption = "Bảng xếp hạng";
            this.bbtnStanding.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnStanding.Glyph")));
            this.bbtnStanding.Id = 15;
            this.bbtnStanding.Name = "bbtnStanding";
            this.bbtnStanding.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbtnCoach
            // 
            this.bbtnCoach.Caption = "Huấn luận viên";
            this.bbtnCoach.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnCoach.Glyph")));
            this.bbtnCoach.Id = 16;
            this.bbtnCoach.Name = "bbtnCoach";
            // 
            // bbtnSeasonInfo
            // 
            this.bbtnSeasonInfo.Caption = "Thông tin mùa giải";
            this.bbtnSeasonInfo.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnSeasonInfo.Glyph")));
            this.bbtnSeasonInfo.Id = 17;
            this.bbtnSeasonInfo.Name = "bbtnSeasonInfo";
            this.bbtnSeasonInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbtnResult
            // 
            this.bbtnResult.Caption = "Thành tích";
            this.bbtnResult.Id = 18;
            this.bbtnResult.Name = "bbtnResult";
            // 
            // bbtnReferee
            // 
            this.bbtnReferee.Caption = "Trọng tài";
            this.bbtnReferee.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnReferee.Glyph")));
            this.bbtnReferee.Id = 19;
            this.bbtnReferee.Name = "bbtnReferee";
            this.bbtnReferee.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem.Id = 20;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // bitemFont
            // 
            this.bitemFont.Caption = "Font";
            this.bitemFont.Edit = this.rItemFontEdit;
            this.bitemFont.Id = 21;
            this.bitemFont.Name = "bitemFont";
            this.bitemFont.HiddenEditor += new DevExpress.XtraBars.ItemClickEventHandler(this.changeFont);
            // 
            // rItemFontEdit
            // 
            this.rItemFontEdit.AutoHeight = false;
            this.rItemFontEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rItemFontEdit.Name = "rItemFontEdit";
            // 
            // ribPSystem
            // 
            this.ribPSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribPGUserInfo,
            this.ribPGDataBase});
            this.ribPSystem.Name = "ribPSystem";
            this.ribPSystem.Text = "Hệ thống";
            // 
            // ribPGUserInfo
            // 
            this.ribPGUserInfo.ItemLinks.Add(this.bbtnUserInfo);
            this.ribPGUserInfo.ItemLinks.Add(this.bbtnLogin);
            this.ribPGUserInfo.ItemLinks.Add(this.bbtnLogout);
            this.ribPGUserInfo.Name = "ribPGUserInfo";
            this.ribPGUserInfo.Text = "Thông tin đăng nhập";
            // 
            // ribPGDataBase
            // 
            this.ribPGDataBase.ItemLinks.Add(this.bbtnConnectionData);
            this.ribPGDataBase.ItemLinks.Add(this.bbtnBackupData);
            this.ribPGDataBase.ItemLinks.Add(this.bbtnRestore);
            this.ribPGDataBase.Name = "ribPGDataBase";
            this.ribPGDataBase.Text = "Kết nối CSDL";
            // 
            // ribPManager
            // 
            this.ribPManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribPGPlayerManager,
            this.ribPGTeamManger,
            this.ribPGSeasonManager});
            this.ribPManager.Name = "ribPManager";
            this.ribPManager.Text = "Quản lý";
            // 
            // ribPGPlayerManager
            // 
            this.ribPGPlayerManager.ItemLinks.Add(this.bbtAddPlayer);
            this.ribPGPlayerManager.ItemLinks.Add(this.bbtnNational);
            this.ribPGPlayerManager.ItemLinks.Add(this.bbtnPosition);
            this.ribPGPlayerManager.Name = "ribPGPlayerManager";
            this.ribPGPlayerManager.Text = "Quản lý cầu thủ";
            // 
            // ribPGTeamManger
            // 
            this.ribPGTeamManger.ItemLinks.Add(this.bbtnTeamInfo);
            this.ribPGTeamManger.ItemLinks.Add(this.bbtnStaditum);
            this.ribPGTeamManger.ItemLinks.Add(this.bbtnCoach);
            this.ribPGTeamManger.Name = "ribPGTeamManger";
            this.ribPGTeamManger.Text = "Quản lý đội bóng";
            // 
            // ribPGSeasonManager
            // 
            this.ribPGSeasonManager.ItemLinks.Add(this.bbtnSeasonInfo);
            this.ribPGSeasonManager.ItemLinks.Add(this.bbtnListTeam);
            this.ribPGSeasonManager.ItemLinks.Add(this.bbtnFixture);
            this.ribPGSeasonManager.ItemLinks.Add(this.bbtnMatch);
            this.ribPGSeasonManager.ItemLinks.Add(this.bbtnStanding);
            this.ribPGSeasonManager.ItemLinks.Add(this.bbtnReferee);
            this.ribPGSeasonManager.Name = "ribPGSeasonManager";
            this.ribPGSeasonManager.Text = "Quản lý mùa giải";
            // 
            // rinPReport
            // 
            this.rinPReport.Name = "rinPReport";
            this.rinPReport.Text = "Thống kê";
            // 
            // ribPTool
            // 
            this.ribPTool.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribGInterface,
            this.ribPGFont});
            this.ribPTool.Name = "ribPTool";
            this.ribPTool.Text = "Tùy chọn";
            // 
            // ribGInterface
            // 
            this.ribGInterface.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribGInterface.Name = "ribGInterface";
            this.ribGInterface.Text = "Giao diện";
            // 
            // ribPGFont
            // 
            this.ribPGFont.ItemLinks.Add(this.bitemFont);
            this.ribPGFont.Name = "ribPGFont";
            this.ribPGFont.Text = "Font";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(896, 31);
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.DoubleBuffered = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý giải vô địch bóng đá";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemFontEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPGUserInfo;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbtnLogin;
        private DevExpress.XtraBars.BarButtonItem bbtnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPGDataBase;
        private DevExpress.XtraBars.BarButtonItem bbtnUserInfo;
        private DevExpress.XtraBars.BarButtonItem bbtnConnectionData;
        private DevExpress.XtraBars.BarButtonItem bbtnBackupData;
        private DevExpress.XtraBars.BarButtonItem bbtnRestore;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPManager;
        private DevExpress.XtraBars.BarButtonItem bbtAddPlayer;
        private DevExpress.XtraBars.BarButtonItem bbtnNational;
        private DevExpress.XtraBars.BarButtonItem bbtnPosition;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPGPlayerManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPGTeamManger;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPGSeasonManager;
        private DevExpress.XtraBars.BarButtonItem bbtnTeamInfo;
        private DevExpress.XtraBars.BarButtonItem bbtnStaditum;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonItem bbtnListTeam;
        private DevExpress.XtraBars.BarButtonItem bbtnMatch;
        private DevExpress.XtraBars.BarButtonItem bbtnFixture;
        private DevExpress.XtraBars.BarButtonItem bbtnStanding;
        private DevExpress.XtraBars.BarButtonItem bbtnCoach;
        private DevExpress.XtraBars.BarButtonItem bbtnSeasonInfo;
        private DevExpress.XtraBars.BarButtonItem bbtnResult;
        private DevExpress.XtraBars.BarButtonItem bbtnReferee;
        private DevExpress.XtraBars.Ribbon.RibbonPage rinPReport;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPTool;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGInterface;
        private DevExpress.XtraBars.BarEditItem bitemFont;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit rItemFontEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPGFont;
    }
}