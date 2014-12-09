using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Wmi;
using Microsoft.Win32;
using System.IO;
using DevExpress.XtraEditors;
using PresentationLayer.Config;

namespace PresentationLayer
{
    public partial class frmConnectionSQL : Form
    {

        private SqlConnection m_conn = new SqlConnection();
        public frmConnectionSQL()
        {
            InitializeComponent();
            getSeverConnection();
            //cmbAuthorities.SelectedIndex = 0;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void cmbAuthorities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthorities.SelectedIndex == 0)
            {
                txtPass.Enabled = false;
                txtUserName.Enabled = false;
                txtData.Enabled = true;
            }
            else
            {
                txtPass.Enabled = true;
                txtUserName.Enabled = true;
                txtData.Enabled = true;
            }
        }
        public bool getSeverConnection()
        {
            ////Start service when it was not running
            ManagedComputer managerCmp = new ManagedComputer();
            /*
            // Service service = default(Service);
            foreach (Service service in managerCmp.Services)
            {
                if (service.ServiceState != ServiceState.Running)
                {
                    if (service.ServiceState == ServiceState.Paused)
                    {
                        service.Resume();
                    }
                    else
                    {
                        service.Start();
                    }
                    service.Refresh();
                }

            }*/
            //Get Instance of Sqlsever
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        //if (instanceName.ToLower() == "SQLEXPRESS".ToLower())
                        //{
                        //    object temp = Environment.MachineName + @"\" + instanceName;
                        //    cmbServerName.Properties.Items.Add(temp);
                        //}
                        //else
                        //{
                            object temp = Environment.MachineName;
                            cmbServerName.Properties.Items.Add(temp);
                        //}
                    }
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Microsoft SQL server chưa được cài đặt trên máy của bạn!\nXin vui cài đặt và thử lại!");
                    return false;
                }
                //else
                //{
                //    foreach (ServerInstance sever in managerCmp.ServerInstances)
                //    {
                //        object temp = managerCmp.Name + @"\" + sever.Name;
                //        cmbServerName.Properties.Items.Add(temp);
                //    }
                //    return true;
                //}
            }

        }
        public void setConnectionString()
        {
            if (cmbAuthorities.SelectedIndex == 0)
            {
                m_conn = new SqlConnection("Data Source=" + cmbServerName.Text + ";Initial Catalog=master;Integrated Security=True;");
            }
            else if (cmbAuthorities.SelectedIndex == 1)
            {
                m_conn = new SqlConnection("Data Source=" + cmbServerName.Text + ";Initial Catalog=master;User Id=" + txtUserName.Text + ";Password=" + txtPass.Text + ";Pooling=False;");
            }
            else
                return;
        }
        private bool createNewDatabase(string DatabaseName)
        {
            setConnectionString();
            if (!checkExistOfDatabase(DatabaseName))
            {
                FileInfo _tableStructure = new FileInfo(Path.GetDirectoryName(Application.ExecutablePath) + "\\Database\\v-league-management.sql");
                //FileInfo _storedProcdure = new FileInfo(Path.GetDirectoryName(Application.ExecutablePath) + "\\Database\\StoredProcdure.sql");
                //FileInfo _viewStructure = new FileInfo(Path.GetDirectoryName(Application.ExecutablePath) + "\\Database\\ViewStructure.sql");
                //Get value of fileInfo 
                String _tableStructureValue = _tableStructure.OpenText().ReadToEnd();
                //String _storedProcdureValue = _storedProcdure.OpenText().ReadToEnd();
                //String _viewStructureValue = _viewStructure.OpenText().ReadToEnd();
                //Close open file
                _tableStructure.OpenText().Close();
                //_storedProcdure.OpenText().Close();
                //_viewStructure.OpenText().Close();
                //
                if (executeSql(_tableStructureValue, DatabaseName, true))
                {
                  //  executeSql(_storedProcdureValue, DatabaseName, false);
                  //  executeSql(_viewStructureValue, DatabaseName, false);
                    return true;
                }
                else
                {
                    return false;
                }
                //
            }
            else
            {
                DialogResult _result = XtraMessageBox.Show("Tên cơ sở dữ liệu đã tồn tại!\nBạn có muốn sử dụng nó hay không?", "Thông báo", MessageBoxButtons.YesNo);
                if (_result == DialogResult.Yes)
                {
                    return true;
                }
                return false;
            }

        }
        public bool checkExistOfDatabase(string dataBaseNameToPrepend)
        {
            Server server = new Server(new ServerConnection(m_conn));
            if (server.Databases.Contains(dataBaseNameToPrepend))
            {
                return true;
            }
            else
                return false;
        }
        public bool executeSql(string sql, string dataBaseNameToPrepend, bool alowCreatNewDataBase)
        {
            try
            {
                //using (m_conn)
                //{
                    
                Server server = new Server(new ServerConnection(m_conn));
                if(alowCreatNewDataBase)
                    server.ConnectionContext.ExecuteNonQuery("Create Database " + dataBaseNameToPrepend);
                server.ConnectionContext.ExecuteNonQuery("Use [" + dataBaseNameToPrepend + "]");
                server.ConnectionContext.ExecuteNonQuery(sql);
                server.ConnectionContext.Disconnect();
                return true;
                //}
            }
            catch (SqlException)
            {
                return false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (createNewDatabase(txtData.Text))
            {
                if (cmbAuthorities.SelectedIndex == 0)
                    GetSetConnectString.setConnectString("Connection.xml", 
                                                        cmbServerName.Text, 
                                                        txtData.Text, 
                                                        "true");
                else
                    GetSetConnectString.setConnectString("Connection.xml",
                                                        cmbServerName.Text,
                                                        txtData.Text,
                                                        txtUserName.Text,
                                                        txtPass.Text,
                                                        "false");
                this.Dispose();
                this.Close();

            }
            else
            {
                XtraMessageBox.Show("Tạo mới cơ sỡ dữ liệu thất bại !");
                cmbAuthorities.Text = null;
                cmbServerName.Text = null;
                txtData.Text = null;
                txtPass.Text = null;
                txtUserName.Text = null;
                cmbServerName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
