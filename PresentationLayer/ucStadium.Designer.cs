namespace PresentationLayer
{
    partial class ucStadium
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
            this.StadiumGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStadiumID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStadiumName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTankage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTankage = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.bntUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.bntDel = new DevExpress.XtraEditors.SimpleButton();
            this.txtStadiumName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bntAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtStadiumID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.StadiumGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTankage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStadiumName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStadiumID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // StadiumGrid
            // 
            this.StadiumGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.StadiumGrid.DataMember = "NATIONAL";
            this.StadiumGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StadiumGrid.Location = new System.Drawing.Point(2, 2);
            this.StadiumGrid.MainView = this.gridView1;
            this.StadiumGrid.Name = "StadiumGrid";
            this.StadiumGrid.Size = new System.Drawing.Size(770, 669);
            this.StadiumGrid.TabIndex = 0;
            this.StadiumGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colStadiumID,
            this.colStadiumName,
            this.colTankage,
            this.colAddress});
            this.gridView1.GridControl = this.StadiumGrid;
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
            // colStadiumID
            // 
            this.colStadiumID.Caption = "ID Sân";
            this.colStadiumID.FieldName = "StadiumID";
            this.colStadiumID.Name = "colStadiumID";
            this.colStadiumID.Visible = true;
            this.colStadiumID.VisibleIndex = 1;
            this.colStadiumID.Width = 56;
            // 
            // colStadiumName
            // 
            this.colStadiumName.Caption = "Tên Sân";
            this.colStadiumName.FieldName = "StadiumName";
            this.colStadiumName.Name = "colStadiumName";
            this.colStadiumName.Visible = true;
            this.colStadiumName.VisibleIndex = 2;
            this.colStadiumName.Width = 177;
            // 
            // colTankage
            // 
            this.colTankage.Caption = "Sức Chứa";
            this.colTankage.FieldName = "Tankage";
            this.colTankage.Name = "colTankage";
            this.colTankage.Visible = true;
            this.colTankage.VisibleIndex = 3;
            this.colTankage.Width = 80;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Địa Chỉ";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            this.colAddress.Width = 381;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.StadiumGrid);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(774, 673);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Location = new System.Drawing.Point(778, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(313, 673);
            this.panelControl2.TabIndex = 3;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTankage);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.bntUpdate);
            this.groupControl1.Controls.Add(this.bntDel);
            this.groupControl1.Controls.Add(this.txtStadiumName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.bntAdd);
            this.groupControl1.Controls.Add(this.txtStadiumID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtAddress);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(309, 669);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "TÁC VỤ";
            // 
            // txtTankage
            // 
            this.txtTankage.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTankage.Location = new System.Drawing.Point(98, 129);
            this.txtTankage.Name = "txtTankage";
            this.txtTankage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTankage.Size = new System.Drawing.Size(100, 20);
            this.txtTankage.TabIndex = 54;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 175);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Địa Chỉ :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Sức Chứa :";
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(98, 406);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(109, 23);
            this.bntUpdate.TabIndex = 6;
            this.bntUpdate.Text = "Sửa TT Sân";
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // bntDel
            // 
            this.bntDel.Location = new System.Drawing.Point(98, 353);
            this.bntDel.Name = "bntDel";
            this.bntDel.Size = new System.Drawing.Size(109, 23);
            this.bntDel.TabIndex = 5;
            this.bntDel.Text = "Xóa TT Sân";
            this.bntDel.Click += new System.EventHandler(this.bntDel_Click);
            // 
            // txtStadiumName
            // 
            this.txtStadiumName.Location = new System.Drawing.Point(98, 89);
            this.txtStadiumName.Name = "txtStadiumName";
            this.txtStadiumName.Size = new System.Drawing.Size(204, 20);
            this.txtStadiumName.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên Sân :";
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(98, 300);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(109, 23);
            this.bntAdd.TabIndex = 2;
            this.bntAdd.Text = "Thêm TT Sân";
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // txtStadiumID
            // 
            this.txtStadiumID.Location = new System.Drawing.Point(98, 46);
            this.txtStadiumID.Name = "txtStadiumID";
            this.txtStadiumID.Size = new System.Drawing.Size(100, 20);
            this.txtStadiumID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID Sân :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(98, 172);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(204, 77);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.UseOptimizedRendering = true;
            // 
            // ucStadium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "ucStadium";
            this.Size = new System.Drawing.Size(1091, 673);
            this.Load += new System.EventHandler(this.ucStadium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StadiumGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTankage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStadiumName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStadiumID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl StadiumGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colStadiumID;
        private DevExpress.XtraGrid.Columns.GridColumn colStadiumName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bntUpdate;
        private DevExpress.XtraEditors.SimpleButton bntDel;
        private DevExpress.XtraEditors.TextEdit txtStadiumName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton bntAdd;
        private DevExpress.XtraEditors.TextEdit txtStadiumID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colTankage;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.SpinEdit txtTankage;
    }
}
