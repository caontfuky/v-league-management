using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using DevExpress.XtraEditors;

namespace PresentationLayer.Config
{
    class DBConnection
    {
        #region "variable"
        protected SqlConnection m_conn;
        protected SqlCommand m_cmd;
        protected String m_connecstring;
        #endregion
        #region "method"
        public DBConnection()
        {
        }
        private bool getConnectionString()
        {
            XmlDocument xmlDoc = GetSetConnectString.getConnectString("Connection.xml");
            XmlElement xmlEle = xmlDoc.DocumentElement;

            try
            {
                CDatabase.m_DatabaseName    = xmlEle.SelectSingleNode("database").InnerText;
                CDatabase.m_ServerName      = xmlEle.SelectSingleNode("servname").InnerText;
                if (xmlEle.SelectSingleNode("authorities").InnerText == "true")
                {
                    m_connecstring = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";
                }
                else
                {
                    m_connecstring = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";User Id=" + xmlEle.SelectSingleNode("username").InnerText + ";Password=" + xmlEle.SelectSingleNode("password").InnerText + ";";
                }
                return true;
            }
            catch
            {   
                return false;
            }
        }
        public bool openConnection()
        {
            if (getConnectionString())
            {
                try
                {
                    if (m_conn == null)
                    {
                        m_conn = new SqlConnection(m_connecstring);
                    }
                    if (m_conn.State == ConnectionState.Closed)
                    {
                        m_conn.Open();
                    }
                    return true;
                }
                catch (SqlException)
                {
                    //DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString());
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
        public void closeConnection()
        {
            if (m_conn.State == ConnectionState.Open)
            {
                m_conn.Close();
            }
        }

        #endregion
    }
    public class CDatabase
    {
        public static String m_DatabaseName = "";
        public static String m_ServerName = "";
    }
}
