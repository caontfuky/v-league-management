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
using DevExpress.XtraEditors.Controls;

namespace PresentationLayer
{
    public partial class ucResult : DevExpress.XtraEditors.XtraUserControl
    {

        DTOSeason _dtoSeason = new DTOSeason();
        BUSSeason _busSeason = new BUSSeason();
        DTORound _dtoRound = new DTORound();

        string seasonName = "";
        string seasonID = "";
        string roundName = "";
        string roundID = "";
        DataTable dtSeason;
        DataTable dtRound;

        public ucResult()
        {
            InitializeComponent();
            //load tong tin season vao cbx
            LoadSeason();
        }

        public void LoadSeason()
        {
            ComboBoxItemCollection coll = cbxSeason.Properties.Items;
            coll.BeginUpdate();
            dtSeason = _busSeason.getAllData();
            for (int i = 0; i < dtSeason.Rows.Count; i++)
            {
                coll.Add((dtSeason.Rows[i]["SeasonName"]).ToString());
                if (i == dtSeason.Rows.Count - 1)
                {
                    seasonID = (dtSeason.Rows[i]["SeasonID"]).ToString();
                }
            }
            coll.EndUpdate();

            cbxSeason.SelectedIndex = coll.Count - 1;
            seasonName = cbxSeason.SelectedItem.ToString();
            labelSeason.Text = " " + seasonName;
        }

        public void LoadRound(string seasonN)
        {
            //load round dua tren season
        }

        public void LoadMatch(string seasonN, string roundN)
        {
            //load tran dau dua vao season vs Round neu da co trong csdl
        }

        private void cbxSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            //thay doi Result o day dua vao mua giai voi round chon

            for (int i = 0; i < dtSeason.Rows.Count; i++)
            {
                if ((dtSeason.Rows[i]["SeasonName"]).Equals(cbxSeason.SelectedItem.ToString()))
                {
                    seasonID = (dtSeason.Rows[i]["SeasonID"]).ToString();
                }
            }
            seasonName = cbxSeason.SelectedItem.ToString();
            labelSeason.Text = " " + seasonName;
        }

        private void cbxRound_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
