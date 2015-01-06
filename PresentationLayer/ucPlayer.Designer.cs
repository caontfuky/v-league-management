namespace PresentationLayer
{
    partial class ucPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPlayer));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.pLAYERGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlayerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPositionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colNationalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colHeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Player_Image = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.colBntInsert_Update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bnt_InsertUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colBntDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bnt_Del = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_InsertUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Del)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.pLAYERGridControl);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1166, 666);
            this.panelControl3.TabIndex = 3;
            // 
            // pLAYERGridControl
            // 
            this.pLAYERGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pLAYERGridControl.DataMember = "PLAYER";
            this.pLAYERGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLAYERGridControl.Location = new System.Drawing.Point(2, 2);
            this.pLAYERGridControl.MainView = this.gridView1;
            this.pLAYERGridControl.Name = "pLAYERGridControl";
            this.pLAYERGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.Player_Image,
            this.bnt_InsertUpdate,
            this.bnt_Del});
            this.pLAYERGridControl.Size = new System.Drawing.Size(1162, 662);
            this.pLAYERGridControl.TabIndex = 1;
            this.pLAYERGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colPlayerID,
            this.colNumber,
            this.colFullName,
            this.colBirthDay,
            this.colPositionName,
            this.colNationalName,
            this.colHeight,
            this.colWeight,
            this.colImage,
            this.colBntInsert_Update,
            this.colBntDel});
            this.gridView1.GridControl = this.pLAYERGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 35;
            // 
            // colPlayerID
            // 
            this.colPlayerID.Caption = "ID Cầu Thủ";
            this.colPlayerID.FieldName = "PlayerID";
            this.colPlayerID.Name = "colPlayerID";
            this.colPlayerID.OptionsColumn.AllowEdit = false;
            this.colPlayerID.OptionsColumn.AllowFocus = false;
            this.colPlayerID.Visible = true;
            this.colPlayerID.VisibleIndex = 1;
            this.colPlayerID.Width = 57;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "Số Áo";
            this.colNumber.FieldName = "NumberOfCloth";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 2;
            this.colNumber.Width = 50;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Tên";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 3;
            this.colFullName.Width = 193;
            // 
            // colBirthDay
            // 
            this.colBirthDay.Caption = "Ngày Sinh";
            this.colBirthDay.FieldName = "BirthDay";
            this.colBirthDay.Name = "colBirthDay";
            this.colBirthDay.Visible = true;
            this.colBirthDay.VisibleIndex = 4;
            this.colBirthDay.Width = 79;
            // 
            // colPositionName
            // 
            this.colPositionName.Caption = "Vị Trí";
            this.colPositionName.ColumnEdit = this.repositoryItemComboBox1;
            this.colPositionName.FieldName = "PositionName";
            this.colPositionName.Name = "colPositionName";
            this.colPositionName.Visible = true;
            this.colPositionName.VisibleIndex = 7;
            this.colPositionName.Width = 149;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colNationalName
            // 
            this.colNationalName.Caption = "Quốc Gia";
            this.colNationalName.ColumnEdit = this.repositoryItemComboBox2;
            this.colNationalName.FieldName = "NationalName";
            this.colNationalName.Name = "colNationalName";
            this.colNationalName.Visible = true;
            this.colNationalName.VisibleIndex = 8;
            this.colNationalName.Width = 147;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // colHeight
            // 
            this.colHeight.Caption = "Chiều Cao(cm)";
            this.colHeight.FieldName = "Height";
            this.colHeight.Name = "colHeight";
            this.colHeight.Visible = true;
            this.colHeight.VisibleIndex = 5;
            this.colHeight.Width = 88;
            // 
            // colWeight
            // 
            this.colWeight.Caption = "Cân Nặng(kg)";
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 6;
            this.colWeight.Width = 83;
            // 
            // colImage
            // 
            this.colImage.Caption = "Ảnh";
            this.colImage.ColumnEdit = this.Player_Image;
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 9;
            this.colImage.Width = 130;
            // 
            // Player_Image
            // 
            this.Player_Image.AutoHeight = false;
            this.Player_Image.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Player_Image.Name = "Player_Image";
            this.Player_Image.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder;
            this.Player_Image.ShowPopupShadow = false;
            this.Player_Image.DoubleClick += new System.EventHandler(this.Player_Image_DoubleClick);
            // 
            // colBntInsert_Update
            // 
            this.colBntInsert_Update.ColumnEdit = this.bnt_InsertUpdate;
            this.colBntInsert_Update.Name = "colBntInsert_Update";
            this.colBntInsert_Update.Visible = true;
            this.colBntInsert_Update.VisibleIndex = 10;
            this.colBntInsert_Update.Width = 71;
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
            // colBntDel
            // 
            this.colBntDel.ColumnEdit = this.bnt_Del;
            this.colBntDel.Name = "colBntDel";
            this.colBntDel.Visible = true;
            this.colBntDel.VisibleIndex = 11;
            this.colBntDel.Width = 59;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Name = "ucPlayer";
            this.Size = new System.Drawing.Size(1166, 666);
            this.Load += new System.EventHandler(this.ucPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_InsertUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Del)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl pLAYERGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPlayerID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colPositionName;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colNationalName;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraGrid.Columns.GridColumn colHeight;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDay;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit Player_Image;
        private DevExpress.XtraGrid.Columns.GridColumn colBntInsert_Update;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit bnt_InsertUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colBntDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit bnt_Del;
    }
}
