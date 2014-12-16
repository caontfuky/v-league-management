namespace PresentationLayer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bntPublic = new DevExpress.XtraBars.BarButtonItem();
            this.bntFixture = new DevExpress.XtraBars.BarButtonItem();
            this.bntResult = new DevExpress.XtraBars.BarButtonItem();
            this.bntStanding = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.bntListTeam = new DevExpress.XtraBars.BarButtonItem();
            this.bntReferee = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ribbon.ExpandCollapseItem.CloseRadialMenuOnItemClick = true;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.bntPublic,
            this.bntFixture,
            this.bntResult,
            this.bntStanding,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.bntListTeam,
            this.bntReferee,
            this.barButtonItem13});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage5});
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbon.Size = new System.Drawing.Size(1226, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Danh sách đội bóng";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Điều lệ";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // bntPublic
            // 
            this.bntPublic.Caption = "Thông báo";
            this.bntPublic.Glyph = ((System.Drawing.Image)(resources.GetObject("bntPublic.Glyph")));
            this.bntPublic.Id = 6;
            this.bntPublic.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bntPublic.LargeGlyph")));
            this.bntPublic.Name = "bntPublic";
            this.bntPublic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntPublic_ItemClick);
            // 
            // bntFixture
            // 
            this.bntFixture.Caption = "Lịch Thi Đấu";
            this.bntFixture.Glyph = ((System.Drawing.Image)(resources.GetObject("bntFixture.Glyph")));
            this.bntFixture.Id = 7;
            this.bntFixture.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bntFixture.LargeGlyph")));
            this.bntFixture.Name = "bntFixture";
            this.bntFixture.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntFixture_ItemClick);
            // 
            // bntResult
            // 
            this.bntResult.Caption = "Kết quả - Thống kê";
            this.bntResult.Glyph = ((System.Drawing.Image)(resources.GetObject("bntResult.Glyph")));
            this.bntResult.Id = 8;
            this.bntResult.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bntResult.LargeGlyph")));
            this.bntResult.Name = "bntResult";
            this.bntResult.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntResult_ItemClick);
            // 
            // bntStanding
            // 
            this.bntStanding.Caption = "Bảng Xếp Hạng";
            this.bntStanding.Glyph = ((System.Drawing.Image)(resources.GetObject("bntStanding.Glyph")));
            this.bntStanding.Id = 9;
            this.bntStanding.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bntStanding.LargeGlyph")));
            this.bntStanding.Name = "bntStanding";
            this.bntStanding.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntStanding_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Danh Sách Trọng Tài";
            this.barButtonItem8.Id = 10;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Tạo Cơ sở dữ liệu";
            this.barButtonItem9.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.Glyph")));
            this.barButtonItem9.Id = 11;
            this.barButtonItem9.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.LargeGlyph")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Tra cứu";
            this.barButtonItem10.Id = 12;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // bntListTeam
            // 
            this.bntListTeam.Caption = "Danh sách đội bóng";
            this.bntListTeam.Glyph = ((System.Drawing.Image)(resources.GetObject("bntListTeam.Glyph")));
            this.bntListTeam.Id = 13;
            this.bntListTeam.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bntListTeam.LargeGlyph")));
            this.bntListTeam.Name = "bntListTeam";
            this.bntListTeam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntListTeam_ItemClick);
            // 
            // bntReferee
            // 
            this.bntReferee.Caption = "Danh sách trọng tài";
            this.bntReferee.Glyph = ((System.Drawing.Image)(resources.GetObject("bntReferee.Glyph")));
            this.bntReferee.Id = 14;
            this.bntReferee.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bntReferee.LargeGlyph")));
            this.bntReferee.Name = "bntReferee";
            this.bntReferee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntReferee_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Tra cứu";
            this.barButtonItem13.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.Glyph")));
            this.barButtonItem13.Id = 15;
            this.barButtonItem13.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.LargeGlyph")));
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup11,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup12});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Mùa Giải";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.bntListTeam);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bntFixture);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bntResult);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.bntStanding);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bntReferee);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.bntPublic);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.barButtonItem13);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Cơ sở dữ liệu";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 655);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1226, 31);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.ContentImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 144);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1226, 511);
            this.mainPanel.TabIndex = 2;
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.AllowTextClipping = false;
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Quản Lý Đội Bóng";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.AllowTextClipping = false;
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "Quản Lý Đội Bóng";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 686);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem bntPublic;
        private DevExpress.XtraBars.BarButtonItem bntFixture;
        private DevExpress.XtraBars.BarButtonItem bntResult;
        private DevExpress.XtraBars.BarButtonItem bntStanding;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem bntListTeam;
        private DevExpress.XtraBars.BarButtonItem bntReferee;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
    }
}