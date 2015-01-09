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

            DataTable listTeam = new BUSTeam().getAllData();
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
            grdFixture.DataSource = FixtureAutoCreates.Instance.GetValue(listTeamInfo, "");
        }
    }
}
