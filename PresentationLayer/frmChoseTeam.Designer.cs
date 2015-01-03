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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbtnChoseTeam = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpListTeam)).BeginInit();
            this.grpListTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListTeamInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.grpListTeam.Size = new System.Drawing.Size(456, 313);
            this.grpListTeam.TabIndex = 0;
            this.grpListTeam.Text = "Danh sách các đội bóng";
            // 
            // grdListTeamInfo
            // 
            this.grdListTeamInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdListTeamInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListTeamInfo.Location = new System.Drawing.Point(2, 21);
            this.grdListTeamInfo.MainView = this.gridView1;
            this.grdListTeamInfo.Name = "grdListTeamInfo";
            this.grdListTeamInfo.Size = new System.Drawing.Size(452, 243);
            this.grdListTeamInfo.TabIndex = 0;
            this.grdListTeamInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.grdListTeamInfo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
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
            // 
            // bbtnCancel
            // 
            this.bbtnCancel.Caption = "Hủy thao tác";
            this.bbtnCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnCancel.Glyph")));
            this.bbtnCancel.Id = 1;
            this.bbtnCancel.Name = "bbtnCancel";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(2, 21);
            this.barDockControlTop.Size = new System.Drawing.Size(452, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(2, 264);
            this.barDockControlBottom.Size = new System.Drawing.Size(452, 47);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(2, 21);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 243);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(454, 21);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 243);
            // 
            // frmChoseTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 313);
            this.Controls.Add(this.grpListTeam);
            this.Name = "frmChoseTeam";
            this.Text = "Chọn đội bóng";
            ((System.ComponentModel.ISupportInitialize)(this.grpListTeam)).EndInit();
            this.grpListTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListTeamInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpListTeam;
        private DevExpress.XtraGrid.GridControl grdListTeamInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
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