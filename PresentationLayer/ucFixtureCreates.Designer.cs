namespace PresentationLayer
{
    partial class ucFixtureCreates
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFixtureCreates));
            this.grdvMatch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMatchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHomeTeam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitingTeam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStadium = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdFixture = new DevExpress.XtraGrid.GridControl();
            this.grdvRound = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoundName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateStart = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.tabPageFixture = new DevExpress.XtraTab.XtraTabPage();
            this.grpFixture = new DevExpress.XtraEditors.GroupControl();
            this.grpListTeam = new DevExpress.XtraEditors.GroupControl();
            this.grdListTeam = new DevExpress.XtraGrid.GridControl();
            this.grdvListTeam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTeamID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeamName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManagerOfTeam = new DevExpress.XtraBars.BarManager(this.components);
            this.barTool = new DevExpress.XtraBars.Bar();
            this.bbtnAutoCreate = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnWizardCreate = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panHome = new DevExpress.XtraEditors.PanelControl();
            this.labSeason = new DevExpress.XtraEditors.LabelControl();
            this.lkSeason = new DevExpress.XtraEditors.LookUpEdit();
            this.tabHome = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdvMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFixture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.CalendarTimeProperties)).BeginInit();
            this.tabPageFixture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFixture)).BeginInit();
            this.grpFixture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpListTeam)).BeginInit();
            this.grpListTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerOfTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panHome)).BeginInit();
            this.panHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkSeason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabHome)).BeginInit();
            this.tabHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdvMatch
            // 
            this.grdvMatch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatchID,
            this.colHomeTeam,
            this.colVisitingTeam,
            this.colStadium,
            this.colStartDate,
            this.colReferee});
            this.grdvMatch.GridControl = this.grdFixture;
            this.grdvMatch.Name = "grdvMatch";
            this.grdvMatch.OptionsView.ShowGroupPanel = false;
            // 
            // colMatchID
            // 
            this.colMatchID.Caption = "Mã trận đấu";
            this.colMatchID.FieldName = "MatchID";
            this.colMatchID.Name = "colMatchID";
            this.colMatchID.Visible = true;
            this.colMatchID.VisibleIndex = 0;
            // 
            // colHomeTeam
            // 
            this.colHomeTeam.Caption = "Đội nhà";
            this.colHomeTeam.FieldName = "HomeTeam";
            this.colHomeTeam.Name = "colHomeTeam";
            this.colHomeTeam.Visible = true;
            this.colHomeTeam.VisibleIndex = 1;
            // 
            // colVisitingTeam
            // 
            this.colVisitingTeam.Caption = "Đội khách";
            this.colVisitingTeam.FieldName = "VisitingTeam";
            this.colVisitingTeam.Name = "colVisitingTeam";
            this.colVisitingTeam.Visible = true;
            this.colVisitingTeam.VisibleIndex = 2;
            // 
            // colStadium
            // 
            this.colStadium.Caption = "Sân bóng";
            this.colStadium.FieldName = "Stadium";
            this.colStadium.Name = "colStadium";
            this.colStadium.Visible = true;
            this.colStadium.VisibleIndex = 3;
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Ngày bắt đầu";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 4;
            // 
            // colReferee
            // 
            this.colReferee.Caption = "Trọng tài";
            this.colReferee.FieldName = "Referee";
            this.colReferee.Name = "colReferee";
            this.colReferee.Visible = true;
            this.colReferee.VisibleIndex = 5;
            // 
            // grdFixture
            // 
            this.grdFixture.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdFixture.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.grdvMatch;
            gridLevelNode1.RelationName = "Match";
            this.grdFixture.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdFixture.Location = new System.Drawing.Point(2, 21);
            this.grdFixture.MainView = this.grdvRound;
            this.grdFixture.Name = "grdFixture";
            this.grdFixture.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dateStart});
            this.grdFixture.Size = new System.Drawing.Size(607, 363);
            this.grdFixture.TabIndex = 3;
            this.grdFixture.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvRound,
            this.grdvMatch});
            // 
            // grdvRound
            // 
            this.grdvRound.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoundName});
            this.grdvRound.GridControl = this.grdFixture;
            this.grdvRound.Name = "grdvRound";
            this.grdvRound.OptionsView.ShowGroupPanel = false;
            // 
            // colRoundName
            // 
            this.colRoundName.Caption = "Tên vòng đấu";
            this.colRoundName.FieldName = "Name";
            this.colRoundName.Name = "colRoundName";
            this.colRoundName.Visible = true;
            this.colRoundName.VisibleIndex = 0;
            // 
            // dateStart
            // 
            this.dateStart.AutoHeight = false;
            this.dateStart.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Name = "dateStart";
            // 
            // tabPageFixture
            // 
            this.tabPageFixture.Controls.Add(this.grpFixture);
            this.tabPageFixture.Controls.Add(this.grpListTeam);
            this.tabPageFixture.Controls.Add(this.panHome);
            this.tabPageFixture.Name = "tabPageFixture";
            this.tabPageFixture.Size = new System.Drawing.Size(883, 441);
            this.tabPageFixture.Text = "Lịch thi đấu";
            // 
            // grpFixture
            // 
            this.grpFixture.Controls.Add(this.grdFixture);
            this.grpFixture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFixture.Location = new System.Drawing.Point(272, 55);
            this.grpFixture.Name = "grpFixture";
            this.grpFixture.Size = new System.Drawing.Size(611, 386);
            this.grpFixture.TabIndex = 4;
            this.grpFixture.Text = "Lịch thi đấu";
            // 
            // grpListTeam
            // 
            this.grpListTeam.Controls.Add(this.grdListTeam);
            this.grpListTeam.Controls.Add(this.barDockControlLeft);
            this.grpListTeam.Controls.Add(this.barDockControlRight);
            this.grpListTeam.Controls.Add(this.barDockControlBottom);
            this.grpListTeam.Controls.Add(this.barDockControlTop);
            this.grpListTeam.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpListTeam.Location = new System.Drawing.Point(0, 55);
            this.grpListTeam.Name = "grpListTeam";
            this.grpListTeam.Size = new System.Drawing.Size(272, 386);
            this.grpListTeam.TabIndex = 5;
            this.grpListTeam.Text = "Thông tin đội bóng";
            // 
            // grdListTeam
            // 
            this.grdListTeam.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdListTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListTeam.Location = new System.Drawing.Point(2, 21);
            this.grdListTeam.MainView = this.grdvListTeam;
            this.grdListTeam.MenuManager = this.barManagerOfTeam;
            this.grdListTeam.Name = "grdListTeam";
            this.grdListTeam.Size = new System.Drawing.Size(268, 316);
            this.grdListTeam.TabIndex = 4;
            this.grdListTeam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListTeam});
            // 
            // grdvListTeam
            // 
            this.grdvListTeam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTeamID,
            this.colTeamName});
            this.grdvListTeam.GridControl = this.grdListTeam;
            this.grdvListTeam.Name = "grdvListTeam";
            this.grdvListTeam.OptionsView.ShowGroupPanel = false;
            // 
            // colTeamID
            // 
            this.colTeamID.Caption = "Mã đội bóng";
            this.colTeamID.FieldName = "TeamID";
            this.colTeamID.Name = "colTeamID";
            this.colTeamID.Visible = true;
            this.colTeamID.VisibleIndex = 0;
            // 
            // colTeamName
            // 
            this.colTeamName.Caption = "Tên đội bóng";
            this.colTeamName.FieldName = "Name";
            this.colTeamName.Name = "colTeamName";
            this.colTeamName.Visible = true;
            this.colTeamName.VisibleIndex = 1;
            // 
            // barManagerOfTeam
            // 
            this.barManagerOfTeam.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barTool});
            this.barManagerOfTeam.DockControls.Add(this.barDockControlTop);
            this.barManagerOfTeam.DockControls.Add(this.barDockControlBottom);
            this.barManagerOfTeam.DockControls.Add(this.barDockControlLeft);
            this.barManagerOfTeam.DockControls.Add(this.barDockControlRight);
            this.barManagerOfTeam.Form = this.grpListTeam;
            this.barManagerOfTeam.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtnAutoCreate,
            this.bbtnWizardCreate});
            this.barManagerOfTeam.MaxItemId = 2;
            // 
            // barTool
            // 
            this.barTool.BarName = "Tools";
            this.barTool.DockCol = 0;
            this.barTool.DockRow = 0;
            this.barTool.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barTool.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnAutoCreate),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnWizardCreate)});
            this.barTool.OptionsBar.AllowRename = true;
            this.barTool.OptionsBar.UseWholeRow = true;
            this.barTool.Text = "Tools";
            // 
            // bbtnAutoCreate
            // 
            this.bbtnAutoCreate.Caption = "Tạo lịch tự động";
            this.bbtnAutoCreate.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnAutoCreate.Glyph")));
            this.bbtnAutoCreate.Id = 0;
            this.bbtnAutoCreate.Name = "bbtnAutoCreate";
            // 
            // bbtnWizardCreate
            // 
            this.bbtnWizardCreate.Caption = "Tạo lịch bằng tay";
            this.bbtnWizardCreate.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnWizardCreate.Glyph")));
            this.bbtnWizardCreate.Id = 1;
            this.bbtnWizardCreate.Name = "bbtnWizardCreate";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(2, 21);
            this.barDockControlTop.Size = new System.Drawing.Size(268, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(2, 337);
            this.barDockControlBottom.Size = new System.Drawing.Size(268, 47);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(2, 21);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 316);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(270, 21);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 316);
            // 
            // panHome
            // 
            this.panHome.Controls.Add(this.labSeason);
            this.panHome.Controls.Add(this.lkSeason);
            this.panHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHome.Location = new System.Drawing.Point(0, 0);
            this.panHome.Name = "panHome";
            this.panHome.Size = new System.Drawing.Size(883, 55);
            this.panHome.TabIndex = 2;
            // 
            // labSeason
            // 
            this.labSeason.Location = new System.Drawing.Point(19, 22);
            this.labSeason.Name = "labSeason";
            this.labSeason.Size = new System.Drawing.Size(67, 13);
            this.labSeason.TabIndex = 1;
            this.labSeason.Text = "Chọn mùa giải";
            // 
            // lkSeason
            // 
            this.lkSeason.Location = new System.Drawing.Point(112, 19);
            this.lkSeason.Name = "lkSeason";
            this.lkSeason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkSeason.Properties.NullText = "[Chưa chọn mùa giải]";
            this.lkSeason.Size = new System.Drawing.Size(188, 20);
            this.lkSeason.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHome.Location = new System.Drawing.Point(0, 0);
            this.tabHome.Name = "tabHome";
            this.tabHome.SelectedTabPage = this.tabPageFixture;
            this.tabHome.Size = new System.Drawing.Size(889, 469);
            this.tabHome.TabIndex = 0;
            this.tabHome.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageFixture});
            // 
            // ucFixtureCreates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabHome);
            this.Name = "ucFixtureCreates";
            this.Size = new System.Drawing.Size(889, 469);
            ((System.ComponentModel.ISupportInitialize)(this.grdvMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFixture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart)).EndInit();
            this.tabPageFixture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpFixture)).EndInit();
            this.grpFixture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpListTeam)).EndInit();
            this.grpListTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerOfTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panHome)).EndInit();
            this.panHome.ResumeLayout(false);
            this.panHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkSeason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabHome)).EndInit();
            this.tabHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage tabPageFixture;
        private DevExpress.XtraTab.XtraTabControl tabHome;
        private DevExpress.XtraEditors.GroupControl grpFixture;
        private DevExpress.XtraGrid.GridControl grdFixture;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvMatch;
        private DevExpress.XtraGrid.Columns.GridColumn colMatchID;
        private DevExpress.XtraGrid.Columns.GridColumn colHomeTeam;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitingTeam;
        private DevExpress.XtraGrid.Columns.GridColumn colStadium;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colReferee;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvRound;
        private DevExpress.XtraEditors.PanelControl panHome;
        private DevExpress.XtraEditors.LabelControl labSeason;
        private DevExpress.XtraEditors.LookUpEdit lkSeason;
        private DevExpress.XtraGrid.Columns.GridColumn colRoundName;
        private DevExpress.XtraEditors.GroupControl grpListTeam;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManagerOfTeam;
        private DevExpress.XtraBars.Bar barTool;
        private DevExpress.XtraBars.BarButtonItem bbtnAutoCreate;
        private DevExpress.XtraBars.BarButtonItem bbtnWizardCreate;
        private DevExpress.XtraGrid.GridControl grdListTeam;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListTeam;
        private DevExpress.XtraGrid.Columns.GridColumn colTeamID;
        private DevExpress.XtraGrid.Columns.GridColumn colTeamName;
    }
}
