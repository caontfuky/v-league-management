using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PresentationLayer
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private string user = "hung";
        private string password = "hung";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            //if (user.Equals(txtName.Text.Trim()) && password.Equals(txtPassword.Text.Trim()))
            //{
            this.Hide();
            //frmHomePage mainForm = new frmHomePage();
            //mainForm.FormBorderStyle = FormBorderStyle.None;
            // mainForm.WindowState = FormWindowState.Maximized;
            //mainForm.Show();

            //}
            //else
            //{
            //    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác, vui lòng xem lại thông tin!");
            //}
        }
    }
}