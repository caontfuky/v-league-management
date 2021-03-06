﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace PresentationLayer
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            mainPanel.Dock = DockStyle.Fill;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();
            ucRule_Season ucDieuLe = new ucRule_Season();
            ucDieuLe.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(ucDieuLe);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            ////frmConnectionSQL connect = new frmConnectionSQL();
            //connect.Show();
        }

        private void bntListTeam_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();
            ucListTeamDemo listTeamDemo = new ucListTeamDemo();
            listTeamDemo.BorderStyle = BorderStyle.None;
            listTeamDemo.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(listTeamDemo);

        }

        //bnt tra cuu
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();

            //ucTeamDetail uc = new ucTeamDetail();
            //uc.Dock = DockStyle.Fill;
            //mainPanel.Controls.Add(uc);

            //ucSeason season = new ucSeason();
            //season.Dock = DockStyle.Fill;
            //mainPanel.Controls.Add(season);

            //ucCoach coach = new ucCoach();
            //coach.Dock = DockStyle.Fill;
            //mainPanel.Controls.Add(coach);

            //ucStadium stadium = new ucStadium();
            //stadium.Dock = DockStyle.Fill;
            //mainPanel.Controls.Add(stadium);

            //ucPlayer player = new ucPlayer();
            //player.Dock = DockStyle.Fill;
            //mainPanel.Controls.Add(player);

            //ucPosition position = new ucPosition();
            //position.Dock = DockStyle.Fill;
            //mainPanel.Controls.Add(position);

            ucNational national = new ucNational();
            national.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(national);
            //UserControl1 ListTeam = new UserControl1();
            //ListTeam.Dock = DockStyle.Fill;
            //mainPanel.Controls.Add(ListTeam);
        }

        private void bntFixture_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();

            ucFixtures fixture = new ucFixtures();
            fixture.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(fixture);
        }

        private void bntReferee_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();

            ucListReferee ListReferee = new ucListReferee();
            ListReferee.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(ListReferee);
        }

        private void bntResult_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();

            ucResult result = new ucResult();
            result.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(result);
        }

        private void bntPublic_ItemClick(object sender, ItemClickEventArgs e)
        {
            //mainPanel.Controls.Clear();

            //ucTeamDetail result = new ucTeamDetail();
            //result.Dock = DockStyle.Fill;
            //mainPanel.Controls.Add(result);
        }

        private void bntStanding_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();

            ucStanding standing = new ucStanding();
            standing.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(standing);
        }
    }
}