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
        bool isNewRow = false;
        bool isUpdate = false;
        bool isMessage = false;
        int rowUpdate = -1;

        public ucCoach()
        {
            InitializeComponent();
            this.Load += ucCoach_Load;
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

        private void InsertUpdate(DataRow row)
        {
            try
            {
                if (row["CoachName"].ToString().Equals(""))
                {
                    isMessage = true;
                    gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                    isMessage = false;
                    MessageBox.Show("Chua dien du thong tin!");
                    return;
                }
                else
                {
                    _dtoCoach.coachID = "CH0";
                    _dtoCoach.coachName = row["CoachName"].ToString().Trim();
                    if (!row["PhoneNumber"].ToString().Equals(""))
                    {
                        try
                        {
                            _dtoCoach.phoneNumber = Convert.ToInt32(row["PhoneNumber"].ToString().Trim());                       
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("So dien thoai phai la so");
                            return;
                        }
                    }
                    if (!row["BirthDay"].ToString().Equals(""))
                    {
                        try
                        {
                            int birthDay = Convert.ToInt32(row["BirthDay"].ToString().Trim());
                            if ((DateTime.Now.Year - birthDay) < 28)
                            {
                                MessageBox.Show("Tuoi cau thu khong phu hop voi quy dinh!");
                                return;
                            }
                            _dtoCoach.birthDay = birthDay;
                        }
                        catch (Exception)
                        {
                            
                        }
                    }
                    _dtoCoach.address = row["Address"].ToString().Trim();
                    try
                    {
                        if (isNewRow)
                        {


                            if (_busCoach.insertData(_dtoCoach) != 0)
                            {
                                MessageBox.Show("Them thanh cong!");
                                isNewRow = false;
                                isMessage = false;
                                LoadCoach();
                                gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Them khong thanh cong!");
                                isMessage = true;
                                return;
                            }
                        }
                        else
                        {
                            _dtoCoach.coachID = row["CoachID"].ToString().Trim();
                            if (_busCoach.updateData(_dtoCoach) != 0)
                            {
                                MessageBox.Show("Sua thanh cong!");
                                isUpdate = false;
                                LoadCoach();
                                gridView1.FocusedRowHandle = rowUpdate;
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Sua khong thanh cong!");
                                return;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Co loi xay ra!");
                        return;
                    }
                }
            }
            catch (Exception)
            {
                isMessage = true;
                gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                isMessage = false;
                MessageBox.Show("Chua dien du thong tin!");
                return;
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                //kiem tra 
                if (isNewRow || isUpdate) // neu dang them hang moi
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

        private void bnt_InsertUpdate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (isUpdate || isNewRow)
            {
                System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                InsertUpdate(row);
            }
        }

        private void bnt_Del_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int rowFocus = gridView1.FocusedRowHandle;
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (isNewRow)
            {
                isNewRow = false;
                gridView1.DeleteSelectedRows();
            }
            else
            {
                if (MessageBox.Show("Ban co muon xoa Huan Luyen Vien nay?", "MessageBox", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (row["CoachID"].ToString().Equals(""))
                    {
                        return;
                    }
                    else
                    {
                        try
                        {
                            if (_busCoach.deleteData(row["CoachID"].ToString().Trim()) != 0)
                            {
                                MessageBox.Show("Xoa thanh cong!");
                                LoadCoach();
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
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isNewRow)
            {
                isUpdate = true;
                rowUpdate = e.RowHandle;
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

    }
}
