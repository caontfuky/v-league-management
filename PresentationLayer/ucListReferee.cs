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
using DevExpress.XtraEditors.Controls;

namespace PresentationLayer
{
    public partial class ucListReferee : DevExpress.XtraEditors.XtraUserControl
    {
        DTOSeason _dtoSeason = new DTOSeason();
        BUSSeason _busSeason = new BUSSeason();
        DTOReferee _dtoReferee = new DTOReferee();
        BUSRefereee _busReferee = new BUSRefereee();
        string seasonName = "";
        string seasonID = "";
        DataTable dtSeason;

        public ucListReferee()
        {
            InitializeComponent();
        }

        private void ucListReferee_Load(object sender, EventArgs e)
        {
            ComboBoxItemCollection coll = cbxSeason.Properties.Items;
            coll.BeginUpdate();
            dtSeason = _busSeason.getAllData();
            for (int i = 0; i < dtSeason.Rows.Count; i++)
            {
                coll.Add((dtSeason.Rows[i]["SeasonName"]).ToString());
                if (i == dtSeason.Rows.Count - 1)
                {
                    seasonID = (dtSeason.Rows[i]["SeasonID"]).ToString();
                }
            }
            coll.EndUpdate();

            cbxSeason.SelectedIndex = coll.Count - 1;
            seasonName = cbxSeason.SelectedItem.ToString();
            labelSeason.Text = " " + seasonName;
        }

        private void cbxSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            //thay doi gia tri trong bang theo mua giai
            rEFEREEGridControl.DataSource = _busReferee.getDataBySeason(cbxSeason.SelectedItem.ToString());
            for (int i = 0; i < dtSeason.Rows.Count; i++)
            {
                if ((dtSeason.Rows[i]["SeasonName"]).Equals(cbxSeason.SelectedItem.ToString()))
                {
                    seasonID = (dtSeason.Rows[i]["SeasonID"]).ToString();
                }
            }
            seasonName = cbxSeason.SelectedItem.ToString();
            labelSeason.Text = " " + seasonName;
        }

        //private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    txtName.Text = gridView1.GetRowCellValue(e.RowHandle, "RefereeName").ToString();
        //    txtEmail.Text = gridView1.GetRowCellValue(e.RowHandle, "Email").ToString();
        //    txtBirthDay.Text = gridView1.GetRowCellValue(e.RowHandle, "BirthDate").ToString();
        //    txtTel.Text = gridView1.GetRowCellValue(e.RowHandle, "PhoneNumber").ToString();
        //    txtAddresss.Text = gridView1.GetRowCellValue(e.RowHandle, "Address").ToString();
        //    txtID.Text = gridView1.GetRowCellValue(e.RowHandle, "RefereeID").ToString();
        //}

        private void bntAdd_Click(object sender, EventArgs e)
        {
            _dtoReferee.refereeID = txtID.Text.Trim();
            _dtoReferee.refereeName = txtName.Text.Trim();
            _dtoReferee.phoneNumber = txtTel.Text.Trim();
            _dtoReferee.email = txtEmail.Text.Trim();
            _dtoReferee.birthDate = txtBirthDay.Text.Trim();
            _dtoReferee.address = txtAddresss.Text.Trim();
            _dtoReferee.seasonID = seasonID;
            try
            {
                _busReferee.insertData(_dtoReferee);
                MessageBox.Show("Them thanh cong!");
                cbxSeason_SelectedIndexChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Them khong thanh cong!");                
            }
        }

        private void bntDel_Click(object sender, EventArgs e)
        {
            try
            {
                _busReferee.deleteData(txtID.Text.Trim());
                MessageBox.Show("Xoa thanh cong!");
                cbxSeason_SelectedIndexChanged(sender, e);

            }
            catch (Exception)
            {
                MessageBox.Show("Xoa khong thanh cong!");
            }
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {

        }

    }
}
