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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bntUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.bntDel = new DevExpress.XtraEditors.SimpleButton();
            this.txtNationalName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bntAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtNationalID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colInsertUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bnt_InsertUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bnt_Del = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nATIONALGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_InsertUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Del)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.nATIONALGridControl);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1140, 530);
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
            this.nATIONALGridControl.Size = new System.Drawing.Size(1136, 526);
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
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 58;
            // 
            // colNationalID
            // 
            this.colNationalID.Caption = "ID Quốc Gia";
            this.colNationalID.FieldName = "NationalID";
            this.colNationalID.Name = "colNationalID";
            this.colNationalID.Visible = true;
            this.colNationalID.VisibleIndex = 1;
            this.colNationalID.Width = 106;
            // 
            // colNationName
            // 
            this.colNationName.Caption = "Quốc Gia";
            this.colNationName.FieldName = "NationalName";
            this.colNationName.Name = "colNationName";
            this.colNationName.Visible = true;
            this.colNationName.VisibleIndex = 2;
            this.colNationName.Width = 432;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Location = new System.Drawing.Point(396, 545);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(252, 120);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bntUpdate);
            this.groupControl1.Controls.Add(this.bntDel);
            this.groupControl1.Controls.Add(this.txtNationalName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.bntAdd);
            this.groupControl1.Controls.Add(this.txtNationalID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(4, 34);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(214, 77);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "TÁC VỤ";
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(69, 262);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(109, 23);
            this.bntUpdate.TabIndex = 6;
            this.bntUpdate.Text = "Sửa TT Quốc Gia";
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // bntDel
            // 
            this.bntDel.Location = new System.Drawing.Point(69, 204);
            this.bntDel.Name = "bntDel";
            this.bntDel.Size = new System.Drawing.Size(109, 23);
            this.bntDel.TabIndex = 5;
            this.bntDel.Text = "Xóa TT Quốc Gia";
            this.bntDel.Click += new System.EventHandler(this.bntDel_Click);
            // 
            // txtNationalName
            // 
            this.txtNationalName.Location = new System.Drawing.Point(98, 89);
            this.txtNationalName.Name = "txtNationalName";
            this.txtNationalName.Size = new System.Drawing.Size(145, 20);
            this.txtNationalName.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên Quốc Gia:";
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(69, 151);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(109, 23);
            this.bntAdd.TabIndex = 2;
            this.bntAdd.Text = "Thêm TT Quốc Gia";
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // txtNationalID
            // 
            this.txtNationalID.Location = new System.Drawing.Point(98, 46);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(100, 20);
            this.txtNationalID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID Quốc Gia :";
            // 
            // colInsertUpdate
            // 
            this.colInsertUpdate.ColumnEdit = this.bnt_InsertUpdate;
            this.colInsertUpdate.Name = "colInsertUpdate";
            this.colInsertUpdate.Visible = true;
            this.colInsertUpdate.VisibleIndex = 3;
            // 
            // colDel
            // 
            this.colDel.ColumnEdit = this.bnt_Del;
            this.colDel.Name = "colDel";
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 4;
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
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucNational";
            this.Size = new System.Drawing.Size(1140, 677);
            this.Load += new System.EventHandler(this.ucNational_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nATIONALGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_InsertUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Del)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl nATIONALGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bntUpdate;
        private DevExpress.XtraEditors.SimpleButton bntDel;
        private DevExpress.XtraEditors.TextEdit txtNationalName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton bntAdd;
        private DevExpress.XtraEditors.TextEdit txtNationalID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colNationalID;
        private DevExpress.XtraGrid.Columns.GridColumn colNationName;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit bnt_InsertUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit bnt_Del;
    }
}
