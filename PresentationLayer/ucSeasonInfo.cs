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
using DevExpress.Skins;
using DevExpress.XtraSplashScreen;

namespace PresentationLayer
{
    public partial class ucSeasonInfo : DevExpress.XtraEditors.XtraUserControl
    {
        private bool isUpdate = false;
        private bool isAdd = false;
        public ucSeasonInfo()
        {
            InitializeComponent();
            itemLinkEdit.Click += new EventHandler(itemLinkEdit_Click);
            grdListTeam.DataSource = (new BUSTeam().getAllData());

            //Khoi tao data
            this.initData();
        }

        public void initData()
        {
            grdListSeason.DataSource = new BUSSeason().getAllData();
            DataRowView rowFocused = grdvListSeason.GetFocusedRow() as DataRowView;
            if (rowFocused != null)
            {
                string seasonID = rowFocused["SeasonID"].ToString();
                txtSeasonName.Text =  rowFocused["SeasonName"].ToString();
                dateStartDate.EditValue = rowFocused["StartDate"];
                dateEndDate.EditValue = rowFocused["EndDate"];
                txtSponsor.Text = rowFocused["Sponsor"].ToString();
                spinExpenditure.Text = rowFocused["Expenditure"].ToString().Trim();
                grdListTeam.DataSource = new BUSTeam().getAllTeamValueBySeasonID(seasonID);
            }
        }
        void itemLinkEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asd");
        }

