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
using System.IO;

namespace PresentationLayer
{
    public partial class ucListTeamDemo : DevExpress.XtraEditors.XtraUserControl
    {
        public ucListTeamDemo()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

        }

        //se dua vao mua giai de load doi bong len
        private void ucListTeamDemo_Load(object sender, EventArgs e)
        {
            BUSTeam _busTeam = new BUSTeam();
            //dataGridView1.DataSource = t.getAllData();
            DataTable dt = _busTeam.getAllData();
            string teamName = "";
            byte[] logo;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                teamName = (dt.Rows[i]["Name"]).ToString();
                logo = (byte[])(dt.Rows[i]["Logo"]);
                MemoryStream memory = new MemoryStream(logo);
                AddTtem(Image.FromStream(memory), teamName);
            }
        }

        public void AddTtem(Image i, string teamName)
        {

            TileItem newTile = new TileItem();
            //First Frame - Image only
            TileItemFrame logoDXFrame = new TileItemFrame();
            TileItemElement logoEl = new TileItemElement();
            logoEl.Image = i;                                                                       //dien logo doi bong
            logoEl.ImageScaleMode = TileItemImageScaleMode.Stretch;
            logoDXFrame.Elements.Add(logoEl);
            logoDXFrame.Elements[0].AnimateTransition = DevExpress.Utils.DefaultBoolean.True;
            //Second Frame - Text only
            TileItemFrame mottoDXFrame = new TileItemFrame();
            TileItemElement mottoEl = new TileItemElement();
            mottoEl.Text = "<Size=+2><Color=Sienna><b>" + teamName + "</b></Color></Size>"; //dien ten doi bong
            mottoEl.TextAlignment = TileItemContentAlignment.MiddleCenter;
            mottoDXFrame.Elements.Add(mottoEl);
            mottoDXFrame.Elements[0].AnimateTransition = DevExpress.Utils.DefaultBoolean.True;
            //Global Tile Item Settings
            newTile.Frames.Add(logoDXFrame);
            newTile.Frames.Add(mottoDXFrame);
            newTile.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            //newTile.Appearance.BackColor2 = System.Drawing.Color.SandyBrown;
            newTile.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            newTile.Appearance.BorderColor = System.Drawing.Color.Bisque;
            //newTile.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            newTile.FrameAnimationInterval = 2500;
            newTile.ItemSize = TileItemSize.Medium;
            tileControl1.Groups.Add(new TileGroup());
            tileControl1.Groups[0].Items.Add(newTile);
            newTile.StartAnimation();
        }

        private void bntAddTeam_Click(object sender, EventArgs e)
        {
            //load ucTeamDetail dua vao mua giai chon tren this.form
            frmTeamDetail TeamDetail = new frmTeamDetail();
            TeamDetail.Show();
        }
    }
}
