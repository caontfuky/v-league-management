using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataTransferObject;
using BusinnessLogicLayer;

namespace PresentationLayer
{
    public partial class ucPosition : DevExpress.XtraEditors.XtraUserControl
    {
        DTOPosition _dtoPosition = new DTOPosition();
        BUSPosition _busPosition = new BUSPosition();
        DataTable dtPosition;

        public ucPosition()
        {
            InitializeComponent();
            LoadPosition();
        }

        public void LoadPosition()
        {
            dtPosition = _busPosition.getAllData();
            pOSITIONGridControl.DataSource = dtPosition;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (txtPositionID.Text.Equals("") || txtPositionName.Text.Equals(""))
            {
                MessageBox.Show("Chua dien thong tin");
                return;
            }
            else
            {
                _dtoPosition.positionID = txtPositionID.Text.Trim();
                _dtoPosition.positionName = txtPositionName.Text.Trim();

                if (_busPosition.insertData(_dtoPosition) != 0)
                {
                    MessageBox.Show("Them Thanh Cong!");
                    LoadPosition();
                }
                else
                {
                    MessageBox.Show("Co loi xay ra!");

                }
            }
        }

        private void bntDel_Click(object sender, EventArgs e)
        {
            if (txtPositionID.Text.Equals("") || txtPositionName.Text.Equals(""))
            {
                MessageBox.Show("Chua dien thong tin");
                return;
            }
            else
            {
                _dtoPosition.positionID = txtPositionID.Text.Trim();
                _dtoPosition.positionName = txtPositionName.Text.Trim();

                if (_busPosition.deleteData(_dtoPosition.positionID) != 0)
                {
                    MessageBox.Show("Xoa Thanh Cong!");
                    LoadPosition();
                }
                else
                {
                    MessageBox.Show("Co loi xay ra!");

                }

            }
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if (txtPositionID.Text.Equals("") || txtPositionName.Text.Equals(""))
            {
                MessageBox.Show("Chua dien thong tin");
                return;
            }
            else
            {
                _dtoPosition.positionID = txtPositionID.Text.Trim();
                _dtoPosition.positionName = txtPositionName.Text.Trim();

                if (_busPosition.updateData(_dtoPosition) != 0)
                {
                    MessageBox.Show("Sua Thanh Cong!");
                    LoadPosition();
                }
                else
                {
                    MessageBox.Show("Co loi xay ra!");

                }
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtPositionID.Text = gridView1.GetRowCellValue(e.RowHandle, "PositionID").ToString();
            txtPositionName.Text = gridView1.GetRowCellValue(e.RowHandle, "PositionName").ToString();
        }
    }
}
