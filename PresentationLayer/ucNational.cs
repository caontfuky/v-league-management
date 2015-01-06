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
        bool isNewRow = false;
        bool isUpdate = false;
        bool isMessage = false;
        int rowUpdate = -1;

        public ucNational()
        {
            InitializeComponent();
            LoadNational();
        }

        private void ucNational_Load(object sender, EventArgs e)
        {
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            gridView1.KeyDown += gridView1_KeyDown;
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

        void gridView1_KeyDown(object sender, KeyEventArgs e)
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

        private void InsertUpdate(DataRow row)
        {
            try
            {
                string nationalID = row["NationalID"].ToString().Trim();
                string nationalName = row["NationalName"].ToString();

                if (nationalName.Equals(""))
                {
                    isMessage = true;
                    gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                    isMessage = false;
                    MessageBox.Show("Chua dien du thong tin!");
                    return;
                }
                else
                {
                    _dtoNational.nationalID = "N0";
                    _dtoNational.nationalName = nationalName.Trim();
                    try
                    {
                        if (isNewRow)
                        {
                            if (_busNational.insertData(_dtoNational) != 0)
                            {
                                MessageBox.Show("Them thanh cong!");
                                isNewRow = false;
                                isMessage = false;
                                LoadNational();
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
                            _dtoNational.nationalID = nationalID;
                            if (_busNational.updateData(_dtoNational) != 0)
                            {
                                MessageBox.Show("Sua thanh cong!");
                                isUpdate = false;
                                LoadNational();
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
                return ;
            }
        }

        public void LoadNational()
        {
            dtNational = _busNational.getAllData();
            nATIONALGridControl.DataSource = dtNational;
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
                if (MessageBox.Show("Ban co muon xoa Quoc gia nay?", "MessageBox", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (row["NationalID"].ToString().Equals(""))
                    {
                        return;
                    }
                    else
                    {
                        try
                        {
                            if (_busNational.deleteData(row["NationalID"].ToString().Trim()) != 0)
                            {
                                MessageBox.Show("Xoa thanh cong!");
                                LoadNational();
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
    }
}
