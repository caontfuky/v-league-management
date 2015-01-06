namespace PresentationLayer
{
    partial class ucPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPosition));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pOSITIONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPositionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPositionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_InsertUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Del = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bnt_InsertUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bnt_Del = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_InsertUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Del)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pOSITIONGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1158, 692);
            this.panelControl1.TabIndex = 2;
            // 
            // pOSITIONGridControl
            // 
            this.pOSITIONGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pOSITIONGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOSITIONGridControl.Location = new System.Drawing.Point(2, 2);
            this.pOSITIONGridControl.MainView = this.gridView1;
            this.pOSITIONGridControl.Name = "pOSITIONGridControl";
            this.pOSITIONGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.bnt_InsertUpdate,
            this.bnt_Del});
            this.pOSITIONGridControl.Size = new System.Drawing.Size(1154, 688);
            this.pOSITIONGridControl.TabIndex = 0;
            this.pOSITIONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.colPositionID,
            this.colPositionName,
            this.col_InsertUpdate,
            this.col_Del});
            this.gridView1.GridControl = this.pOSITIONGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 62;
            // 
            // colPositionID
            // 
            this.colPositionID.Caption = "ID Vị trí";
            this.colPositionID.FieldName = "PositionID";
            this.colPositionID.Name = "colPositionID";
            this.colPositionID.OptionsColumn.AllowEdit = false;
            this.colPositionID.OptionsColumn.AllowFocus = false;
            this.colPositionID.Visible = true;
            this.colPositionID.VisibleIndex = 1;
            this.colPositionID.Width = 204;
            // 
            // colPositionName
            // 
            this.colPositionName.Caption = "Vị Trí";
            this.colPositionName.FieldName = "PositionName";
            this.colPositionName.Name = "colPositionName";
            this.colPositionName.Visible = true;
            this.colPositionName.VisibleIndex = 2;
            this.colPositionName.Width = 610;
            // 
            // col_InsertUpdate
            // 
            this.col_InsertUpdate.ColumnEdit = this.bnt_InsertUpdate;
            this.col_InsertUpdate.Name = "col_InsertUpdate";
            this.col_InsertUpdate.Visible = true;
            this.col_InsertUpdate.VisibleIndex = 3;
            // 
            // col_Del
            // 
            this.col_Del.ColumnEdit = this.bnt_Del;
            this.col_Del.Name = "col_Del";
            this.col_Del.Visible = true;
            this.col_Del.VisibleIndex = 4;
            // 
            // bnt_InsertUpdate
            // 
            this.bnt_InsertUpdate.AutoHeight = false;
            this.bnt_InsertUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("bnt_InsertUpdate.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.bnt_InsertUpdate.Name = "bnt_InsertUpdate";
            this.bnt_InsertUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.bnt_InsertUpdate.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bnt_InsertUpdate_ButtonClick_1);
            // 
            // bnt_Del
            // 
            this.bnt_Del.AutoHeight = false;
            this.bnt_Del.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("bnt_Del.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.bnt_Del.Name = "bnt_Del";
            this.bnt_Del.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.bnt_Del.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bnt_Del_ButtonClick);
            // 
            // ucPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucPosition";
            this.Size = new System.Drawing.Size(1158, 692);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_InsertUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Del)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl pOSITIONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPositionID;
        private DevExpress.XtraGrid.Columns.GridColumn colPositionName;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn col_InsertUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit bnt_InsertUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn col_Del;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit bnt_Del;
    }
}
