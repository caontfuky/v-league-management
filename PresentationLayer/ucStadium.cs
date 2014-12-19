using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinnessLogicLayer;
using DataTransferObject;

namespace PresentationLayer
{
    public partial class ucStadium : DevExpress.XtraEditors.XtraUserControl
    {
        DTOStadium _dtoStadium = new DTOStadium();
        BUSStadium _busStadium = new BUSStadium();
        DataTable dtStadium;

        public ucStadium()
        {
            InitializeComponent();
        }

        private void ucStadium_Load(object sender, EventArgs e)
        {
            LoadStadium();
        }

        public void LoadStadium()
        {
            dtStadium = _busStadium.getAllData();
            StadiumGrid.DataSource = dtStadium;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtStadiumID.Text = gridView1.GetRowCellValue(e.RowHandle, "StadiumID").ToString();
            txtStadiumName.Text = gridView1.GetRowCellValue(e.RowHandle, "StadiumName").ToString();
            txtTankage.Text = gridView1.GetRowCellValue(e.RowHandle, "Tankage").ToString();
            txtAddress.Text = gridView1.GetRowCellValue(e.RowHandle, "Address").ToString();
        }


        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (txtStadiumID.Text.Equals("") || txtStadiumName.Text.Equals("") || txtTankage.Text.Equals("") || txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Nhap thieu thong tin!");
            }
            else
            {
                _dtoStadium.stadiumID = txtStadiumID.Text.Trim();
                _dtoStadium.stadiumName = txtStadiumName.Text.Trim();
                _dtoStadium.tankage = Convert.ToInt32(txtTankage.Text.Trim());
                _dtoStadium.address = txtAddress.Text.Trim();

                try
                {
                    if (_busStadium.insertData(_dtoStadium) != 0)
                    {
                        MessageBox.Show("Them thanh cong!");
                        LoadStadium();
                    }
                    else
                    {
                        MessageBox.Show("Co loi xay ra!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Co loi xay ra!");                    
                }
            }
        }

        private void bntDel_Click(object sender, EventArgs e)
        {
            if (txtStadiumID.Text.Equals(""))
            {
                MessageBox.Show("Nhap thieu thong tin!");
            }
            else
            {

                try
                {
                    if (_busStadium.deleteData(txtStadiumID.Text.Trim()) != 0)
                    {
                        MessageBox.Show("Xoa thanh cong!");
                        LoadStadium();
                    }
                    else
                    {
                        MessageBox.Show("Co loi xay ra!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Co loi xay ra!");
                }
            }
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if (txtStadiumID.Text.Equals("") || txtStadiumName.Text.Equals("") || txtTankage.Text.Equals("") || txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Nhap thieu thong tin!");
            }
            else
            {
                _dtoStadium.stadiumID = txtStadiumID.Text.Trim();
                _dtoStadium.stadiumName = txtStadiumName.Text.Trim();
                _dtoStadium.tankage = Convert.ToInt32(txtTankage.Text.Trim());
                _dtoStadium.address = txtAddress.Text.Trim();

                try
                {
                    if (_busStadium.updateData(_dtoStadium) != 0)
                    {
                        MessageBox.Show("Sua thanh cong!");
                        LoadStadium();
                    }
                    else
                    {
                        MessageBox.Show("Co loi xay ra!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Co loi xay ra!");
                }
            }
        }

    }
}
