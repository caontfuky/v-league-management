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
        bool isNewRow = false;
        bool isUpdate = false;
        bool isMessage = false;
        int rowUpdate = -1;

        public ucPosition()
        {
            InitializeComponent();
            this.Load += ucPosition_Load;
        }

        void ucPosition_Load(object sender, EventArgs e)
        {
            LoadPosition();
            gridView1.CellValueChanged += gridView1_CellValueChanged;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
        }

        void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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

        void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!isNewRow)
            {
                isUpdate = true;
                rowUpdate = e.RowHandle;
            }
        }

        public void LoadPosition()
        {
            dtPosition = _busPosition.getAllData();
            pOSITIONGridControl.DataSource = dtPosition;
        }

        private void InsertUpdate(DataRow row)
        {
            try
            {
                string positionID = row["PositionID"].ToString().Trim();
                string positionName = row["PositionName"].ToString();

                if (positionName.Equals(""))
                {
                    isMessage = true;
                    gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                    isMessage = false;
                    MessageBox.Show("Chua dien du thong tin!");
                    return;
                }
                else
                {
                    _dtoPosition.positionID = "P0";
                    _dtoPosition.positionName = positionName.Trim();
                    try
                    {
                        if (isNewRow)
                        {
                            if (_busPosition.insertData(_dtoPosition) != 0)
                            {
                                MessageBox.Show("Them thanh cong!");
                                isNewRow = false;
                                isMessage = false;
                                LoadPosition();
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
                            _dtoPosition.positionID = positionID;
                            if (_busPosition.updateData(_dtoPosition) != 0)
                            {
                                MessageBox.Show("Sua thanh cong!");
                                isUpdate = false;
                                LoadPosition();
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
                if (MessageBox.Show("Ban co muon xoa Vi Tri nay?", "MessageBox", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (row["PositionID"].ToString().Equals(""))
                    {
                        return;
                    }
                    else
                    {
                        try
                        {
                            if (_busPosition.deleteData(row["PositionID"].ToString().Trim()) != 0)
                            {
                                MessageBox.Show("Xoa thanh cong!");
                                LoadPosition();
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

        private void bnt_InsertUpdate_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (isUpdate || isNewRow)
            {
                System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                InsertUpdate(row);
            }
        }
    }
}
