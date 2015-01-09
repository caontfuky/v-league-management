using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PresentationLayer.Global;
using BusinnessLogicLayer;
using DataTransferObject;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;

namespace PresentationLayer
{
    public partial class ucFixtureCreates : DevExpress.XtraEditors.XtraUserControl
    {
        public ucFixtureCreates()
        {
            InitializeComponent();
            grdListTeam.DataSource = new BUSTeam().getAllData();

            //Load Season value
            lkSeason.Properties.DataSource = new BUSSeason().getAllData();
            DataTable data = new BUSRefereee().getAllData();
            lkReferee1.DataSource = data;

        }

        private void showData(string seasonID)
        {
            NestedRecords fixture = new NestedRecords();
            DataTable dataRound = new BUSRound().getAllRoundValueBySeasonID(seasonID);
            if (dataRound != null)
            {
                string roundID = "";
                foreach (DataRow row in dataRound.Rows)
                {
                    roundID = row["RoundID"].ToString().Trim();
                    RoundRecord roundRecord = new RoundRecord();
                    RoundValueRecord roundValue = new RoundValueRecord();
                    roundRecord.ID = row["RoundID"].ToString();
                    roundRecord.Name = row["RoundName"].ToString();
                    DataTable dataMatch = new BUSMatch().getAllDataValue(seasonID, roundID);
                    if (dataMatch != null)
                    {
                        foreach (DataRow rowMatch in dataMatch.Rows)
                        {
                            ChildRecordMatch matchValue = new ChildRecordMatch();
                            matchValue.MatchID = rowMatch["MatchID"].ToString();
                            matchValue.HomeTeam = rowMatch["HomeTeamName"].ToString();
                            matchValue.StartTime = rowMatch["StartTime"].ToString();
                            matchValue.StartDate = rowMatch["StartDate"].ToString();
                            matchValue.Stadium = rowMatch["StadiumName"].ToString();
                            matchValue.Referee = rowMatch["RefereeName"].ToString();
                            matchValue.Score = rowMatch["Score"].ToString();
                            matchValue.VisitingTeam = rowMatch["VisitingTeamName"].ToString();
                            
                            roundValue.Add(matchValue);
                        }
                    }
                    roundRecord.Match = roundValue;
                    fixture.Add(roundRecord);
                }
            }
            grdFixture.DataSource = fixture;
        }

        private void grdvMatch_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            GridView view = sender as GridView;
            MessageBox.Show(e.RowHandle.ToString() + "- parent" + view.GetParentRowHandle(e.RowHandle));
            //grdvMatch.GetRowCellValue(e.RowHandle, 2);
        }

        private void grdvMatch_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView view = sender as GridView;
            view.GetParentRowHandle(e.RowHandle);
            Object row = view.GetRow(0);
            if (row is ChildRecordMatch)
            {
                ChildRecordMatch match = row as ChildRecordMatch;

            }

            //view.GetDataRow(e.RowHandle).GetParentRow( ;
        }

        private void grdvRound_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            MessageBox.Show(e.RowHandle.ToString());
        }

        private void tedtTimeStart_EditValueChanged(object sender, EventArgs e)
        {
            TimeEdit time = sender as TimeEdit;
            grdvMatch.CloseEditor();
            grdvMatch.UpdateCurrentRow();
        }

        private void bbtnAutoCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lkReferee.DataSource = new BUSRefereee().getDataBySeason("Eximbank 2013");
            if (lkSeason.EditValue != null)
            {
                string seasonID = lkSeason.EditValue.ToString().Trim();
                DataTable listTeam = this.grdListTeam.DataSource as DataTable;
                List<TeamInfo> listTeamInfo = new List<TeamInfo>();
                for (int i = 0; i < listTeam.Rows.Count; i++)
                {
                    TeamInfo team = new TeamInfo();
                    team.teamName = listTeam.Rows[i]["Name"].ToString();
                    team.teamID = listTeam.Rows[i]["TeamID"].ToString();
                    team.stadiumID = listTeam.Rows[i]["StadiumID"].ToString();
                    team.stadiumName = new BUSStadium().getStadiumNameByID(team.stadiumID);
                    listTeamInfo.Add(team);
                }
                FixtureAutoCreates.Instance.AddFixtureToDatabase(listTeamInfo, seasonID);

                //Load du lieu len lai
                this.grdListRound.DataSource = new BUSRound().getAllRoundValueBySeasonID(seasonID);
                //grdFixture.DataSource = FixtureAutoCreates.Instance.GetValue(listTeamInfo, "");
            }

        }

        private void lkSeason_EditValueChanged(object sender, EventArgs e)
        {
            if (lkSeason.EditValue != null)
            {
                SplashScreenManager.ShowForm(typeof(frmWaiting));
                string seasonID = lkSeason.EditValue.ToString();
                this.grdListTeam.DataSource = new BUSTeam().getAllTeamValueBySeasonID(seasonID);
                this.grdListRound.DataSource = new BUSRound().getAllRoundValueBySeasonID(seasonID);
                DataRowView rowFocused = grdvListRound.GetFocusedRow() as DataRowView;
                if (rowFocused != null)
                {
                    string roundID = rowFocused["RoundID"].ToString().Trim();
                    this.grdListMatch.DataSource = new BUSMatch().getAllDataValue(seasonID, roundID);
                }
                else
                {
                    this.grdListMatch.DataSource = null;
                }
                this.showData(seasonID);
                SplashScreenManager.CloseForm();
            }
        }

        private void grdvListRound_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRowView rowFocused = grdvListRound.GetFocusedRow() as DataRowView;
            if (rowFocused != null)
            {
                string roundID = rowFocused["RoundID"].ToString().Trim();
                string seasonID = rowFocused["SeasonID"].ToString().Trim();
                this.grdListMatch.DataSource = new BUSMatch().getAllDataValue(seasonID, roundID);
            }
        }

        private void bbtnSaveMatchInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable data = this.grdListMatch.DataSource as DataTable;
            if (data != null)
            {
                foreach (DataRow row in data.Rows)
                {
                    DTOMatch dtoMatch = new DTOMatch();
                    dtoMatch.matchID = row["MatchID"].ToString();
                    dtoMatch.homeTeam = row["HomeTeam"].ToString();
                    dtoMatch.visitingTeam = row["VisitingTeam"].ToString();
                    dtoMatch.stadiumID = row["StadiumID"].ToString();
                    dtoMatch.startDate = row["StartDate"].ToString();
                    dtoMatch.startTime = row["StartTime"].ToString();
                    dtoMatch.refereeID = row["RefereeID"].ToString();
                    dtoMatch.roundID = row["RoundID"].ToString();
                    dtoMatch.score = "-:-";
                    if (new BUSMatch().updateData(dtoMatch) <= 0)
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thất bại");
                    }
                }
            }
        }


        private void grdvListMatch_ShownEditor(object sender, EventArgs e)
        {
        }

        private void grdvListMatch_HiddenEditor(object sender, EventArgs e)
        {
        }

        private void lkReferee1_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = grdvListMatch;
            //view.SetRowCellValue(view.FocusedRowHandle, "RefereeName", DBNull.Value);
        }
    }
}
