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
using DevExpress.Skins;

namespace PresentationLayer
{
    public partial class ucSeasonInfo : DevExpress.XtraEditors.XtraUserControl
    {
        public ucSeasonInfo()
        {
            InitializeComponent();
            itemLinkEdit.Click += new EventHandler(itemLinkEdit_Click);
            gridControl1.DataSource = (new BUSTeam().getAllData());
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

    }
}
