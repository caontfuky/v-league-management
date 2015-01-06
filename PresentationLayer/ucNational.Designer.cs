namespace PresentationLayer
{
    partial class ucNational
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNational));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.nATIONALGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNationalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bnt_InsertUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bnt_Del = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nATIONALGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_InsertUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Del)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.nATIONALGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1140, 677);
            this.panelControl1.TabIndex = 0;
            // 
            // nATIONALGridControl
            // 
            this.nATIONALGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.nATIONALGridControl.DataMember = "NATIONAL";
            this.nATIONALGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nATIONALGridControl.Location = new System.Drawing.Point(2, 2);
            this.nATIONALGridControl.MainView = this.gridView1;
            this.nATIONALGridControl.Name = "nATIONALGridControl";
            this.nATIONALGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.bnt_InsertUpdate,
            this.bnt_Del});
            this.nATIONALGridControl.Size = new System.Drawing.Size(1136, 673);
            this.nATIONALGridControl.TabIndex = 0;
            this.nATIONALGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colNationalID,
            this.colNationName,
            this.colInsertUpdate,
            this.colDel});
            this.gridView1.GridControl = this.nATIONALGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 86;
            // 
            // colNationalID
            // 
            this.colNationalID.Caption = "ID Quốc Gia";
            this.colNationalID.FieldName = "NationalID";
            this.colNationalID.Name = "colNationalID";
            this.colNationalID.OptionsColumn.AllowEdit = false;
            this.colNationalID.Visible = true;
            this.colNationalID.VisibleIndex = 1;
            this.colNationalID.Width = 158;
            // 
            // colNationName
            // 
            this.colNationName.Caption = "Quốc Gia";
            this.colNationName.FieldName = "NationalName";
            this.colNationName.Name = "colNationName";
            this.colNationName.Visible = true;
            this.colNationName.VisibleIndex = 2;
            this.colNationName.Width = 622;
            // 
            // colInsertUpdate
            // 
            this.colInsertUpdate.ColumnEdit = this.bnt_InsertUpdate;
            this.colInsertUpdate.Name = "colInsertUpdate";
            this.colInsertUpdate.Visible = true;
            this.colInsertUpdate.VisibleIndex = 3;
            this.colInsertUpdate.Width = 132;
            // 
            // bnt_InsertUpdate
            // 
            this.bnt_InsertUpdate.AutoHeight = false;
            this.bnt_InsertUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("bnt_InsertUpdate.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.bnt_InsertUpdate.Name = "bnt_InsertUpdate";
            this.bnt_InsertUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.bnt_InsertUpdate.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bnt_InsertUpdate_ButtonClick);
            // 
            // colDel
            // 
            this.colDel.ColumnEdit = this.bnt_Del;
            this.colDel.Name = "colDel";
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 4;
            this.colDel.Width = 120;
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
            // ucNational
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucNational";
            this.Size = new System.Drawing.Size(1140, 677);
            this.Load += new System.EventHandler(this.ucNational_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nATIONALGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_InsertUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Del)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl nATIONALGridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit bnt_InsertUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit bnt_Del;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colNationalID;
        private DevExpress.XtraGrid.Columns.GridColumn colNationName;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
    }
}
