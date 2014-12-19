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
    public partial class ucNational : DevExpress.XtraEditors.XtraUserControl
    {

        DTONational _dtoNational = new DTONational();
        BUSNational _busNational = new BUSNational();
        DataTable dtNational;

        public ucNational()
        {
            InitializeComponent();
            LoadNational();
        }

        public void LoadNational()
        {
            dtNational = _busNational.getAllData();
            nATIONALGridControl.DataSource = dtNational;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtNationalID.Text = gridView1.GetRowCellValue(e.RowHandle, "NationalID").ToString();
            txtNationalName.Text = gridView1.GetRowCellValue(e.RowHandle, "NationalName").ToString();

        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (txtNationalID.Text.Equals("") || txtNationalName.Text.Equals(""))
            {
                MessageBox.Show("Chua dien thong tin");
                return;
            }
            else
            {
                _dtoNational.nationalID = txtNationalID.Text.Trim();
                _dtoNational.nationalName = txtNationalName.Text.Trim();

                if (_busNational.insertData(_dtoNational) != 0)
                {
                    MessageBox.Show("Them Thanh Cong!");
                    LoadNational();
                }
                else
                {
                    MessageBox.Show("Co loi xay ra!");

                }
            }
        }

        private void bntDel_Click(object sender, EventArgs e)
        {
            if (txtNationalID.Text.Equals("") || txtNationalName.Text.Equals(""))
            {
                MessageBox.Show("Chua dien thong tin");
                return;
            }
            else
            {
                _dtoNational.nationalID = txtNationalID.Text.Trim();
                _dtoNational.nationalName = txtNationalName.Text.Trim();

                if (_busNational.deleteData(_dtoNational.nationalID) != 0)
                {
                    MessageBox.Show("Xoa Thanh Cong!");
                    LoadNational();
                }
                else
                {
                    MessageBox.Show("Co loi xay ra!");

                }

            }
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if (txtNationalID.Text.Equals("") || txtNationalName.Text.Equals(""))
            {
                MessageBox.Show("Chua dien thong tin");
                return;
            }
            else
            {
                _dtoNational.nationalID = txtNationalID.Text.Trim();
                _dtoNational.nationalName = txtNationalName.Text.Trim();

                if (_busNational.updateData(_dtoNational) != 0)
                {
                    MessageBox.Show("Sua Thanh Cong!");
                    LoadNational();
                }
                else
                {
                    MessageBox.Show("Co loi xay ra!");

                }
            }
        }
    }
}
