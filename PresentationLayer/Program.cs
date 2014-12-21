using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinnessLogicLayer;
using System.Drawing;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //sang test, cho nay la t demo day
            //BUSCardType cardtype = new BUSCardType();
            //int count = cardtype.updateData(new DataTransferObject.DTOCardType("C0001", "The xanh"));

            DevExpress.UserSkins.BonusSkins.Register();
            //DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.OfficeSkins).Assembly);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DarkSide";
            //DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Lucida Calligraphy", 10);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHomePage());
        }
    }
}
