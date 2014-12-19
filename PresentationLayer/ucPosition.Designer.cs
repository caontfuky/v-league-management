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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pOSITIONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPositionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPositionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bntUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.bntDel = new DevExpress.XtraEditors.SimpleButton();
            this.txtPositionName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bntAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtPositionID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPositionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPositionID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.pOSITIONGridControl);
            this.panelControl1.Location = new System.Drawing.Point(4, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(618, 683);
            this.panelControl1.TabIndex = 2;
            // 
            // pOSITIONGridControl
            // 
            this.pOSITIONGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pOSITIONGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOSITIONGridControl.Location = new System.Drawing.Point(2, 2);
            this.pOSITIONGridControl.MainView = this.gridView1;
            this.pOSITIONGridControl.Name = "pOSITIONGridControl";
            this.pOSITIONGridControl.Size = new System.Drawing.Size(614, 679);
            this.pOSITIONGridControl.TabIndex = 0;
            this.pOSITIONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.colPositionID,
            this.colPositionName});
            this.gridView1.GridControl = this.pOSITIONGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 41;
            // 
            // colPositionID
            // 
            this.colPositionID.Caption = "ID Vị trí";
            this.colPositionID.FieldName = "PositionID";
            this.colPositionID.Name = "colPositionID";
            this.colPositionID.Visible = true;
            this.colPositionID.VisibleIndex = 1;
            this.colPositionID.Width = 276;
            // 
            // colPositionName
            // 
            this.colPositionName.Caption = "Vị Trí";
            this.colPositionName.FieldName = "PositionName";
            this.colPositionName.Name = "colPositionName";
            this.colPositionName.Visible = true;
            this.colPositionName.VisibleIndex = 2;
            this.colPositionName.Width = 279;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Location = new System.Drawing.Point(628, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(252, 683);
            this.panelControl2.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bntUpdate);
            this.groupControl1.Controls.Add(this.bntDel);
            this.groupControl1.Controls.Add(this.txtPositionName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.bntAdd);
            this.groupControl1.Controls.Add(this.txtPositionID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(248, 679);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "TÁC VỤ";
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(69, 262);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(109, 23);
            this.bntUpdate.TabIndex = 6;
            this.bntUpdate.Text = "Sửa TT Vị Trí";
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // bntDel
            // 
            this.bntDel.Location = new System.Drawing.Point(69, 205);
            this.bntDel.Name = "bntDel";
            this.bntDel.Size = new System.Drawing.Size(109, 23);
            this.bntDel.TabIndex = 5;
            this.bntDel.Text = "Xóa TT Vị Trí";
            this.bntDel.Click += new System.EventHandler(this.bntDel_Click);
            // 
            // txtPositionName
            // 
            this.txtPositionName.Location = new System.Drawing.Point(98, 89);
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.Size = new System.Drawing.Size(145, 20);
            this.txtPositionName.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Vị trí :";
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(69, 151);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(109, 23);
            this.bntAdd.TabIndex = 2;
            this.bntAdd.Text = "Thêm TT Vị Trí";
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // txtPositionID
            // 
            this.txtPositionID.Location = new System.Drawing.Point(98, 46);
            this.txtPositionID.Name = "txtPositionID";
            this.txtPositionID.Size = new System.Drawing.Size(100, 20);
            this.txtPositionID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID Vị trí :";
            // 
            // ucPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "ucPosition";
            this.Size = new System.Drawing.Size(884, 692);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPositionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPositionID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bntUpdate;
        private DevExpress.XtraEditors.SimpleButton bntDel;
        private DevExpress.XtraEditors.TextEdit txtPositionName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton bntAdd;
        private DevExpress.XtraEditors.TextEdit txtPositionID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl pOSITIONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPositionID;
        private DevExpress.XtraGrid.Columns.GridColumn colPositionName;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
    }
}