        private void ucSeasonInfo_Load(object sender, EventArgs e)
        {
            Skin skin_ = TabSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);
            SkinElement element = skin_[TabSkins.SkinTabHeader];
            element.ContentMargins.Top = 10;
            element.ContentMargins.Bottom = 10;
            tabHome.LayoutChanged();
        }

        private void bbtnAddSeason_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtSeasonName.Text = null;
            dateStartDate.EditValue = null;
            dateEndDate.EditValue = null;
            txtSponsor.Text = null;
            spinExpenditure.Value = 0;
            //
            this.bbtnAddSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbtnUpdateSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbtnDeleteSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.isAdd = true;
            this.isUpdate = false;
            //
            this.grdListTeam.DataSource = null;
        }

        private void bbtnDeleteSeason_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa dữ liệu hay không?", "Thông báo", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(frmWaiting));
                DataRowView rowFocused = grdvListSeason.GetFocusedRow() as DataRowView;
                string seasonID = null;
                if (rowFocused != null)
                {
                    seasonID = rowFocused["SeasonID"].ToString();
                    if (new BUSSeason().deleteData(seasonID) > 0)
                    {
                        this.initData();
                        XtraMessageBox.Show("Xóa dữ liệu thành công");
                    }
                    else
                    {
                        XtraMessageBox.Show("Dữ liệu đã sử dụng trong một số tác vụ, không thể xóa");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa chọn dữ liệu để xóa, vui lòng kiểm tra lại");
                    return;
                }
                SplashScreenManager.CloseForm();
            }
        }

        private void bbtnUpdateSeason_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bbtnAddSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbtnUpdateSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbtnDeleteSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.isAdd = false;
            this.isUpdate = true;
        }

        private void bbtnCancelSeason_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bbtnAddSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.bbtnUpdateSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.bbtnDeleteSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            DataRowView rowFocused = grdvListSeason.GetFocusedRow() as DataRowView;
            if (rowFocused != null)
            {
                txtSeasonName.Text = rowFocused["SeasonName"].ToString();
                dateStartDate.EditValue = rowFocused["StartDate"];
                dateEndDate.EditValue = rowFocused["EndDate"];
                txtSponsor.Text = rowFocused["Sponsor"].ToString();
                spinExpenditure.Text = rowFocused["Expenditure"].ToString().Trim();
            }
            this.isAdd = false;
            this.isUpdate = false;
        }

        private void bbtnSaveSeason_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaiting));
            if (this.isUpdate || this.isAdd)
            {
                if (this.isAdd)
                {
                    DTOSeason dtoseason = new DTOSeason();
                    dtoseason.seasonID = "S0000";
                    dtoseason.seasonName = txtSeasonName.Text;
                    dtoseason.startDate = dateStartDate.DateTime;
                    dtoseason.endDate = dateEndDate.DateTime;
                    dtoseason.sponsor = txtSponsor.Text;
                    dtoseason.expenditure = (Int64)spinExpenditure.Value;

                    if (this.CheckSeasonInfo(dtoseason))
                    {
                        if (new BUSSeason().insertData(dtoseason) > 0)
                        {
                            XtraMessageBox.Show("Thêm dữ liệu thành công");
                        }
                        else
                        {
                            XtraMessageBox.Show("Thêm dữ liệu thất bại");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Dữ liệu chưa được thêm đầy đủ");
                    }
                }
                else
                {
                    DataRowView rowFocused = grdvListSeason.GetFocusedRow() as DataRowView;
                    string seasonID = null;
                    if (rowFocused != null)
                    {
                        seasonID = rowFocused["SeasonID"].ToString();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn dòng nào để chỉnh sửa!");
                        return;
                    }
                    //
                    DTOSeason dtoseason = new DTOSeason();
                    dtoseason.seasonID = seasonID;
                    dtoseason.seasonName = txtSeasonName.Text;
                    dtoseason.startDate = dateStartDate.DateTime;
                    dtoseason.endDate = dateEndDate.DateTime;
                    dtoseason.sponsor = txtSponsor.Text;
                    dtoseason.expenditure = (Int64)spinExpenditure.Value;
                    if (this.CheckSeasonInfo(dtoseason))
                    {
                        if (new BUSSeason().updateData(dtoseason) > 0)
                        {
                            XtraMessageBox.Show("Cập nhật dữ liệu thành công");
                        }
                        else
                        {
                            XtraMessageBox.Show("Cập nhật dữ liệu thất bại");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Dữ liệu chưa được thêm đầy đủ");
                    }
                }

                this.initData();
                //
                this.bbtnAddSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.bbtnUpdateSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.bbtnDeleteSeason.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //
                this.isAdd = false;
                this.isUpdate = false;
            }
            SplashScreenManager.CloseForm();
        }

        private bool CheckSeasonInfo(DTOSeason dtoSeason)
        {
            if (/*string.IsNullOrEmpty(dtoSeason.seasonID)
                &&*/ !string.IsNullOrWhiteSpace(dtoSeason.seasonID)
                && !string.IsNullOrEmpty(dtoSeason.seasonName)
                && !string.IsNullOrWhiteSpace(dtoSeason.seasonName)
                && (dtoSeason.startDate != null)
                && (dtoSeason.endDate != null)
                && (dtoSeason.expenditure > 0)
                )
                return true;
            return false;
        }

        private void grdvListSeason_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRowView rowFocused = grdvListSeason.GetFocusedRow() as DataRowView;
            if (rowFocused != null)
            {
                string seasonID = rowFocused["SeasonID"].ToString();
                txtSeasonName.Text = rowFocused["SeasonName"].ToString();
                dateStartDate.EditValue = rowFocused["StartDate"];
                dateEndDate.EditValue = rowFocused["EndDate"];
                txtSponsor.Text = rowFocused["Sponsor"].ToString();
                spinExpenditure.Text = rowFocused["Expenditure"].ToString().Trim();
                grdListTeam.DataSource = new BUSTeam().getAllTeamValueBySeasonID(seasonID);
            }
        }

        private void bbtnAddTeam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView rowFocused = grdvListSeason.GetFocusedRow() as DataRowView;
            if (rowFocused != null)
            {
                string seasonID = rowFocused["SeasonID"].ToString();
                frmChoseTeam.getInstance().seasonID = seasonID.Trim();
                frmChoseTeam.getInstance().initData();
                frmChoseTeam.getInstance().ShowDialog();
                //
                if (frmChoseTeam.getInstance().listTeamID.Count != 0)
                {
                    SplashScreenManager.ShowForm(typeof(frmWaiting));
                    foreach(string teamID in frmChoseTeam.getInstance().listTeamID)
                    {
                        DTOStanding dtoStanding = new DTOStanding();
                        dtoStanding.seasonID = seasonID;
                        dtoStanding.teamID = teamID;
                        dtoStanding.totalMatch = 0;
                        dtoStanding.totalMatchWon = 0;
                        dtoStanding.totalMatchLost = 0;
                        dtoStanding.totalMatchDrawn = 0;
                        dtoStanding.goalsFor = 0;
                        dtoStanding.goalsAgainst = 0;
                        dtoStanding.goalsDisfference = 0;
                        dtoStanding.point = 0;

                        if (new BUSStanding().insertData(dtoStanding) <= 0)
                        {
                            XtraMessageBox.Show("Đội bóng đã tồn tại trong danh sách!");
                        }
                    }
                    SplashScreenManager.CloseForm();
                    frmChoseTeam.getInstance().listTeamID.Clear();
                }

                //
                grdListTeam.DataSource = new BUSTeam().getAllTeamValueBySeasonID(seasonID);
            }
        }

        private void bbtnDeletaTeam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView rowFocused = grdvListSeason.GetFocusedRow() as DataRowView;
            if (rowFocused != null)
            {
                string seasonID = rowFocused["SeasonID"].ToString();
                if (seasonID != null)
                {
                    DataRowView teamRowFocused = grdvListTeam.GetFocusedRow() as DataRowView;
                    if (rowFocused != null)
                    {
                        string teamID = teamRowFocused["TeamID"].ToString();
                        SplashScreenManager.ShowForm(typeof(frmWaiting));
                        if (new BUSStanding().deleteData(seasonID, teamID) > 0)
                        {
                            XtraMessageBox.Show("Xóa đội bóng thành công");
                            grdListTeam.DataSource = new BUSTeam().getAllTeamValueBySeasonID(seasonID);
                            SplashScreenManager.CloseForm();
                        }
                        else
                        {
                            XtraMessageBox.Show("Xóa đội bóng thất bại");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Không có đội bóng nào được chọn");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa chọn mùa giải");
                }
            }

        }
    }
}
