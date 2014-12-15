using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataTransferObject;
using BusinnessLogicLayer;
using System.IO;
using System.Drawing.Imaging;

namespace PresentationLayer
{
    public partial class frmTeamDetail : DevExpress.XtraEditors.XtraForm
    {
        public byte[] logo_byte;


        public frmTeamDetail()
        {
            InitializeComponent();
        }

        private void frmTeamDetail_Load(object sender, EventArgs e)
        {

        }

        private void Logo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bntAddInfo_Click(object sender, EventArgs e)
        {
            DTOTeam _dtoTeam = new DTOTeam();
            BUSTeam _busTeam = new BUSTeam();

            _dtoTeam.name = txtName.Text.Trim();
            _dtoTeam.logo = logo_byte;
            _dtoTeam.address = txtAddress.Text.Trim();
            _dtoTeam.chairman = txtChairman.Text.Trim();
            _dtoTeam.cEO = txtCEO.Text.Trim();
            _dtoTeam.email = txtEmail.Text.Trim();
            _dtoTeam.fax = txtFax.Text.Trim();
            _dtoTeam.stadiumID = "ST0001";
            _dtoTeam.phoneNumber = txtTel.Text.Trim();
            _dtoTeam.teamID = "T00001";
            _dtoTeam.establishedYear = txtYear.Text.Trim();

            if (_busTeam.insertTeam(_dtoTeam) > 0)
            {
                MessageBox.Show("Them Thanh cong");
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string url = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(url))
                return;

            Image ima = Image.FromFile(openFileDialog1.FileName);
            MemoryStream stream = new MemoryStream();
            if (ima != null)
            {
                Logo.Image = ima;
                ima.Save(stream, ImageFormat.Jpeg);
                logo_byte = stream.ToArray();
            }
        }

    }
}