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

namespace PresentationLayer
{
    public partial class ucFixtureCreates : DevExpress.XtraEditors.XtraUserControl
    {
        public ucFixtureCreates()
        {
            InitializeComponent();
            DataTable listTeam = new BUSTeam().getAllData();
            List<DTOTeam> listTeamInfo = new List<DTOTeam>();
            for (int i = 0; i < listTeam.Rows.Count; i++)
            {
                DTOTeam team = new DTOTeam();
                team.name = listTeam.Rows[i]["Name"].ToString();
                listTeamInfo.Add(team);
            }
            grdFixture.DataSource = FixtureAutoCreates.Instance.GetValue(listTeamInfo);
            grdListTeam.DataSource = new BUSTeam().getAllData();
        }
    }
}
