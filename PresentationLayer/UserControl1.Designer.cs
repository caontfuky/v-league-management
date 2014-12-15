namespace PresentationLayer
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            System.Windows.Forms.Label refereeIDLabel;
            System.Windows.Forms.Label refereeNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label seasonIDLabel;
            System.Windows.Forms.Label addressLabel;
            this.sangldDataSet = new PresentationLayer.sangldDataSet();
            this.rEFEREEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEFEREETableAdapter = new PresentationLayer.sangldDataSetTableAdapters.REFEREETableAdapter();
            this.tableAdapterManager = new PresentationLayer.sangldDataSetTableAdapters.TableAdapterManager();
            this.rEFEREEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rEFEREEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sangldDataSet1 = new PresentationLayer.sangldDataSet();
            this.refereeTableAdapter1 = new PresentationLayer.sangldDataSetTableAdapters.REFEREETableAdapter();
            this.rEFEREEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rEFEREEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sangldDataSet2 = new PresentationLayer.sangldDataSet();
            this.refereeTableAdapter2 = new PresentationLayer.sangldDataSetTableAdapters.REFEREETableAdapter();
            this.colRefereeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefereeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeasonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.refereeIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.refereeNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phoneNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.birthDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.seasonIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            refereeIDLabel = new System.Windows.Forms.Label();
            refereeNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            seasonIDLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sangldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFEREEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFEREEBindingNavigator)).BeginInit();
            this.rEFEREEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sangldDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFEREEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFEREEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangldDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refereeIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refereeNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sangldDataSet
            // 
            this.sangldDataSet.DataSetName = "sangldDataSet";
            this.sangldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEFEREEBindingSource
            // 
            this.rEFEREEBindingSource.DataMember = "REFEREE";
            this.rEFEREEBindingSource.DataSource = this.sangldDataSet;
            // 
            // rEFEREETableAdapter
            // 
            this.rEFEREETableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.REFEREETableAdapter = this.rEFEREETableAdapter;
            this.tableAdapterManager.ROUNDTableAdapter = null;
            this.tableAdapterManager.SEASONTableAdapter = null;
            this.tableAdapterManager.STADIUMTableAdapter = null;
            this.tableAdapterManager.STANDINGTableAdapter = null;
            this.tableAdapterManager.SUPPORTTableAdapter = null;
            this.tableAdapterManager.TEAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PresentationLayer.sangldDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rEFEREEBindingNavigator
            // 
            this.rEFEREEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rEFEREEBindingNavigator.BindingSource = this.rEFEREEBindingSource;
            this.rEFEREEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rEFEREEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rEFEREEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rEFEREEBindingNavigatorSaveItem});
            this.rEFEREEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rEFEREEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rEFEREEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rEFEREEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rEFEREEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rEFEREEBindingNavigator.Name = "rEFEREEBindingNavigator";
            this.rEFEREEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rEFEREEBindingNavigator.Size = new System.Drawing.Size(1073, 25);
            this.rEFEREEBindingNavigator.TabIndex = 0;
            this.rEFEREEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rEFEREEBindingNavigatorSaveItem
            // 
            this.rEFEREEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rEFEREEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rEFEREEBindingNavigatorSaveItem.Image")));
            this.rEFEREEBindingNavigatorSaveItem.Name = "rEFEREEBindingNavigatorSaveItem";
            this.rEFEREEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rEFEREEBindingNavigatorSaveItem.Text = "Save Data";
            this.rEFEREEBindingNavigatorSaveItem.Click += new System.EventHandler(this.rEFEREEBindingNavigatorSaveItem_Click_1);
            // 
            // sangldDataSet1
            // 
            this.sangldDataSet1.DataSetName = "sangldDataSet";
            this.sangldDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refereeTableAdapter1
            // 
            this.refereeTableAdapter1.ClearBeforeFill = true;
            // 
            // rEFEREEBindingSource1
            // 
            this.rEFEREEBindingSource1.DataMember = "REFEREE";
            this.rEFEREEBindingSource1.DataSource = this.sangldDataSet1;
            // 
            // rEFEREEGridControl
            // 
            this.rEFEREEGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.rEFEREEGridControl.DataMember = "REFEREE";
            this.rEFEREEGridControl.DataSource = this.sangldDataSet2;
            this.rEFEREEGridControl.Location = new System.Drawing.Point(43, 348);
            this.rEFEREEGridControl.MainView = this.gridView1;
            this.rEFEREEGridControl.Name = "rEFEREEGridControl";
            this.rEFEREEGridControl.Size = new System.Drawing.Size(1010, 220);
            this.rEFEREEGridControl.TabIndex = 1;
            this.rEFEREEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRefereeID,
            this.colRefereeName,
            this.colEmail,
            this.colPhoneNumber,
            this.colBirthDate,
            this.colSeasonID,
            this.colAddress});
            this.gridView1.GridControl = this.rEFEREEGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // sangldDataSet2
            // 
            this.sangldDataSet2.DataSetName = "sangldDataSet";
            this.sangldDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refereeTableAdapter2
            // 
            this.refereeTableAdapter2.ClearBeforeFill = true;
            // 
            // colRefereeID
            // 
            this.colRefereeID.FieldName = "RefereeID";
            this.colRefereeID.Name = "colRefereeID";
            this.colRefereeID.Visible = true;
            this.colRefereeID.VisibleIndex = 0;
            // 
            // colRefereeName
            // 
            this.colRefereeName.FieldName = "RefereeName";
            this.colRefereeName.Name = "colRefereeName";
            this.colRefereeName.Visible = true;
            this.colRefereeName.VisibleIndex = 1;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 3;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 4;
            // 
            // colSeasonID
            // 
            this.colSeasonID.FieldName = "SeasonID";
            this.colSeasonID.Name = "colSeasonID";
            this.colSeasonID.Visible = true;
            this.colSeasonID.VisibleIndex = 5;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 6;
            // 
            // refereeIDLabel
            // 
            refereeIDLabel.AutoSize = true;
            refereeIDLabel.Location = new System.Drawing.Point(379, 120);
            refereeIDLabel.Name = "refereeIDLabel";
            refereeIDLabel.Size = new System.Drawing.Size(62, 13);
            refereeIDLabel.TabIndex = 2;
            refereeIDLabel.Text = "Referee ID:";
            // 
            // refereeIDTextEdit
            // 
            this.refereeIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rEFEREEBindingSource1, "RefereeID", true));
            this.refereeIDTextEdit.Location = new System.Drawing.Point(466, 117);
            this.refereeIDTextEdit.Name = "refereeIDTextEdit";
            this.refereeIDTextEdit.Size = new System.Drawing.Size(100, 20);
            this.refereeIDTextEdit.TabIndex = 3;
            // 
            // refereeNameLabel
            // 
            refereeNameLabel.AutoSize = true;
            refereeNameLabel.Location = new System.Drawing.Point(379, 146);
            refereeNameLabel.Name = "refereeNameLabel";
            refereeNameLabel.Size = new System.Drawing.Size(79, 13);
            refereeNameLabel.TabIndex = 4;
            refereeNameLabel.Text = "Referee Name:";
            // 
            // refereeNameTextEdit
            // 
            this.refereeNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rEFEREEBindingSource1, "RefereeName", true));
            this.refereeNameTextEdit.Location = new System.Drawing.Point(466, 143);
            this.refereeNameTextEdit.Name = "refereeNameTextEdit";
            this.refereeNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.refereeNameTextEdit.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(379, 172);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rEFEREEBindingSource1, "Email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(466, 169);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(100, 20);
            this.emailTextEdit.TabIndex = 7;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(379, 198);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 8;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextEdit
            // 
            this.phoneNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rEFEREEBindingSource1, "PhoneNumber", true));
            this.phoneNumberTextEdit.Location = new System.Drawing.Point(466, 195);
            this.phoneNumberTextEdit.Name = "phoneNumberTextEdit";
            this.phoneNumberTextEdit.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextEdit.TabIndex = 9;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(379, 224);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 10;
            birthDateLabel.Text = "Birth Date:";
            // 
            // birthDateDateEdit
            // 
            this.birthDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rEFEREEBindingSource1, "BirthDate", true));
            this.birthDateDateEdit.EditValue = null;
            this.birthDateDateEdit.Location = new System.Drawing.Point(466, 221);
            this.birthDateDateEdit.Name = "birthDateDateEdit";
            this.birthDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthDateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.birthDateDateEdit.TabIndex = 11;
            // 
            // seasonIDLabel
            // 
            seasonIDLabel.AutoSize = true;
            seasonIDLabel.Location = new System.Drawing.Point(379, 250);
            seasonIDLabel.Name = "seasonIDLabel";
            seasonIDLabel.Size = new System.Drawing.Size(60, 13);
            seasonIDLabel.TabIndex = 12;
            seasonIDLabel.Text = "Season ID:";
            // 
            // seasonIDTextEdit
            // 
            this.seasonIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rEFEREEBindingSource1, "SeasonID", true));
            this.seasonIDTextEdit.Location = new System.Drawing.Point(466, 247);
            this.seasonIDTextEdit.Name = "seasonIDTextEdit";
            this.seasonIDTextEdit.Size = new System.Drawing.Size(100, 20);
            this.seasonIDTextEdit.TabIndex = 13;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(379, 276);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 14;
            addressLabel.Text = "Address:";
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rEFEREEBindingSource1, "Address", true));
            this.addressTextEdit.Location = new System.Drawing.Point(466, 273);
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Size = new System.Drawing.Size(100, 20);
            this.addressTextEdit.TabIndex = 15;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(refereeIDLabel);
            this.Controls.Add(this.refereeIDTextEdit);
            this.Controls.Add(refereeNameLabel);
            this.Controls.Add(this.refereeNameTextEdit);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextEdit);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextEdit);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateEdit);
            this.Controls.Add(seasonIDLabel);
            this.Controls.Add(this.seasonIDTextEdit);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextEdit);
            this.Controls.Add(this.rEFEREEGridControl);
            this.Controls.Add(this.rEFEREEBindingNavigator);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1073, 588);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sangldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFEREEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFEREEBindingNavigator)).EndInit();
            this.rEFEREEBindingNavigator.ResumeLayout(false);
            this.rEFEREEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sangldDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFEREEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFEREEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangldDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refereeIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refereeNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sangldDataSet sangldDataSet;
        private System.Windows.Forms.BindingSource rEFEREEBindingSource;
        private sangldDataSetTableAdapters.REFEREETableAdapter rEFEREETableAdapter;
        private sangldDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rEFEREEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rEFEREEBindingNavigatorSaveItem;
        private sangldDataSet sangldDataSet1;
        private sangldDataSetTableAdapters.REFEREETableAdapter refereeTableAdapter1;
        private System.Windows.Forms.BindingSource rEFEREEBindingSource1;
        private DevExpress.XtraGrid.GridControl rEFEREEGridControl;
        private sangldDataSet sangldDataSet2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRefereeID;
        private DevExpress.XtraGrid.Columns.GridColumn colRefereeName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSeasonID;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private sangldDataSetTableAdapters.REFEREETableAdapter refereeTableAdapter2;
        private DevExpress.XtraEditors.TextEdit refereeIDTextEdit;
        private DevExpress.XtraEditors.TextEdit refereeNameTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.TextEdit phoneNumberTextEdit;
        private DevExpress.XtraEditors.DateEdit birthDateDateEdit;
        private DevExpress.XtraEditors.TextEdit seasonIDTextEdit;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;



    }
}
