using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PresentationLayer
{
    public partial class frmChoseTeam : DevExpress.XtraEditors.XtraForm
    {
        public static frmChoseTeam instance = null;

        public frmChoseTeam()
        {
            InitializeComponent();
        }

        public static frmChoseTeam getInstance()
        {
            if (instance == null)
                instance = new frmChoseTeam();
            return instance;
        }

        public void initData()
        {
            if (seasonID != null)
            {
                this.grdListTeamInfo.DataSource = new BusinnessLogicLayer.BUSTeam().getAllTeamValueNotInSeason(seasonID);
                seasonID = null;
            }
        }

        public string seasonID = null;

        private void bbtnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }


        public List<string> listTeamID = new List<string>();
        private void bbtnChoseTeam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (listTeamID.Count > 0)
            {
                listTeamID.Clear();
            }
                
            int[] rowsIndex = grdvListTeamInfo.GetSelectedRows();
            for (int i = 0; i < rowsIndex.Length; ++i)
            {
                object teamID = grdvListTeamInfo.GetRowCellValue(rowsIndex[i], "TeamID");
                if (teamID != null)
                    listTeamID.Add(teamID.ToString().Trim());
            }
            this.Hide();
        }
    }
}