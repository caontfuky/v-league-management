namespace PresentationLayer
{
    partial class frmChoseTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoseTeam));
            this.grpListTeam = new DevExpress.XtraEditors.GroupControl();
            this.grdListTeamInfo = new DevExpress.XtraGrid.GridControl();
            this.grdvListTeamInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTeamID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeamName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountPlayer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbtnChoseTeam = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnCancel = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.grpListTeam)).BeginInit();
            this.grpListTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListTeamInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListTeamInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListTeam
            // 
            this.grpListTeam.Controls.Add(this.grdListTeamInfo);
            this.grpListTeam.Controls.Add(this.barDockControlLeft);
            this.grpListTeam.Controls.Add(this.barDockControlRight);
            this.grpListTeam.Controls.Add(this.barDockControlBottom);
            this.grpListTeam.Controls.Add(this.barDockControlTop);
            this.grpListTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListTeam.Location = new System.Drawing.Point(0, 0);
            this.grpListTeam.Name = "grpListTeam";
            this.grpListTeam.Size = new System.Drawing.Size(628, 413);
            this.grpListTeam.TabIndex = 0;
            this.grpListTeam.Text = "Danh sách các đội bóng";
            // 
            // grdListTeamInfo
            // 
            this.grdListTeamInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdListTeamInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListTeamInfo.Location = new System.Drawing.Point(2, 21);
            this.grdListTeamInfo.MainView = this.grdvListTeamInfo;
            this.grdListTeamInfo.Name = "grdListTeamInfo";
            this.grdListTeamInfo.Size = new System.Drawing.Size(624, 343);
            this.grdListTeamInfo.TabIndex = 0;
            this.grdListTeamInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListTeamInfo});
            // 
            // grdvListTeamInfo
            // 
            this.grdvListTeamInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTeamID,
            this.colTeamName,
            this.colCountPlayer});
            this.grdvListTeamInfo.GridControl = this.grdListTeamInfo;
            this.grdvListTeamInfo.Name = "grdvListTeamInfo";
            this.grdvListTeamInfo.OptionsSelection.MultiSelect = true;
            this.grdvListTeamInfo.OptionsView.ShowGroupPanel = false;
            // 
            // colTeamID
            // 
            this.colTeamID.Caption = "Mã đội";
            this.colTeamID.FieldName = "TeamID";
            this.colTeamID.Name = "colTeamID";
            this.colTeamID.Visible = true;
            this.colTeamID.VisibleIndex = 0;
            // 
            // colTeamName
            // 
            this.colTeamName.Caption = "Tên đội";
            this.colTeamName.FieldName = "Name";
            this.colTeamName.Name = "colTeamName";
            this.colTeamName.Visible = true;
            this.colTeamName.VisibleIndex = 1;
            // 
            // colCountPlayer
            // 
            this.colCountPlayer.Caption = "Số lượng cầu thủ";
            this.colCountPlayer.FieldName = "CountOfPlayer";
            this.colCountPlayer.Name = "colCountPlayer";
            this.colCountPlayer.Visible = true;
            this.colCountPlayer.VisibleIndex = 2;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(2, 21);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 343);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(626, 21);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 343);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(2, 364);
            this.barDockControlBottom.Size = new System.Drawing.Size(624, 47);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(2, 21);
            this.barDockControlTop.Size = new System.Drawing.Size(624, 0);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this.grpListTeam;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtnChoseTeam,
            this.bbtnCancel});
            this.barManager.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnChoseTeam),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnCancel)});
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // bbtnChoseTeam
            // 
            this.bbtnChoseTeam.Caption = "Chọn";
            this.bbtnChoseTeam.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnChoseTeam.Glyph")));
            this.bbtnChoseTeam.Id = 0;
            this.bbtnChoseTeam.Name = "bbtnChoseTeam";
            this.bbtnChoseTeam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnChoseTeam_ItemClick);
            // 
            // bbtnCancel
            // 
            this.bbtnCancel.Caption = "Hủy thao tác";
            this.bbtnCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnCancel.Glyph")));
            this.bbtnCancel.Id = 1;
            this.bbtnCancel.Name = "bbtnCancel";
            this.bbtnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnCancel_ItemClick);
            // 
            // frmChoseTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 413);
            this.Controls.Add(this.grpListTeam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChoseTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn đội bóng";
            ((System.ComponentModel.ISupportInitialize)(this.grpListTeam)).EndInit();
            this.grpListTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListTeamInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListTeamInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpListTeam;
        private DevExpress.XtraGrid.GridControl grdListTeamInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListTeamInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colTeamID;
        private DevExpress.XtraGrid.Columns.GridColumn colTeamName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountPlayer;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbtnChoseTeam;
        private DevExpress.XtraBars.BarButtonItem bbtnCancel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;

    }
}