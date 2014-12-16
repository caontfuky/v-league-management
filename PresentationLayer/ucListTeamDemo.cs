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
using DevExpress.XtraEditors.Controls;

namespace PresentationLayer
{
    public partial class ucListTeamDemo : DevExpress.XtraEditors.XtraUserControl
    {


        DTOSeason _dtoSeason = new DTOSeason();
        BUSSeason _busSeason = new BUSSeason();
        DTOTeam _dtoTeam = new DTOTeam();
        BUSTeam _busTeam = new BUSTeam();
        string seasonName = "";
        string seasonID = "";
        DataTable dtSeason;
        DataTable dtTeam;
        string itemName = "";

        public ucListTeamDemo()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

        }

        //se dua vao mua giai de load doi bong len
        private void ucListTeamDemo_Load(object sender, EventArgs e)
        {
            LoadSeason();
            LoadListTeam(seasonName);
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

        public void LoadListTeam(string _seasonName)
        {
            dtTeam = _busTeam.getTeamBySeasonName(_seasonName);
            string teamName = "";
            byte[] logo;
            tileControl1.Groups.Clear();
            for (int i = 0; i < dtTeam.Rows.Count; i++)
            {
                teamName = (dtTeam.Rows[i]["Name"]).ToString();
                logo = (byte[])(dtTeam.Rows[i]["Logo"]);
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
           // newTile.AppearanceItem.Pressed.BackColor = Color.Black;
            tileControl1.Groups.Add(new TileGroup());
            tileControl1.Groups[0].Items.Add(newTile);
            newTile.StartAnimation();
            newTile.Name = teamName;
            newTile.ItemClick += newTile_ItemClick;
            newTile.ItemDoubleClick += newTile_ItemDoubleClick;
        }

        void newTile_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            TileItem Tile = (TileItem)sender;
            frmTeamDetail teamDetail = new frmTeamDetail(seasonName, Tile.Name);
            teamDetail.Show();
        }

        void newTile_ItemClick(object sender, TileItemEventArgs e)
        {
            TileItem Tile = (TileItem)sender;
            //doi mau khi click
            Tile.AppearanceItem.Normal.BackColor = Color.Black;
            for (int i = 0; i < tileControl1.Groups[0].Items.Count; i++)
            {
                if (!(Tile.Name.Equals(tileControl1.Groups[0].Items[i].Name)))
                {
                    tileControl1.Groups[0].Items[i].AppearanceItem.Normal.BackColor = Color.White;
                }
            }
            itemName = Tile.Name;
        }

        private void bntAddTeam_Click(object sender, EventArgs e)
        {
            //load ucTeamDetail dua vao mua giai chon tren this.form
            frmTeamDetail TeamDetail = new frmTeamDetail();
            TeamDetail.Show();
        }

        private void cbxSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dtSeason.Rows.Count; i++)
            {
                if ((dtSeason.Rows[i]["SeasonName"]).Equals(cbxSeason.SelectedItem.ToString()))
                {
                    seasonID = (dtSeason.Rows[i]["SeasonID"]).ToString();
                }
            }
            seasonName = cbxSeason.SelectedItem.ToString();
            labelSeason.Text = " " + seasonName;

            //thay doi listTeam o day
            LoadListTeam(seasonName);
        }

        private void bntUpdateTeam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tileControl1.Groups[0].Items.Count; i++)
            {
                if (itemName.Equals(tileControl1.Groups[0].Items[i].Name))  // dung item dang chon
                {
                    frmTeamDetail teamDetail = new frmTeamDetail(seasonName, tileControl1.Groups[0].Items[i].Name);
                    teamDetail.Show();
                }
            }
        }
    }
}
