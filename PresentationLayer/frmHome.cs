using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors.ColorWheel;

namespace PresentationLayer
{
    public partial class frmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmHome()
        {
            InitializeComponent();

            //Thay doi giao dien
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Corbel", 10);
            BarLocalizer.Active = new MyBarLocalizer();
            SkinHelper.InitSkinGallery(this.skinRibbonGalleryBarItem, true);
            //SkinHelper.InitSkinPopupMenu();
        }

        private void changeFont(object sender, ItemClickEventArgs e)
        {
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font(bitemFont.EditValue.ToString(), 10);
        }

        private void bbtnColorMixer_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (ColorWheelForm showColorMixer = new ColorWheelForm())
            {
                showColorMixer.ShowDialog(this);
            }
        }

    }

    public class MyBarLocalizer : BarLocalizer
    {
        public override string GetLocalizedString(BarString id)
        {
            if (id == BarString.SkinCaptions)
            {
                //Default value for BarString.SkinCaptions:
                //"|DevExpress Style|Caramel|Money Twins|DevExpress Dark Style|iMaginary|Lilian|Black|Blue|Office 2010 Blue|Office 2010 Black|Office 2010 Silver|Office 2007 Blue|Office 2007 Black|Office 2007 Silver|Office 2007 Green|Office 2007 Pink|Seven|Seven Classic|Darkroom|McSkin|Sharp|Sharp Plus|Foggy|Dark Side|Xmas (Blue)|Springtime|Summer|Pumpkin|Valentine|Stardust|Coffee|Glass Oceans|High Contrast|Liquid Sky|London Liquid Sky|The Asphalt World|Blueprint|"
                string defaultSkinCaptions = base.GetLocalizedString(id);
                string newSkinCaptions = defaultSkinCaptions.Replace("|DevExpress Style|", "Caramel|Money Twins|DevExpress Dark Style|iMaginary|Lilian|Black|Blue|Office 2010 Blue|Office 2010 Black|Office 2010 Silver|Office 2007 Blue|Office 2007 Black|Office 2007 Silver|Office 2007 Green|Office 2007 Pink|Seven|Seven Classic|Darkroom|McSkin|Sharp|Sharp Plus|Foggy|Dark Side|Xmas (Blue)|Springtime|Summer|Pumpkin|Valentine|Stardust|Coffee|Glass Oceans|High Contrast|Liquid Sky|London Liquid Sky|The Asphalt World|Blueprint|");
                return newSkinCaptions;
            }
            return base.GetLocalizedString(id);
        }
    }
}