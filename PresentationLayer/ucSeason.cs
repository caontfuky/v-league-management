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
using DevExpress.XtraEditors.Controls;

namespace PresentationLayer
{
    public partial class ucSeason : DevExpress.XtraEditors.XtraUserControl
    {
        DTOSeason _dtoSeason = new DTOSeason();
        BUSSeason _busSeason = new BUSSeason();
        DataTable dtSeason;
        string seasonName = "";

        public ucSeason()
        {
            InitializeComponent();
            LoadSeason();
        }

        public void LoadSeason()
        {
            ComboBoxItemCollection coll = cbxSeason.Properties.Items;
            coll.BeginUpdate();
            coll.Clear();
            dtSeason = _busSeason.getAllData();
            for (int i = 0; i < dtSeason.Rows.Count; i++)
            {
                coll.Add((dtSeason.Rows[i]["SeasonName"]).ToString());
                if (i == dtSeason.Rows.Count - 1)
                {
                    putInfoIntoTxt(dtSeason, i);
                }
            }
            coll.EndUpdate();

            cbxSeason.SelectedIndex = coll.Count - 1;
            seasonName = cbxSeason.SelectedItem.ToString();
            labelSeason.Text = seasonName;
        }

        private void cbxSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dtSeason.Rows.Count; i++)
            {
                if ((dtSeason.Rows[i]["SeasonName"]).Equals(cbxSeason.SelectedItem.ToString()))
                {
                    putInfoIntoTxt(dtSeason, i);
                }
            }
            seasonName = cbxSeason.SelectedItem.ToString();
            labelSeason.Text = " " + seasonName;

        }

        public void putInfoIntoTxt(DataTable dt, int rowIndex)
        {
            txtID.Text = (dt.Rows[rowIndex]["SeasonID"]).ToString();
            txtName.Text = (dt.Rows[rowIndex]["SeasonName"]).ToString();
            txtSponsor.Text = (dt.Rows[rowIndex]["Sponsor"]).ToString();
            txtStartDate.Text = (dt.Rows[rowIndex]["StartDate"]).ToString();
            txtEndDate.Text = (dt.Rows[rowIndex]["EndDate"]).ToString();
            txtExpenditure.Text = (dt.Rows[rowIndex]["Expenditure"]).ToString();
        }


        private void bntAdd_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Equals("") || txtName.Text.Equals("") || txtSponsor.Text.Equals("") || txtStartDate.Text.Equals("") ||
                txtEndDate.Text.Equals("") || txtExpenditure.Text.Equals(""))
            {
                MessageBox.Show("Nhap thieu thong tin!");
                return;
            }
            else
            {

                if (txtStartDate.DateTime.CompareTo(DateTime.Now) < 0)
                {
                    MessageBox.Show("Thoi gian bat dau phai sau thoi diem hien tai!");
                    return;
                }

                if (txtEndDate.DateTime.CompareTo(txtStartDate.DateTime) < 0)   // ket thuc sau bat dau
                {
                    MessageBox.Show("Thoi gian bat dau lon hon thoi gian ket thuc!");
                    return;
                }

                _dtoSeason.startDate = txtStartDate.Text.Trim();
                _dtoSeason.endDate = txtEndDate.Text.Trim();
                _dtoSeason.seasonID = txtID.Text.Trim();
                _dtoSeason.seasonName = txtName.Text.Trim();
                _dtoSeason.sponsor = txtSponsor.Text.Trim();

                if (_busSeason.insertData(_dtoSeason) != 0)
                {
                    MessageBox.Show("Them mua giai thanh cong!");
                    LoadSeason();
                }
                else
                {
                    MessageBox.Show("Co loi xay ra!");
                }
            }
        }


        private void bntDel_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Nhap thieu thong tin!");
            }
            else
            {
                if (_busSeason.deleteData(txtID.Text.Trim()) != 0)
                {
                    MessageBox.Show("Xoa thanh cong!");
                    LoadSeason();
                }
                else
                {
                    MessageBox.Show("Co loi xay ra!");
                }
            }
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtName.Text.Equals("") || txtSponsor.Text.Equals("") || txtStartDate.Text.Equals("") ||
    txtEndDate.Text.Equals("") || txtExpenditure.Text.Equals(""))
            {
                MessageBox.Show("Nhap thieu thong tin!");
                return;
            }
            else
            {

                if (txtStartDate.DateTime.CompareTo(DateTime.Now) < 0)
                {
                    MessageBox.Show("Thoi gian bat dau phai sau thoi diem hien tai!");
                    return;
                }

                if (txtEndDate.DateTime.CompareTo(txtStartDate.DateTime) < 0)   // ket thuc sau bat dau
                {
                    MessageBox.Show("Thoi gian bat dau lon hon thoi gian ket thuc!");
                    return;
                }

                _dtoSeason.startDate = txtStartDate.Text.Trim();
                _dtoSeason.endDate = txtEndDate.Text.Trim();
                _dtoSeason.seasonID = txtID.Text.Trim();
                _dtoSeason.seasonName = txtName.Text.Trim();
                _dtoSeason.sponsor = txtSponsor.Text.Trim();

                if (_busSeason.updateData(_dtoSeason) != 0)
                {
                    MessageBox.Show("Sua mua giai thanh cong!");
                    LoadSeason();
                }
                else
                {
                    MessageBox.Show("Co loi xay ra!");
                }
            }
        }
        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
