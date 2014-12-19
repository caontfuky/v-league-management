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
    public partial class ucCoach : DevExpress.XtraEditors.XtraUserControl
    {
        DTOCoach _dtoCoach = new DTOCoach();
        BUSCoach _busCoach = new BUSCoach();
        DataTable dtCoach;

        public ucCoach()
        {
            InitializeComponent();
        }

        private void ucCoach_Load(object sender, EventArgs e)
        {
            LoadCoach();
        }

        public void LoadCoach()
        {
            dtCoach = _busCoach.getAllData();
            coachGrid.DataSource = dtCoach;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtID.Text = gridView1.GetRowCellValue(e.RowHandle, "CoachID").ToString();
            txtName.Text = gridView1.GetRowCellValue(e.RowHandle, "CoachName").ToString();
            txtAddresss.Text = gridView1.GetRowCellValue(e.RowHandle, "Address").ToString();
            txtBirthDay.Text = gridView1.GetRowCellValue(e.RowHandle, "BirthDay").ToString();
            txtTel.Text = gridView1.GetRowCellValue(e.RowHandle, "PhoneNumber").ToString();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtName.Text.Equals("") || txtBirthDay.Text.Equals(""))
            {
                MessageBox.Show("Thieu thong tin");
            }
            else
            {
                _dtoCoach.coachID = txtID.Text.Trim();
                _dtoCoach.coachName = txtName.Text.Trim();
                _dtoCoach.birthDay = txtBirthDay.Text.Trim();
                _dtoCoach.phoneNumber = Convert.ToInt32(txtTel.Text.Trim());
                _dtoCoach.address = txtAddresss.Text.Trim();

                try
                {
                    if (_busCoach.insertData(_dtoCoach) != 0)
                    {
                        MessageBox.Show("Them thanh cong!");
                        LoadCoach();
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
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Thieu thong tin");
            }
            else
            {
                try
                {
                    if (_busCoach.deleteData(txtID.Text.Trim()) != 0)
                    {
                        MessageBox.Show("Xoa thanh cong!");
                        LoadCoach();
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
            if (txtID.Text.Equals("") || txtName.Text.Equals("") || txtBirthDay.Text.Equals(""))
            {
                MessageBox.Show("Thieu thong tin");
            }
            else
            {
                _dtoCoach.coachID = txtID.Text.Trim();
                _dtoCoach.coachName = txtName.Text.Trim();
                _dtoCoach.birthDay = txtBirthDay.Text.Trim();
                _dtoCoach.address = txtAddresss.Text.Trim();

                try
                {
                    _dtoCoach.phoneNumber = Convert.ToInt32(txtTel.Text.Trim());

                    if (_busCoach.updateData(_dtoCoach) != 0)
                    {
                        MessageBox.Show("Sua thanh cong!");
                        LoadCoach();
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
