using System;
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
            ucRule ucDieuLe = new ucRule();
            ucDieuLe.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(ucDieuLe);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmConnectionSQL connect = new frmConnectionSQL();
            connect.Show();
        }

        private void bntListTeam_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();

            mainPanel.Dock = DockStyle.Fill;
            ucListTeam ListTeam = new ucListTeam();
  //          mainPanel.Controls.Clear();
            mainPanel.Controls.Add(ListTeam);
            ListTeam.Dock = DockStyle.Fill;

 //           ListTeam.Show();

        }
    }
}