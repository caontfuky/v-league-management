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
using System.IO;
using System.Drawing.Imaging;

namespace PresentationLayer
{
    public partial class ucPlayer : DevExpress.XtraEditors.XtraUserControl
    {
        DTOSeason _dtoSeason = new DTOSeason();
        BUSSeason _busSeason = new BUSSeason();
        BUSPlayerTeamSeasoncs _busPlayerTeamSeason = new BUSPlayerTeamSeasoncs();
        DTOPlayer _dtoPlayer = new DTOPlayer();
        BUSPlayer _busPlayer = new BUSPlayer();
        BUSPosition _busPosition = new BUSPosition();
        BUSNational _busNational = new BUSNational();
        string seasonName = "";
        string seasonID = "";
        byte[] ima_byte;
        DataTable dtSeason;
        DataTable dtPlayer;
        DataTable dt;

        public ucPlayer()
        {
            InitializeComponent();
        }

        private void pLAYERGridControl_Click(object sender, EventArgs e)
        {

        }


        private void ucPlayer_Load(object sender, EventArgs e)
        {
//            LoadSeason();
            //LoadListPlayer(seasonName);
            LoadListPlayer();
            LoadPosition();
            LoadNational();
        }

        //public void LoadSeason()
        //{
        //    ComboBoxItemCollection coll = cbxSeason.Properties.Items;
        //    coll.BeginUpdate();
        //    dtSeason = _busSeason.getAllData();
        //    for (int i = 0; i < dtSeason.Rows.Count; i++)
        //    {
        //        coll.Add((dtSeason.Rows[i]["SeasonName"]).ToString());
        //        if (i == dtSeason.Rows.Count - 1)
        //        {
        //            seasonID = (dtSeason.Rows[i]["SeasonID"]).ToString();
        //        }
        //    }
        //    coll.EndUpdate();

        //    cbxSeason.SelectedIndex = coll.Count - 1;
        //    seasonName = cbxSeason.SelectedItem.ToString();
        //    labelSeason.Text = " " + seasonName;
        //}

        public void LoadListPlayer(string seasonName)
        {
            //load danh sach player theo mua giai
            dtPlayer = _busPlayer.getPlayerBySeasonID(seasonID);
            pLAYERGridControl.DataSource = dtPlayer;
        }

        public void LoadListPlayer()
        {
            dtPlayer = _busPlayer.getAllData();
            pLAYERGridControl.DataSource = dtPlayer;
        }

        public void LoadPosition()
        {
            ComboBoxItemCollection coll = cbxPlayerLocate.Properties.Items;
            coll.BeginUpdate();
            dt = _busPosition.getAllData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                coll.Add((dt.Rows[i]["PositionName"]).ToString());

            }
            coll.EndUpdate();
        }

        public void LoadNational()
        {
            ComboBoxItemCollection coll = cbxPlayerNational.Properties.Items;
            coll.BeginUpdate();
            dt = _busNational.getAllData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                coll.Add((dt.Rows[i]["NationalName"]).ToString());

            }
            coll.EndUpdate();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtPlayerID.Text = gridView1.GetRowCellValue(e.RowHandle, "PlayerID").ToString();
            txtPlayerName.Text = gridView1.GetRowCellValue(e.RowHandle, "FullName").ToString();
            txtPlayerBirthdate.Text = gridView1.GetRowCellValue(e.RowHandle, "BirthDay").ToString();
            txtPlayerHeight.Text = gridView1.GetRowCellValue(e.RowHandle, "Height").ToString();
            txtPlayerWeight.Text = gridView1.GetRowCellValue(e.RowHandle, "Weight").ToString();
            cbxPlayerLocate.Text = gridView1.GetRowCellValue(e.RowHandle, "PositionName").ToString(); 
            cbxPlayerNational.Text = gridView1.GetRowCellValue(e.RowHandle, "NationalName").ToString();
            txtNumber.Text = gridView1.GetRowCellValue(e.RowHandle, "NumberOfCloth").ToString();

