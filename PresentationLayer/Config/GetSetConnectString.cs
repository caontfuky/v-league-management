using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Xml;

namespace PresentationLayer.Config
{
    public class GetSetConnectString
    {
        
        #region "variable"
        private static XmlDocument m_xmlR;
        private static XmlTextWriter m_xmlW;
        #endregion 
        #region "method"
        public GetSetConnectString()
        {
            m_xmlR = new XmlDocument();
            //m_xmlW = new XmlTextWriter();
        }
        public static XmlDocument getConnectString(String _fileName)
        {
            try
            {
                m_xmlR = new XmlDocument();
                if (System.IO.File.Exists(_fileName))
                {
                    m_xmlR.Load(_fileName);
                }
            }
            catch (XmlException)
            {
                //XtraMessageBox.Show("Can't read file");
            }
            return m_xmlR;
        }
        public static void setConnectString(String _fileName, String _server, String _database, String _authorities)
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
        public static void setConnectString(String _fileName, String _server, String _database, String _username, String _passwork, String _authorities)
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
