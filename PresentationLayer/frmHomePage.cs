using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraSplashScreen;

namespace PresentationLayer
{
    public partial class frmHomePage : DevExpress.XtraEditors.XtraForm
    {
        public frmHomePage()
        {
            SplashScreenManager.ShowForm(typeof(frmWaiting));
            InitializeComponent();
            this.CustomWindowUIButton();
            drBtnClose.DropDownControl = ppMenu;
            SplashScreenManager.CloseForm();
        }

        public void CustomWindowUIButton()
        {
            //BaseButton bases = (BaseButton)this.windowsUIButtonPanel1.Buttons[0];
            //bases.ClientSize = new Size(100, 100);
            //this.windowsUIButtonPanel1.Buttons[0].Properties.Appearance.ForeColor = Color.Chocolate;
        }



        private void drBtnClose_ShowDropDownControl(object sender, ShowDropDownControlEventArgs e)
        {
            //ppMenu.ShowPopup(Control.MousePosition);
        }

        private void picHome_Properties_MouseHover(object sender, EventArgs e)
        {
            PictureEdit pic = sender as PictureEdit;
            pic.Properties.ZoomPercent = 120;
        }

        private void picHome_Properties_MouseLeave(object sender, EventArgs e)
        {
            PictureEdit pic = sender as PictureEdit;
            pic.Properties.ZoomPercent = 70;
        }

        ucSeasonInfo seasonInfo = new ucSeasonInfo();
        private void picSeason_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaiting));
            //pnlDetail.Controls.Clear();
            seasonInfo.Dock = DockStyle.Fill;
            picBG.Visible = false;
            if(!pnlDetail.Controls.Contains(seasonInfo))
                pnlDetail.Controls.Add(seasonInfo);
            SplashScreenManager.CloseForm();
        }
    }
}