            if (gridView1.GetRowCellValue(e.RowHandle, "Image") != null)
            {
                try
                {
                    byte[] ima = (byte[])gridView1.GetRowCellValue(e.RowHandle, "Image");
                    MemoryStream memory = new MemoryStream(ima);
                    picturePlayer.Image = Image.FromStream(memory);
                }
                catch (Exception)
                {
                    
                }
            }

        }

        public string getPositionID(string positionName)
        {
            string str = "";
            dt = _busPosition.getPositionIDByPositionName(positionName);
            str = (dt.Rows[0]["PositionID"]).ToString().Trim();
            return str;
        }

        public string getNationalID(string nationalName)
        {
            string str = "";
            dt = _busNational.getNationalIDByNationalName(nationalName);
            str = (dt.Rows[0]["NationalID"]).ToString().Trim();
            return str;
        }

        private void picturePlayer_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string url = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(url))
                return;
            Image ima;
            try
            {
                ima = Image.FromFile(openFileDialog1.FileName);

            }
            catch (Exception)
            {
                return;
            }
            MemoryStream stream = new MemoryStream();
            if (ima != null)
            {
                picturePlayer.Image = ima;
                ima.Save(stream, ImageFormat.Jpeg);
                ima_byte = stream.ToArray();
            }
        }

        private void bntAddPlayerInfo_Click(object sender, EventArgs e)
        {
            if (txtPlayerID.Text.Equals("") || txtPlayerName.Text.Equals("") || txtPlayerBirthdate.Text.Equals("") || txtPlayerHeight.Text.Equals("") ||
                txtPlayerWeight.Text.Equals("") || cbxPlayerLocate.Text.Equals("") || cbxPlayerNational.Text.Equals("") || txtNumber.Text.Equals(""))
            {
                MessageBox.Show("Chua dien du thong tin!");
            }
            else
            {

                _dtoPlayer.playerID = txtPlayerID.Text.Trim();
                _dtoPlayer.fullName = txtPlayerName.Text.Trim();
                _dtoPlayer.birthday = txtPlayerBirthdate.Text.Trim();
                _dtoPlayer.height = Convert.ToInt32(txtPlayerHeight.Text.Trim());
                _dtoPlayer.weight = Convert.ToInt32(txtPlayerWeight.Text.Trim());
                _dtoPlayer.numberOfCloth = Convert.ToInt32(txtNumber.Text.Trim());
                if (ima_byte != null)
                {
                    _dtoPlayer.image = ima_byte;
                }

                try
                {
                    _dtoPlayer.positionID = getPositionID(cbxPlayerLocate.Text.Trim());
                    _dtoPlayer.nationalID = getNationalID(cbxPlayerNational.Text.Trim());

                    if (_busPlayer.insertData(_dtoPlayer) != 0)
                    {
                        MessageBox.Show("Them thanh cong!");
                        LoadListPlayer();
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

        private void bntDelPlayer_Click(object sender, EventArgs e)
        {
            if (txtPlayerID.Text.Equals(""))
            {
                MessageBox.Show("Chua nhap thong tin");
            }else{
                try
                {
                    if (_busPlayer.deleteData(txtPlayerID.Text.Trim()) != 0)
                    {
                        MessageBox.Show("Xoa thanh cong!");
                        LoadListPlayer();
                    }
                    else
                    {
                        MessageBox.Show("Xoa khong thanh cong!");                    
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoa khong thanh cong!");                    
                }
            }
        }

        private void bntUpdatePlayerInfo_Click(object sender, EventArgs e)
        {
            if (txtPlayerID.Text.Equals("") || txtPlayerName.Text.Equals("") || txtPlayerBirthdate.Text.Equals("") || txtPlayerHeight.Text.Equals("") ||
                txtPlayerWeight.Text.Equals("") || cbxPlayerLocate.Text.Equals("") || cbxPlayerNational.Text.Equals("") || txtNumber.Text.Equals(""))
            {
                MessageBox.Show("Chua dien du thong tin!");
            }
            else
            {

                _dtoPlayer.playerID = txtPlayerID.Text.Trim();
                _dtoPlayer.fullName = txtPlayerName.Text.Trim();
                _dtoPlayer.birthday = txtPlayerBirthdate.Text.Trim();
                _dtoPlayer.height = Convert.ToInt32(txtPlayerHeight.Text.Trim());
                _dtoPlayer.weight = Convert.ToInt32(txtPlayerWeight.Text.Trim());
                _dtoPlayer.numberOfCloth = Convert.ToInt32(txtNumber.Text.Trim());
                if (ima_byte != null)
                {
                    _dtoPlayer.image = ima_byte;
                }

                try
                {
                    _dtoPlayer.positionID = getPositionID(cbxPlayerLocate.Text.Trim());
                    _dtoPlayer.nationalID = getNationalID(cbxPlayerNational.Text.Trim());

                    if (_busPlayer.updateData(_dtoPlayer) != 0)
                    {
                        MessageBox.Show("Sua thanh cong!");
                        LoadListPlayer();
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
