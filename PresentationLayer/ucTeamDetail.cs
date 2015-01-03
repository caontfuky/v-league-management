using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinnessLogicLayer;
using DevExpress.XtraEditors;
using DataTransferObject;
using System.IO;
using DevExpress.XtraEditors.Controls;
using System.Drawing.Imaging;

namespace PresentationLayer
{
    public partial class ucTeamDetail : UserControl
    {
        public static int COUNTPLAYER = 5;
        public bool isUpdate = false;
        public bool isCreate = false;
        public byte[] logo_byte;
        public DTOTeam _dtoTeam = new DTOTeam();
        public BUSTeam _busTeam = new BUSTeam();
        public DTOPlayer _dtoPlayer = new DTOPlayer();
        public BUSPlayer _busPlayer = new BUSPlayer();
        public BUSStadium _busStadium = new BUSStadium();
        public BUSPlayerTeamSeasoncs _busPTS = new BUSPlayerTeamSeasoncs();
        public DTOPlayerTeamSeason _dtoPTS = new DTOPlayerTeamSeason();
        DataTable dtTeam;
        DataTable dtPlayer;
        DataTable dtStadium;
        DataTable dtPlayerFree;
        string stadiumID = "";
        int rowIndexSelectedRight = -1;
        int rowIndexSelectedLeft = -1;
        bool isTeamInfoComplete = false;
        string t = "";

        public ucTeamDetail(string seasonID)
        {
            InitializeComponent();
            isCreate = true;
            //Load san van dong
            dtStadium = _busStadium.getAllData();
            LoadStadium();
            _dtoPTS.seasonID = seasonID;

            //Load ds cau thu tu do
            LoadPlayerFree(seasonID);
        }

        public ucTeamDetail(string teamID, string seasonID)
        {
            InitializeComponent();
            isUpdate = true;
            _dtoPTS.seasonID = seasonID;

            //Load san van dong
            dtStadium = _busStadium.getAllData();
            LoadStadium();
            //load team dua vao teamID
            dtTeam = _busTeam.getTeamByTeamID(teamID);

            txtTeamID.Text = (dtTeam.Rows[0]["TeamID"]).ToString();
            txtTeamID.Enabled = false;
            txtTeamName.Text = (dtTeam.Rows[0]["Name"]).ToString();
            txtFax.Text = (dtTeam.Rows[0]["Fax"]).ToString();
            txtTelTeam.Text = (dtTeam.Rows[0]["PhoneNumber"]).ToString();
            txtEmailTeam.Text = (dtTeam.Rows[0]["Email"]).ToString();
            txtChairman.Text = (dtTeam.Rows[0]["Chairman"]).ToString();
            txtAddressTeam.Text = (dtTeam.Rows[0]["Address"]).ToString();
            txtCeo.Text = (dtTeam.Rows[0]["CEO"]).ToString();
            txtYear.Text = (dtTeam.Rows[0]["EstablishedYear"]).ToString();
            byte[] logo = (byte[])(dtTeam.Rows[0]["Logo"]);
            MemoryStream memory = new MemoryStream(logo);
            pictureLogoTeam.Image = Image.FromStream(memory);

            for (int i = 0; i < dtStadium.Rows.Count; i++)
            {
                if ((dtStadium.Rows[i]["StadiumID"]).ToString().Trim().Equals((dtTeam.Rows[0]["StadiumID"]).ToString().Trim()))
                {
                    cbxStadium.SelectedIndex = i;
                }
            }
            
            //load ds cau thu cua team
            LoadPlayerOfTeam(teamID, seasonID);
            //Load ds cau thu tu do
            LoadPlayerFree(seasonID);
        }

        public void LoadPlayerFree(string seasonID)    // cau thu trong mua hien tai khong thuoc doi bong nao
        {
            dtPlayerFree = _busPlayer.getPlayerFreeBySeasonID(seasonID);
            if (dtPlayerFree.Rows.Count > 0)
            {
                rowIndexSelectedRight = 0;
            }
            gridPlayerFree.DataSource = dtPlayerFree;

        }

        public void LoadPlayerOfTeam(string TeamID, string seasonID)
        {
            dtPlayer = _busPlayer.getPlayerBySeasonIDAndTeamID(seasonID, TeamID );
            if (dtPlayer.Rows.Count > 0)
            {
                rowIndexSelectedLeft = 0;
            }
            gridPlayerOfTeam.DataSource = dtPlayer;

        }

        public void LoadStadium()
        {
            ComboBoxItemCollection coll = cbxStadium.Properties.Items;
            coll.BeginUpdate();
            for (int i = 0; i < dtStadium.Rows.Count; i++)
            {
                coll.Add((dtStadium.Rows[i]["StadiumName"]).ToString());

                if (i == dtStadium.Rows.Count - 1)
                {
                    stadiumID = (dtStadium.Rows[i]["StadiumID"]).ToString();
                }

            }
            coll.EndUpdate();

            cbxStadium.SelectedIndex = coll.Count - 1;
        }

