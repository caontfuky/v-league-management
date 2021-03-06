﻿using System;
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
        string seasonID = "";
        DataTable dtPlayer;
        DataTable dt;
        bool isNewRow = false;
        bool isUpdate = false;
        bool isMessage = false;
        int rowUpdate = -1;
        int rowSelect = -1;
        public ucPlayer()
        {
            InitializeComponent();
        }

        private void ucPlayer_Load(object sender, EventArgs e)
        {
            LoadListPlayer();
            gridView1.CellValueChanged += gridView1_CellValueChanged;
        }

        void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isNewRow) 
            {
                isUpdate = true;
                rowUpdate = e.RowHandle;     
            }
        }

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

            LoadPosition();
            LoadNational();
        }

        public void LoadPosition()
        {
            ComboBoxItemCollection coll = repositoryItemComboBox1.Items;
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
            ComboBoxItemCollection coll = repositoryItemComboBox2.Items;
            coll.BeginUpdate();
            dt = _busNational.getAllData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                coll.Add((dt.Rows[i]["NationalName"]).ToString());

            }
            coll.EndUpdate();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNewRow)   //new da them hang moi
            {
                string playerID = gridView1.GetRowCellValue(rowSelect, "PlayerID").ToString();
                string playerName = gridView1.GetRowCellValue(rowSelect, "FullName").ToString();
                DateTime birthDay =(DateTime) gridView1.GetRowCellValue(rowSelect, "BirthDay");
                string height = gridView1.GetRowCellValue(rowSelect, "Height").ToString();
                string weight = gridView1.GetRowCellValue(rowSelect, "Weight").ToString();
                string positionName = gridView1.GetRowCellValue(rowSelect, "PositionName").ToString();
                string nationalName = gridView1.GetRowCellValue(rowSelect, "NationalName").ToString();
                string number = gridView1.GetRowCellValue(rowSelect, "NumberOfCloth").ToString();
                byte[] ima;
                try
                {
                    ima = (byte[])gridView1.GetRowCellValue(rowSelect, "Image");
                }
                catch (Exception)
                {
                    ima = null;
                }

                if (playerID.Equals("") || playerName.Equals("") || birthDay.Equals("") || height.Equals("") || weight.Equals("") ||
                    positionName.Equals("") || nationalName.Equals("") || number.Equals(""))
                {
                    MessageBox.Show("Chua dien du thong tin!");
                    return;
                }
                else
                {
                    if ((DateTime.Now.Year - birthDay.Year) < 18)
                    {
                        MessageBox.Show("Tuoi cau thu khong phu hop voi quy dinh!");
                        return;
                    }
                    _dtoPlayer.playerID = playerID.Trim();
                    _dtoPlayer.fullName = playerName.Trim();
                    _dtoPlayer.birthday = birthDay.ToString().Trim();
                    _dtoPlayer.height = Convert.ToInt32(height.Trim());
                    _dtoPlayer.weight = Convert.ToInt32(weight.Trim());
                    _dtoPlayer.numberOfCloth = Convert.ToInt32(number.Trim());
                    _dtoPlayer.image = ima;
                    try
                    {
                        _dtoPlayer.positionID = getPositionID(positionName.Trim());
                        _dtoPlayer.nationalID = getNationalID(nationalName.Trim());

                        if (_busPlayer.insertData(_dtoPlayer) != 0)
                        {
                            MessageBox.Show("Them thanh cong!");
                            LoadListPlayer();
                            isNewRow = false;

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

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                //kiem tra 
                if (isNewRow || isUpdate)
                {
                    InsertUpdate(row);
                }
                else
                {
                    gridView1.AddNewRow();
                    isNewRow = true;
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.RowCount - 1);
            if (row == null)
                return;
            if (isNewRow && !isMessage)   //new da them hang moi
            {
                InsertUpdate(row);
            }
            else
            {
                if (isUpdate)
                {
                    DataRow r = gridView1.GetDataRow(rowUpdate);
                    InsertUpdate(r);
                }
            }
        }

        private void Player_Image_DoubleClick(object sender, EventArgs e)
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
            if (ima != null)
            {
                MemoryStream stream = new MemoryStream();
                ima.Save(stream, ImageFormat.Jpeg);
                System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                (row["Image"]) = stream.ToArray() ;
            }
        }

        private void bnt_InsertUpdate_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (isUpdate || isNewRow)
            {
                System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                InsertUpdate(row);
            }
        }

        private void bnt_Del_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int rowFocus = gridView1.FocusedRowHandle;
            System.Data.DataRow row = gridView1.GetDataRow(rowFocus);
            if (isNewRow)
            {
                isNewRow = false;
                gridView1.DeleteSelectedRows();
                return;
            }
            if (MessageBox.Show("Ban co muon xoa cau thu nay?", "MessageBox", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (row["PlayerID"].ToString().Equals(""))
                {
                    return;
                }
                else
                {
                    try
                    {
                        if (_busPlayer.deleteData(row["PlayerID"].ToString().Trim()) != 0)
                        {
                            MessageBox.Show("Xoa thanh cong!");
                            LoadListPlayer();
                            gridView1.FocusedRowHandle = rowFocus - 1;
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
        }

        public bool InsertUpdate(DataRow row)
        {
            try
            {
                if (row["FullName"].ToString().Equals("") || row["BirthDay"].ToString().Equals("") || row["Height"].ToString().Equals("") ||
                   row["Weight"].ToString().Equals("") || row["PositionName"].ToString().Equals("") ||
                   row["NationalName"].ToString().Equals("") || row["NumberOfCloth"].ToString().Equals(""))
                {
                    isMessage = true;
                    gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                    isMessage = false;
                    MessageBox.Show("Chua dien du thong tin!");
                    return false;
                }
                else
                {
                    string playerID = row["PlayerID"].ToString();
                    string playerName = row["FullName"].ToString();
                    DateTime birthDay = (DateTime)row["BirthDay"];
                    string height = row["Height"].ToString();
                    string weight = row["Weight"].ToString();
                    string positionName = row["PositionName"].ToString();
                    string nationalName = row["NationalName"].ToString();
                    string number = row["NumberOfCloth"].ToString();
                    byte[] ima;
                    try
                    {
                        ima = (byte[])row["Image"];
                    }
                    catch (Exception)
                    {
                        ima = null;
                    }
                    if ((DateTime.Now.Year - birthDay.Year) < 18)
                    {
                        MessageBox.Show("Tuoi cau thu khong phu hop voi quy dinh!");
                        return false;
                    }
                    _dtoPlayer.playerID = "PL0";
                    _dtoPlayer.fullName = playerName.Trim();
                    _dtoPlayer.birthday = birthDay.ToString().Trim();
                    _dtoPlayer.height = Convert.ToInt32(height.Trim());
                    _dtoPlayer.weight = Convert.ToInt32(weight.Trim());
                    _dtoPlayer.numberOfCloth = Convert.ToInt32(number.Trim());
                    _dtoPlayer.image = ima;
                    try
                    {
                        _dtoPlayer.positionID = getPositionID(positionName.Trim());
                        _dtoPlayer.nationalID = getNationalID(nationalName.Trim());
                        if (isNewRow)
                        {
                            if (_busPlayer.insertData(_dtoPlayer) != 0)
                            {
                                MessageBox.Show("Them thanh cong!");
                                isNewRow = false;
                                isMessage = false;
                                LoadListPlayer();
                                gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Them khong thanh cong!");
                                isMessage = true;
                                return false;
                            }
                        }
                        else
                        {
                            _dtoPlayer.playerID = playerID.Trim();
                            if (_busPlayer.updateData(_dtoPlayer) != 0)
                            {
                                MessageBox.Show("Sua thanh cong!");
                                isUpdate = false;
                                LoadListPlayer();
                                gridView1.FocusedRowHandle = rowUpdate;
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Sua khong thanh cong!");
                                return false;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Co loi xay ra!");
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                isMessage = true;
                gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                isMessage = false;
                MessageBox.Show("Chua dien du thong tin!");
                return false;
            }
        }
    }
}
