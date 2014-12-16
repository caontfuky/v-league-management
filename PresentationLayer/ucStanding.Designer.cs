namespace PresentationLayer
{
    partial class ucStanding
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelSeason = new DevExpress.XtraEditors.LabelControl();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.cbxSeason = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.sTANDINGGridControl = new DevExpress.XtraGrid.GridControl();
            this.sangldDataSet1 = new PresentationLayer.sangldDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeasonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeamID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalMatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalMatchWon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalMatchLost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalMatchDrawn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoalsFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoalsAgainst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoalsDifference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sangldDataSet = new PresentationLayer.sangldDataSet();
            this.sTANDINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTANDINGTableAdapter = new PresentationLayer.sangldDataSetTableAdapters.STANDINGTableAdapter();
            this.tableAdapterManager = new PresentationLayer.sangldDataSetTableAdapters.TableAdapterManager();
            this.standingTableAdapter1 = new PresentationLayer.sangldDataSetTableAdapters.STANDINGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSeason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTANDINGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangldDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTANDINGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelSeason);
            this.panelControl1.Controls.Add(this.labelTitle);
            this.panelControl1.Controls.Add(this.cbxSeason);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1156, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // labelSeason
            // 
            this.labelSeason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeason.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelSeason.Location = new System.Drawing.Point(505, 12);
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
            this.labelTitle.Size = new System.Drawing.Size(165, 17);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "BẢNG XẾP HẠNG MÙA GIẢI ";
            // 
            // cbxSeason
            // 
            this.cbxSeason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSeason.Location = new System.Drawing.Point(1010, 13);
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
            this.label1.Location = new System.Drawing.Point(923, 16);
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
            this.panelControl2.Controls.Add(this.sTANDINGGridControl);
            this.panelControl2.Location = new System.Drawing.Point(3, 52);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1150, 614);
            this.panelControl2.TabIndex = 2;
            // 
            // sTANDINGGridControl
            // 
            this.sTANDINGGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTANDINGGridControl.DataMember = "STANDING";
            this.sTANDINGGridControl.DataSource = this.sangldDataSet1;
            this.sTANDINGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTANDINGGridControl.Location = new System.Drawing.Point(2, 2);
            this.sTANDINGGridControl.MainView = this.gridView1;
            this.sTANDINGGridControl.Name = "sTANDINGGridControl";
            this.sTANDINGGridControl.Size = new System.Drawing.Size(1146, 610);
            this.sTANDINGGridControl.TabIndex = 0;
            this.sTANDINGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sangldDataSet1
            // 
            this.sangldDataSet1.DataSetName = "sangldDataSet";
            this.sangldDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.colSeasonID,
            this.colTeamID,
            this.colTotalMatch,
            this.colTotalMatchWon,
            this.colTotalMatchLost,
            this.colTotalMatchDrawn,
            this.colGoalsFor,
            this.colGoalsAgainst,
            this.colGoalsDifference,
            this.colPoint});
            this.gridView1.GridControl = this.sTANDINGGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 49;
            // 
            // colSeasonID
            // 
            this.colSeasonID.Caption = "Tên Đội Bóng";
            this.colSeasonID.FieldName = "TeamName";
            this.colSeasonID.Name = "colSeasonID";
            this.colSeasonID.Visible = true;
            this.colSeasonID.VisibleIndex = 2;
            this.colSeasonID.Width = 152;
            // 
            // colTeamID
            // 
            this.colTeamID.Caption = "ID Đội Bóng";
            this.colTeamID.FieldName = "TeamID";
            this.colTeamID.Name = "colTeamID";
            this.colTeamID.Visible = true;
            this.colTeamID.VisibleIndex = 1;
            this.colTeamID.Width = 77;
            // 
            // colTotalMatch
            // 
            this.colTotalMatch.Caption = "Tổng Số Trận Đấu";
            this.colTotalMatch.FieldName = "TotalMatch";
            this.colTotalMatch.Name = "colTotalMatch";
            this.colTotalMatch.Visible = true;
            this.colTotalMatch.VisibleIndex = 3;
            this.colTotalMatch.Width = 116;
            // 
            // colTotalMatchWon
            // 
            this.colTotalMatchWon.Caption = "Tổng Số Trận Thắng";
            this.colTotalMatchWon.FieldName = "TotalMatchWon";
            this.colTotalMatchWon.Name = "colTotalMatchWon";
            this.colTotalMatchWon.Visible = true;
            this.colTotalMatchWon.VisibleIndex = 4;
            this.colTotalMatchWon.Width = 111;
            // 
            // colTotalMatchLost
            // 
            this.colTotalMatchLost.Caption = "Tổng Số Trận Thua";
            this.colTotalMatchLost.FieldName = "TotalMatchLost";
            this.colTotalMatchLost.Name = "colTotalMatchLost";
            this.colTotalMatchLost.Visible = true;
            this.colTotalMatchLost.VisibleIndex = 5;
            this.colTotalMatchLost.Width = 125;
            // 
            // colTotalMatchDrawn
            // 
            this.colTotalMatchDrawn.Caption = "Tổng Số Trận Hòa";
            this.colTotalMatchDrawn.FieldName = "TotalMatchDrawn";
            this.colTotalMatchDrawn.Name = "colTotalMatchDrawn";
            this.colTotalMatchDrawn.Visible = true;
            this.colTotalMatchDrawn.VisibleIndex = 6;
            this.colTotalMatchDrawn.Width = 120;
            // 
            // colGoalsFor
            // 
            this.colGoalsFor.Caption = "Bàn Thắng";
            this.colGoalsFor.FieldName = "GoalsFor";
            this.colGoalsFor.Name = "colGoalsFor";
            this.colGoalsFor.Visible = true;
            this.colGoalsFor.VisibleIndex = 7;
            this.colGoalsFor.Width = 107;
            // 
            // colGoalsAgainst
            // 
            this.colGoalsAgainst.Caption = "Bàn Thua";
            this.colGoalsAgainst.FieldName = "GoalsAgainst";
            this.colGoalsAgainst.Name = "colGoalsAgainst";
            this.colGoalsAgainst.Visible = true;
            this.colGoalsAgainst.VisibleIndex = 8;
            this.colGoalsAgainst.Width = 99;
            // 
            // colGoalsDifference
            // 
            this.colGoalsDifference.Caption = "Hiệu Số";
            this.colGoalsDifference.FieldName = "GoalsDifference";
            this.colGoalsDifference.Name = "colGoalsDifference";
            this.colGoalsDifference.Visible = true;
            this.colGoalsDifference.VisibleIndex = 9;
            this.colGoalsDifference.Width = 87;
            // 
            // colPoint
            // 
            this.colPoint.Caption = "Điểm";
            this.colPoint.FieldName = "Point";
            this.colPoint.Name = "colPoint";
            this.colPoint.Visible = true;
            this.colPoint.VisibleIndex = 10;
            this.colPoint.Width = 85;
            // 
            // sangldDataSet
            // 
            this.sangldDataSet.DataSetName = "sangldDataSet";
            this.sangldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTANDINGBindingSource
            // 
            this.sTANDINGBindingSource.DataMember = "STANDING";
            this.sTANDINGBindingSource.DataSource = this.sangldDataSet;
            // 
            // sTANDINGTableAdapter
            // 
            this.sTANDINGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CARD_TYPETableAdapter = null;
            this.tableAdapterManager.CARDTableAdapter = null;
            this.tableAdapterManager.COACH_TEAM_SEASONTableAdapter = null;
            this.tableAdapterManager.COACHTableAdapter = null;
            this.tableAdapterManager.GOALTableAdapter = null;
            this.tableAdapterManager.MATCHTableAdapter = null;
            this.tableAdapterManager.NATIONALTableAdapter = null;
            this.tableAdapterManager.PLAYER_TEAM_SEASONTableAdapter = null;
            this.tableAdapterManager.PLAYERTableAdapter = null;
            this.tableAdapterManager.POSITIONTableAdapter = null;
            this.tableAdapterManager.REFEREETableAdapter = null;
            this.tableAdapterManager.ROUNDTableAdapter = null;
            this.tableAdapterManager.SEASONTableAdapter = null;
            this.tableAdapterManager.STADIUMTableAdapter = null;
            this.tableAdapterManager.STANDINGTableAdapter = this.sTANDINGTableAdapter;
            this.tableAdapterManager.SUPPORTTableAdapter = null;
            this.tableAdapterManager.TEAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PresentationLayer.sangldDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // standingTableAdapter1
            // 
            this.standingTableAdapter1.ClearBeforeFill = true;
            // 
            // ucStanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucStanding";
            this.Size = new System.Drawing.Size(1156, 669);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSeason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sTANDINGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangldDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTANDINGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelSeason;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraEditors.ComboBoxEdit cbxSeason;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private sangldDataSet sangldDataSet;
        private System.Windows.Forms.BindingSource sTANDINGBindingSource;
        private sangldDataSetTableAdapters.STANDINGTableAdapter sTANDINGTableAdapter;
        private sangldDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sTANDINGGridControl;
        private sangldDataSet sangldDataSet1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSeasonID;
        private DevExpress.XtraGrid.Columns.GridColumn colTeamID;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalMatch;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalMatchWon;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalMatchLost;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalMatchDrawn;
        private DevExpress.XtraGrid.Columns.GridColumn colGoalsFor;
        private DevExpress.XtraGrid.Columns.GridColumn colGoalsAgainst;
        private DevExpress.XtraGrid.Columns.GridColumn colGoalsDifference;
        private DevExpress.XtraGrid.Columns.GridColumn colPoint;
        private sangldDataSetTableAdapters.STANDINGTableAdapter standingTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;

    }
}
