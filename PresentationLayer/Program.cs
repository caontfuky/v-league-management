using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinnessLogicLayer;

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
            //sang test
            //BUSCardType cardtype = new BUSCardType();
            //int count = cardtype.updateData(new DataTransferObject.DTOCardType("C0001", "The xanh"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
