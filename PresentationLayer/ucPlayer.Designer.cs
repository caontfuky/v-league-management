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
            System.Windows.Forms.Label playerIDLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label birthDayLabel;
            System.Windows.Forms.Label positionIDLabel;
            System.Windows.Forms.Label nationalIDLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label label2;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.pLAYERGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlayerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPositionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colNationalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colHeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNumber = new DevExpress.XtraEditors.SpinEdit();
            this.bntUpdatePlayerInfo = new DevExpress.XtraEditors.SimpleButton();
            this.bntDelPlayer = new DevExpress.XtraEditors.SimpleButton();
            this.bntAddPlayerInfo = new DevExpress.XtraEditors.SimpleButton();
            this.picturePlayer = new DevExpress.XtraEditors.PictureEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayerID = new DevExpress.XtraEditors.TextEdit();
            this.txtPlayerName = new DevExpress.XtraEditors.TextEdit();
            this.txtPlayerBirthdate = new DevExpress.XtraEditors.DateEdit();
            this.txtPlayerHeight = new DevExpress.XtraEditors.SpinEdit();
            this.txtPlayerWeight = new DevExpress.XtraEditors.SpinEdit();
            this.cbxPlayerLocate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxPlayerNational = new DevExpress.XtraEditors.ComboBoxEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            playerIDLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            birthDayLabel = new System.Windows.Forms.Label();
            positionIDLabel = new System.Windows.Forms.Label();
            nationalIDLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerBirthdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerBirthdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPlayerLocate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPlayerNational.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // playerIDLabel
            // 
            playerIDLabel.AutoSize = true;
            playerIDLabel.Location = new System.Drawing.Point(5, 40);
            playerIDLabel.Name = "playerIDLabel";
            playerIDLabel.Size = new System.Drawing.Size(65, 13);
            playerIDLabel.TabIndex = 40;
            playerIDLabel.Text = "ID Cầu Thủ:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(5, 71);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(29, 13);
            fullNameLabel.TabIndex = 42;
            fullNameLabel.Text = "Tên:";
            // 
            // birthDayLabel
            // 
            birthDayLabel.AutoSize = true;
            birthDayLabel.Location = new System.Drawing.Point(5, 109);
            birthDayLabel.Name = "birthDayLabel";
            birthDayLabel.Size = new System.Drawing.Size(55, 13);
            birthDayLabel.TabIndex = 44;
            birthDayLabel.Text = "Năm Sinh:";
            // 
            // positionIDLabel
            // 
            positionIDLabel.AutoSize = true;
            positionIDLabel.Location = new System.Drawing.Point(5, 148);
            positionIDLabel.Name = "positionIDLabel";
            positionIDLabel.Size = new System.Drawing.Size(34, 13);
            positionIDLabel.TabIndex = 46;
            positionIDLabel.Text = "Vị Trí:";
            // 
            // nationalIDLabel
            // 
            nationalIDLabel.AutoSize = true;
            nationalIDLabel.Location = new System.Drawing.Point(5, 184);
            nationalIDLabel.Name = "nationalIDLabel";
            nationalIDLabel.Size = new System.Drawing.Size(54, 13);
            nationalIDLabel.TabIndex = 47;
            nationalIDLabel.Text = "Quốc Gia:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(5, 252);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(60, 13);
            heightLabel.TabIndex = 50;
            heightLabel.Text = "Chiều Cao:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(5, 219);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(58, 13);
            weightLabel.TabIndex = 52;
            weightLabel.Text = "Cân Nặng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(5, 287);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 13);
            label2.TabIndex = 61;
            label2.Text = "Số Áo:";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.labelTitle);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1166, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(5, 52);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(200, 100);
            this.panelControl2.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelTitle.Location = new System.Drawing.Point(334, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(168, 17);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "DANH SÁCH CÁC CẦU THỦ ";
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.pLAYERGridControl);
            this.panelControl3.Location = new System.Drawing.Point(3, 47);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(804, 616);
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
            this.repositoryItemComboBox2});
            this.pLAYERGridControl.Size = new System.Drawing.Size(800, 612);
            this.pLAYERGridControl.TabIndex = 1;
            this.pLAYERGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.pLAYERGridControl.Click += new System.EventHandler(this.pLAYERGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colPlayerID,
            this.colNumber,
            this.colFullName,
            this.colPositionID,
            this.colNationalID,
            this.colHeight,
            this.colWeight,
            this.colImage});
            this.gridView1.GridControl = this.pLAYERGridControl;
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
            this.colSTT.Width = 35;
            // 
            // colPlayerID
            // 
            this.colPlayerID.Caption = "ID Cầu Thủ";
            this.colPlayerID.FieldName = "PlayerID";
            this.colPlayerID.Name = "colPlayerID";
            this.colPlayerID.Visible = true;
            this.colPlayerID.VisibleIndex = 1;
            this.colPlayerID.Width = 82;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "Số Áo";
            this.colNumber.FieldName = "NumberOfCloth";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 2;
            this.colNumber.Width = 49;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Tên";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 3;
            this.colFullName.Width = 182;
            // 
            // colPositionID
            // 
            this.colPositionID.Caption = "Vị Trí";
            this.colPositionID.ColumnEdit = this.repositoryItemComboBox1;
            this.colPositionID.FieldName = "PositionName";
            this.colPositionID.Name = "colPositionID";
            this.colPositionID.Visible = true;
            this.colPositionID.VisibleIndex = 6;
            this.colPositionID.Width = 141;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colNationalID
            // 
            this.colNationalID.Caption = "Quốc Gia";
            this.colNationalID.ColumnEdit = this.repositoryItemComboBox2;
            this.colNationalID.FieldName = "NationalName";
            this.colNationalID.Name = "colNationalID";
            this.colNationalID.Visible = true;
            this.colNationalID.VisibleIndex = 7;
            this.colNationalID.Width = 130;
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
            this.colHeight.VisibleIndex = 4;
            this.colHeight.Width = 84;
            // 
            // colWeight
            // 
            this.colWeight.Caption = "Cân Nặng(kg)";
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 5;
            this.colWeight.Width = 79;
            // 
            // colImage
            // 
            this.colImage.Caption = "Image";
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl4.Controls.Add(this.groupControl1);
            this.panelControl4.Location = new System.Drawing.Point(811, 47);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(355, 616);
            this.panelControl4.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(label2);
            this.groupControl1.Controls.Add(this.txtNumber);
            this.groupControl1.Controls.Add(this.bntUpdatePlayerInfo);
            this.groupControl1.Controls.Add(this.bntDelPlayer);
            this.groupControl1.Controls.Add(this.bntAddPlayerInfo);
            this.groupControl1.Controls.Add(this.picturePlayer);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(playerIDLabel);
            this.groupControl1.Controls.Add(this.txtPlayerID);
            this.groupControl1.Controls.Add(fullNameLabel);
            this.groupControl1.Controls.Add(this.txtPlayerName);
            this.groupControl1.Controls.Add(birthDayLabel);
            this.groupControl1.Controls.Add(this.txtPlayerBirthdate);
            this.groupControl1.Controls.Add(positionIDLabel);
            this.groupControl1.Controls.Add(nationalIDLabel);
            this.groupControl1.Controls.Add(heightLabel);
            this.groupControl1.Controls.Add(this.txtPlayerHeight);
            this.groupControl1.Controls.Add(weightLabel);
            this.groupControl1.Controls.Add(this.txtPlayerWeight);
            this.groupControl1.Controls.Add(this.cbxPlayerLocate);
            this.groupControl1.Controls.Add(this.cbxPlayerNational);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(351, 612);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "TÁC VỤ";
            // 
            // txtNumber
            // 
            this.txtNumber.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNumber.Location = new System.Drawing.Point(76, 284);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 62;
            // 
            // bntUpdatePlayerInfo
            // 
            this.bntUpdatePlayerInfo.Location = new System.Drawing.Point(123, 492);
            this.bntUpdatePlayerInfo.Name = "bntUpdatePlayerInfo";
            this.bntUpdatePlayerInfo.Size = new System.Drawing.Size(108, 40);
            this.bntUpdatePlayerInfo.TabIndex = 60;
            this.bntUpdatePlayerInfo.Text = "Sửa TT Cầu Thủ";
            this.bntUpdatePlayerInfo.Click += new System.EventHandler(this.bntUpdatePlayerInfo_Click);
            // 
            // bntDelPlayer
            // 
            this.bntDelPlayer.Location = new System.Drawing.Point(123, 409);
            this.bntDelPlayer.Name = "bntDelPlayer";
            this.bntDelPlayer.Size = new System.Drawing.Size(108, 39);
            this.bntDelPlayer.TabIndex = 59;
            this.bntDelPlayer.Text = "Xóa Cầu Thủ";
            this.bntDelPlayer.Click += new System.EventHandler(this.bntDelPlayer_Click);
            // 
            // bntAddPlayerInfo
            // 
            this.bntAddPlayerInfo.Location = new System.Drawing.Point(123, 328);
            this.bntAddPlayerInfo.Name = "bntAddPlayerInfo";
            this.bntAddPlayerInfo.Size = new System.Drawing.Size(108, 41);
            this.bntAddPlayerInfo.TabIndex = 58;
            this.bntAddPlayerInfo.Text = "Thêm TT Cầu Thủ";
            this.bntAddPlayerInfo.Click += new System.EventHandler(this.bntAddPlayerInfo_Click);
            // 
            // picturePlayer
            // 
            this.picturePlayer.Location = new System.Drawing.Point(234, 105);
            this.picturePlayer.Name = "picturePlayer";
            this.picturePlayer.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picturePlayer.Size = new System.Drawing.Size(100, 96);
            this.picturePlayer.TabIndex = 57;
            this.picturePlayer.Click += new System.EventHandler(this.picturePlayer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Ảnh :";
            // 
            // txtPlayerID
            // 
            this.txtPlayerID.Location = new System.Drawing.Point(76, 37);
            this.txtPlayerID.Name = "txtPlayerID";
            this.txtPlayerID.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerID.TabIndex = 41;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(76, 68);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(258, 20);
            this.txtPlayerName.TabIndex = 43;
            // 
            // txtPlayerBirthdate
            // 
            this.txtPlayerBirthdate.EditValue = null;
            this.txtPlayerBirthdate.Location = new System.Drawing.Point(76, 106);
            this.txtPlayerBirthdate.Name = "txtPlayerBirthdate";
            this.txtPlayerBirthdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPlayerBirthdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPlayerBirthdate.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerBirthdate.TabIndex = 45;
            // 
            // txtPlayerHeight
            // 
            this.txtPlayerHeight.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPlayerHeight.Location = new System.Drawing.Point(76, 249);
            this.txtPlayerHeight.Name = "txtPlayerHeight";
            this.txtPlayerHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPlayerHeight.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerHeight.TabIndex = 51;
            // 
            // txtPlayerWeight
            // 
            this.txtPlayerWeight.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPlayerWeight.Location = new System.Drawing.Point(76, 216);
            this.txtPlayerWeight.Name = "txtPlayerWeight";
            this.txtPlayerWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPlayerWeight.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerWeight.TabIndex = 53;
            // 
            // cbxPlayerLocate
            // 
            this.cbxPlayerLocate.Location = new System.Drawing.Point(76, 141);
            this.cbxPlayerLocate.Name = "cbxPlayerLocate";
            this.cbxPlayerLocate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxPlayerLocate.Size = new System.Drawing.Size(100, 20);
            this.cbxPlayerLocate.TabIndex = 54;
            // 
            // cbxPlayerNational
            // 
            this.cbxPlayerNational.Location = new System.Drawing.Point(76, 181);
            this.cbxPlayerNational.Name = "cbxPlayerNational";
            this.cbxPlayerNational.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxPlayerNational.Size = new System.Drawing.Size(100, 20);
            this.cbxPlayerNational.TabIndex = 55;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucPlayer";
            this.Size = new System.Drawing.Size(1166, 666);
            this.Load += new System.EventHandler(this.ucPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerBirthdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerBirthdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlayerWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPlayerLocate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPlayerNational.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl pLAYERGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPlayerID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colPositionID;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colNationalID;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraGrid.Columns.GridColumn colHeight;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraEditors.PictureEdit picturePlayer;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtPlayerID;
        private DevExpress.XtraEditors.TextEdit txtPlayerName;
        private DevExpress.XtraEditors.DateEdit txtPlayerBirthdate;
        private DevExpress.XtraEditors.SpinEdit txtPlayerHeight;
        private DevExpress.XtraEditors.SpinEdit txtPlayerWeight;
        private DevExpress.XtraEditors.ComboBoxEdit cbxPlayerLocate;
        private DevExpress.XtraEditors.ComboBoxEdit cbxPlayerNational;
        private DevExpress.XtraEditors.SimpleButton bntUpdatePlayerInfo;
        private DevExpress.XtraEditors.SimpleButton bntDelPlayer;
        private DevExpress.XtraEditors.SimpleButton bntAddPlayerInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraEditors.SpinEdit txtNumber;
    }
}