        private void TabPageTeamInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntCompleteTeam_Click(object sender, EventArgs e)
        {
            if(txtTeamID.Text.Equals("") || txtTeamName.Text.Equals("") || txtChairman.Text.Equals("") || txtCeo.Text.Equals("") ||
                txtEmailTeam.Text.Equals("") || txtAddressTeam.Text.Equals("") || cbxStadium.Text.Equals(""))
            {
                MessageBox.Show("Nhap thieu thong tin!");
                return;
            }
            else
            {
                try
                {
                    int tel = Convert.ToInt32(txtTelTeam.Text.Trim());
                    _dtoTeam.phoneNumber = txtTelTeam.Text.Trim();

                }
                catch (Exception)
                {
                    MessageBox.Show("So dien thoai phai nhap so!");
                    return;
                }

                try
                {
                    int tel = Convert.ToInt32(txtFax.Text.Trim());
                    _dtoTeam.fax = txtFax.Text.Trim();

                }
                catch (Exception)
                {
                    MessageBox.Show("Fax phai nhap so!");
                    return;
                }

                if (txtYear.DateTime.CompareTo(DateTime.Now) > 0)
                {
                    MessageBox.Show("Thoi gian thanh lap phai truoc thoi diem hien tai!");
                    return;
                }

                DataTable d = _busTeam.getTeamByTeamID(txtTeamID.Text.Trim());
                if (d.Rows.Count > 0 && isCreate)
                {
                    MessageBox.Show("ID da ton tai!");
                    return;
                }

                _dtoTeam.address = txtAddressTeam.Text.Trim();
                _dtoTeam.cEO = txtCeo.Text.Trim();
                _dtoTeam.chairman = txtChairman.Text.Trim();
                _dtoTeam.name = txtTeamName.Text.Trim();
                _dtoTeam.teamID = txtTeamID.Text.Trim();
                _dtoTeam.email = txtEmailTeam.Text.Trim();

                MemoryStream stream = new MemoryStream();

                if (pictureLogoTeam.Image != null)
                {
                    pictureLogoTeam.Image.Save(stream, ImageFormat.Jpeg);
                    _dtoTeam.logo = stream.ToArray();
                }
                
                _dtoTeam.stadiumID = stadiumID.Trim();
                _dtoTeam.establishedYear = txtYear.Text.Trim();

                isTeamInfoComplete = true;
                //chuyen tab
                TabControl.SelectedTabPageIndex = 1;
            }
        }

        private void cbxStadium_SelectedIndexChanged(object sender, EventArgs e)
        {
            stadiumID = (dtStadium.Rows[cbxStadium.SelectedIndex]["StadiumID"]).ToString();
        }

        private void bntDestroyTeam_Click(object sender, EventArgs e)
        {
            //lam j gio?

        }

        private void bntRightToLeft_Click(object sender, EventArgs e)
        {
            if (isCreate)
            {
                //insert team
                _busTeam.insertTeam(_dtoTeam);
            }
            
            //chuyen cau thu tu free sang cau thu cua team
            //lay ID cau thu dang chon ben phai, ID team, ID season them vao bang PlayerTeamSeason
            _dtoPTS.playerID = (gridViewRight.GetRowCellValue(rowIndexSelectedRight, "PlayerID")).ToString().Trim();
            _dtoPTS.teamID = txtTeamID.Text.Trim();

            _busPTS.insertData(_dtoPTS);

            //cap nhat lai 2 gridviewRight va girdviewLeft
            LoadPlayerFree(_dtoPTS.seasonID);
            LoadPlayerOfTeam(_dtoPTS.teamID, _dtoPTS.seasonID);
        }

        private void bntLeftToRight_Click(object sender, EventArgs e)
        {
            //chuyen cau thu tu cua team sang free
            //lay ID cau thu dang chon ben trai, ID team, ID season xoa trong bang PlayerTeamSeason
            _dtoPTS.playerID = (gridViewLeft.GetRowCellValue(rowIndexSelectedLeft, "PlayerID")).ToString().Trim();
            _dtoPTS.teamID = txtTeamID.Text.Trim();

            _busPTS.deleteDataBySeasonIDAndTeamIDAndPlayerID(_dtoPTS.seasonID, _dtoPTS.teamID, _dtoPTS.playerID);

            //cap nhat lai 2 gridviewRight va girdviewLeft
            LoadPlayerFree(_dtoPTS.seasonID);
            LoadPlayerOfTeam(_dtoPTS.teamID, _dtoPTS.seasonID);
        }

        private void bntComplete_Click(object sender, EventArgs e)
        {
            
                //dem so luong cau thu so vs quy dinh
            if (gridViewLeft.RowCount < COUNTPLAYER)
            {
                MessageBox.Show("So luong cau thu it hon quy dinh!");
                return;
            }
            else
            {
                if (isCreate)
                {
                    //if (MessageBox.Show("Ban co muon them doi bong nay?", "Co", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                    //    if (isTeamInfoComplete)
                    //    {
                    //        if (_busTeam.insertTeam(_dtoTeam) != 0)
                    //        {
                    //            MessageBox.Show("Them doi bong thanh cong!");
                    //        }
                    //        else
                    //        {
                    //            MessageBox.Show("Co loi xay ra!");
                    //        }
                    //    }
                    //}
                }
                else
                {
                    if (MessageBox.Show("Ban co muon sua thong tin doi bong nay?", "Co", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (isTeamInfoComplete)
                        {
                            if (_busTeam.updateTeam(_dtoTeam) != 0)
                            {
                                MessageBox.Show("Sua thong tin doi bong thanh cong!");
                            }
                            else
                            {
                                MessageBox.Show("Co loi xay ra!");
                            }
                        }
                    }
                }
            }
        }

        private void bntReturn_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTabPageIndex = 0;
        }

        private void bntDestroy_Click(object sender, EventArgs e)
        {
            //lam j gio?
        }

        private void gridViewRight_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            rowIndexSelectedRight = e.RowHandle;
        }

        private void gridViewLeft_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            rowIndexSelectedLeft = e.RowHandle;
        }

        private void pictureLogoTeam_Click(object sender, EventArgs e)
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
                pictureLogoTeam.Image = ima;
            }
        }

        private void ucTeamDetail_Load(object sender, EventArgs e)
        {
            //Load san van dong
            //LoadStadium();
        }

    }
}
