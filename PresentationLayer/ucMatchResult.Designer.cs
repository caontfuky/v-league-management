namespace PresentationLayer
{
    partial class ucMatchResult
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
            this.tabListMatchOfRound = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.pnlCenter = new DevExpress.XtraEditors.PanelControl();
            this.grpMatch = new DevExpress.XtraEditors.GroupControl();
            this.grdListMatchOfRound = new DevExpress.XtraGrid.GridControl();
            this.grdvListMatchOfRound = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpRoundValue = new DevExpress.XtraEditors.GroupControl();
            this.grdListRoundOfSeason = new DevExpress.XtraGrid.GridControl();
            this.grdvListRoundOfSeason = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.labSeason = new DevExpress.XtraEditors.LabelControl();
            this.lkSeason = new DevExpress.XtraEditors.LookUpEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.colMatchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHomeTeam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitingTeam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabListMatchOfRound)).BeginInit();
            this.tabListMatchOfRound.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).BeginInit();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMatch)).BeginInit();
            this.grpMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListMatchOfRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListMatchOfRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpRoundValue)).BeginInit();
            this.grpRoundValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoundOfSeason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoundOfSeason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkSeason.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabListMatchOfRound
            // 
            this.tabListMatchOfRound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListMatchOfRound.Location = new System.Drawing.Point(0, 0);
            this.tabListMatchOfRound.Name = "tabListMatchOfRound";
            this.tabListMatchOfRound.SelectedTabPage = this.xtraTabPage1;
            this.tabListMatchOfRound.Size = new System.Drawing.Size(732, 459);
            this.tabListMatchOfRound.TabIndex = 0;
            this.tabListMatchOfRound.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.pnlCenter);
            this.xtraTabPage1.Controls.Add(this.pnlTop);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(726, 431);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.grpMatch);
            this.pnlCenter.Controls.Add(this.grpRoundValue);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 51);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(726, 380);
            this.pnlCenter.TabIndex = 1;
            // 
            // grpMatch
            // 
            this.grpMatch.Controls.Add(this.grdListMatchOfRound);
            this.grpMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMatch.Location = new System.Drawing.Point(202, 2);
            this.grpMatch.Name = "grpMatch";
            this.grpMatch.Size = new System.Drawing.Size(522, 376);
            this.grpMatch.TabIndex = 1;
            this.grpMatch.Text = "Danh sách trận đấu";
            // 
            // grdListMatchOfRound
            // 
            this.grdListMatchOfRound.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdListMatchOfRound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListMatchOfRound.Location = new System.Drawing.Point(2, 21);
            this.grdListMatchOfRound.MainView = this.grdvListMatchOfRound;
            this.grdListMatchOfRound.Name = "grdListMatchOfRound";
            this.grdListMatchOfRound.Size = new System.Drawing.Size(518, 353);
            this.grdListMatchOfRound.TabIndex = 0;
            this.grdListMatchOfRound.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListMatchOfRound});
            // 
            // grdvListMatchOfRound
            // 
            this.grdvListMatchOfRound.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatchID,
            this.colHomeTeam,
            this.colVisitingTeam,
            this.colStartDate,
            this.colScore,
            this.colState});
            this.grdvListMatchOfRound.GridControl = this.grdListMatchOfRound;
            this.grdvListMatchOfRound.Name = "grdvListMatchOfRound";
            this.grdvListMatchOfRound.OptionsView.ShowGroupPanel = false;
            // 
            // grpRoundValue
            // 
            this.grpRoundValue.Controls.Add(this.grdListRoundOfSeason);
            this.grpRoundValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpRoundValue.Location = new System.Drawing.Point(2, 2);
            this.grpRoundValue.Name = "grpRoundValue";
            this.grpRoundValue.Size = new System.Drawing.Size(200, 376);
            this.grpRoundValue.TabIndex = 0;
            this.grpRoundValue.Text = "Vòng đấu";
            // 
            // grdListRoundOfSeason
            // 
            this.grdListRoundOfSeason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListRoundOfSeason.Location = new System.Drawing.Point(2, 21);
            this.grdListRoundOfSeason.MainView = this.grdvListRoundOfSeason;
            this.grdListRoundOfSeason.Name = "grdListRoundOfSeason";
            this.grdListRoundOfSeason.Size = new System.Drawing.Size(196, 353);
            this.grdListRoundOfSeason.TabIndex = 0;
            this.grdListRoundOfSeason.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListRoundOfSeason});
            // 
            // grdvListRoundOfSeason
            // 
            this.grdvListRoundOfSeason.GridControl = this.grdListRoundOfSeason;
            this.grdvListRoundOfSeason.Name = "grdvListRoundOfSeason";
            this.grdvListRoundOfSeason.OptionsView.ShowGroupPanel = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.labSeason);
            this.pnlTop.Controls.Add(this.lkSeason);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(726, 51);
            this.pnlTop.TabIndex = 0;
            // 
            // labSeason
            // 
            this.labSeason.Location = new System.Drawing.Point(19, 22);
            this.labSeason.Name = "labSeason";
            this.labSeason.Size = new System.Drawing.Size(39, 13);
            this.labSeason.TabIndex = 1;
            this.labSeason.Text = "Mùa giải";
            // 
            // lkSeason
            // 
            this.lkSeason.Location = new System.Drawing.Point(85, 19);
            this.lkSeason.Name = "lkSeason";
            this.lkSeason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkSeason.Size = new System.Drawing.Size(165, 20);
            this.lkSeason.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(726, 431);
            this.xtraTabPage2.Text = "xtraTabPage2";
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
            // colStartDate
            // 
            this.colStartDate.Caption = "Ngày thi đấu";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 3;
            // 
            // colScore
            // 
            this.colScore.Caption = "Tỷ số";
            this.colScore.Name = "colScore";
            this.colScore.Visible = true;
            this.colScore.VisibleIndex = 4;
            // 
            // colState
            // 
            this.colState.Caption = "Trạng thái";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 5;
            // 
            // ucMatchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabListMatchOfRound);
            this.Name = "ucMatchResult";
            this.Size = new System.Drawing.Size(732, 459);
            ((System.ComponentModel.ISupportInitialize)(this.tabListMatchOfRound)).EndInit();
            this.tabListMatchOfRound.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMatch)).EndInit();
            this.grpMatch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListMatchOfRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListMatchOfRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpRoundValue)).EndInit();
            this.grpRoundValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoundOfSeason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoundOfSeason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkSeason.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabListMatchOfRound;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PanelControl pnlCenter;
        private DevExpress.XtraEditors.GroupControl grpMatch;
        private DevExpress.XtraGrid.GridControl grdListMatchOfRound;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListMatchOfRound;
        private DevExpress.XtraEditors.GroupControl grpRoundValue;
        private DevExpress.XtraGrid.GridControl grdListRoundOfSeason;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListRoundOfSeason;
        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.LabelControl labSeason;
        private DevExpress.XtraEditors.LookUpEdit lkSeason;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.Columns.GridColumn colMatchID;
        private DevExpress.XtraGrid.Columns.GridColumn colHomeTeam;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitingTeam;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colScore;
        private DevExpress.XtraGrid.Columns.GridColumn colState;

    }
}
