using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataTransferObject.Global
{
    public class GetSetConnectString : Singleton<GetSetConnectString>
    {
        
        #region "variable"
        public  XmlDocument m_xmlR;//Dung de doc file
        public  XmlTextWriter m_xmlW; //Dung de ghi file
        #endregion 
        #region "method"

        public GetSetConnectString()
        {
            m_xmlR = new XmlDocument();
            //m_xmlW = new XmlTextWriter();
        }

        /// <summary>
        /// Phuong thuc nay dung de doc chuoi ket noi tu file xml
        /// </summary>
        /// <param name="_fileName">Ten file truyen vao</param>
        /// <returns>XmlDocument</returns>
        public bool getConnectString(String _fileName)
        {
            try
            {
                m_xmlR = new XmlDocument();
                if (System.IO.File.Exists(_fileName))
                {
                    m_xmlR.Load(_fileName);
                    return true;
                }
                return false;
            }
            catch (XmlException)
            {
                //XtraMessageBox.Show("Can't read file");
                return false;
            }
        }

        /// <summary>
        /// Ham nay dung de cai dat chuoi ket noi, ghi chuoi ket noi vao file html
        /// </summary>
        /// <param name="_fileName">Duong dan luu file xuong local</param>
        /// <param name="_server">Ten server sql</param>
        /// <param name="_database">Ten database</param>
        /// <param name="_authorities">Quyen truy cap vao database</param>
        public void setConnectString(String _fileName, String _server, String _database, String _authorities)
        {
            m_xmlW = new XmlTextWriter(_fileName, null); // Khoi tao 
            m_xmlW.Formatting = Formatting.Indented;

            m_xmlW.WriteStartDocument();
            m_xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                    "Thong so co ban:\n\t" +
                                    "authorities = true : quyen Windows\n\t" +
                                    "authorities = false: quyen SQL Server\n\t" +
                                    "servname: ten server\n\t" +
                                    "username: ten dang nhap he thong\n\t" +
                                    "password: mat khau dang nhap he thong\n\t" +
                                    "database: ten co so du lieu\n");
            m_xmlW.WriteStartElement("config");
            m_xmlW.WriteStartElement("authorities");
            m_xmlW.WriteString(_authorities);
            m_xmlW.WriteEndElement();

            m_xmlW.WriteStartElement("servname");
            m_xmlW.WriteString(_server);
            m_xmlW.WriteEndElement();

            m_xmlW.WriteStartElement("username");
            m_xmlW.WriteString("");
            m_xmlW.WriteEndElement();

            m_xmlW.WriteStartElement("password");
            m_xmlW.WriteString("");
            m_xmlW.WriteEndElement();

            m_xmlW.WriteStartElement("database");
            m_xmlW.WriteString(_database);
            m_xmlW.WriteEndElement();

            m_xmlW.Close();
        }

        /// <summary>
        /// Ham nay dung de cai dat chuoi ket noi, luu chuoi ket noi xuong local
        /// </summary>
        /// <param name="_fileName">Duong dan luu file</param>
        /// <param name="_server">Ten server</param>
        /// <param name="_database">Ten database</param>
        /// <param name="_username">User name</param>
        /// <param name="_passwork">Pass word</param>
        /// <param name="_authorities">Quyen truy cap vao sql</param>
        public void setConnectString(String _fileName, String _server, String _database, String _username, String _passwork, String _authorities)
        {
            m_xmlW = new XmlTextWriter(_fileName, null);
            m_xmlW.Formatting = Formatting.Indented;

            m_xmlW.WriteStartDocument();
            m_xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                    "Thong so co ban:\n\t" +
                                    "authorities = true : quyen Windows\n\t" +
                                    "authorities = false: quyen SQL Server\n\t" +
                                    "servname: ten server\n\t" +
                                    "username: ten dang nhap he thong\n\t" +
                                    "password: mat khau dang nhap he thong\n\t" +
                                    "database: ten co so du lieu\n");
            m_xmlW.WriteStartElement("config");
            m_xmlW.WriteStartElement("authorities");
            m_xmlW.WriteString(_authorities);
            m_xmlW.WriteEndElement();

            m_xmlW.WriteStartElement("servname");
            m_xmlW.WriteString(_server);
            m_xmlW.WriteEndElement();

            m_xmlW.WriteStartElement("username");
            m_xmlW.WriteString(_username);
            m_xmlW.WriteEndElement();

            m_xmlW.WriteStartElement("password");
            m_xmlW.WriteString(_passwork);
            m_xmlW.WriteEndElement();

            m_xmlW.WriteStartElement("database");
            m_xmlW.WriteString(_database);
            m_xmlW.WriteEndElement();

            m_xmlW.Close();
        }
        #endregion
    }
}
