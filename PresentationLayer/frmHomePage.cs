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

namespace PresentationLayer
{
    public partial class frmHomePage : DevExpress.XtraEditors.XtraForm
    {
        public frmHomePage()
        {
            InitializeComponent();
            this.CustomWindowUIButton();
            drBtnClose.DropDownControl = ppMenu;
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
    }
}