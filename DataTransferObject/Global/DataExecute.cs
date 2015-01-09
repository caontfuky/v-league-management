using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace DataTransferObject.Global
{
    public class DataExecute : Singleton<DataExecute>
    {
        #region "variable"
        private SqlDataAdapter m_sqlDataAdapter;
        private DataTable m_dataResult;
        private SqlTransaction m_sqlTransaction;
        //private SqlCommandBuilder   m_sqlCommandBuilder;
        #endregion
        #region "method"
        public DataExecute()
        {
           
        }

        /// <summary>
        /// Phuong thuc nay dung de kiem tra ket noi voi database. oh
        /// Tra ve true neu ket noi thanh cong, nguoc lai tra ve false.
        /// </summary>
        /// <returns></returns>
        public bool CheckConnectionDatabase()
        {
            if (DataConnection.Instance.openConnection())
            {
                this.m_sqlDataAdapter = new SqlDataAdapter();
                this.m_dataResult = new DataTable();
                this.m_sqlTransaction = null;
                //this.m_sqlCommandBuilder    = null;
                return true;
            }
            else
            {
                this.m_sqlDataAdapter = null;
                this.m_dataResult = null;
                this.m_sqlTransaction = null;
                return false;
            }
        }

        public DataTable getData(SqlCommand _sqlCommand)
        {
            if (this.CheckConnectionDatabase())
            {
                try
                {
                    //DataConnection.Instance.m_cmd = _sqlCommand;
                    //DataConnection.Instance.m_cmd.Connection = DataConnection.Instance.m_conn;
                    this.m_sqlDataAdapter.SelectCommand = DataConnection.Instance.m_cmd;
                    this.m_dataResult.Clear();
                    this.m_dataResult.AcceptChanges();
                    this.m_sqlDataAdapter.Fill(m_dataResult);
                }
                catch (SqlException e)
                {
                    this.m_dataResult = null;
                    throw (e); 
                }
                finally
                {
                    DataConnection.Instance.closeConnection();
                }

            }
            if (m_dataResult.Rows.Count != 0)
                return this.AutoNumberedTable(m_dataResult);
            else
                return m_dataResult;
        }

        /// <summary>
        /// Phuong thuc dung de sap xep database theo so thu tu
        /// </summary>
        /// <param name="SourceTable">DataTable ban dau</param>
        /// <returns></returns>
        private DataTable AutoNumberedTable(DataTable SourceTable)
        {

            DataTable ResultTable = new DataTable();
            DataColumn AutoNumberColumn = new DataColumn();
            AutoNumberColumn.ColumnName = "STT";
            AutoNumberColumn.DataType = typeof(int);
            AutoNumberColumn.AutoIncrement = true;
            AutoNumberColumn.AutoIncrementSeed = 1;
            AutoNumberColumn.AutoIncrementStep = 1;
            ResultTable.Columns.Add(AutoNumberColumn);
            ResultTable.PrimaryKey = new DataColumn[] { AutoNumberColumn };
            ResultTable.Merge(SourceTable);
            return ResultTable;

        }

        /// <summary>
        /// Phuong thuc nay tra ve chi so cua dong cuoi cung trong database, dong co chi so lon nhat
        /// </summary>
        /// <param name="_sqlCommand"></param>
        /// <returns></returns>
        public String getMaxId(SqlCommand _sqlCommand)
        {
            String _maxId = "";
            if (this.CheckConnectionDatabase())
            {
                try
                {
                    DataConnection.Instance.m_cmd = _sqlCommand;
                    DataConnection.Instance.m_cmd.Connection = DataConnection.Instance.m_conn;
                    if (DataConnection.Instance.m_cmd.ExecuteScalar() != null)
                        _maxId = DataConnection.Instance.m_cmd.ExecuteScalar().ToString();
                }
                catch (SqlException e)
                {
                    throw (e);
                }
                finally
                {
                    DataConnection.Instance.closeConnection();
                }

            }
            return _maxId;
        }

        /// <summary>
        /// Phuong thuc nay dung de update du lieu.
        /// Co the la Update, Delete du lieu
        /// </summary>
        /// <param name="_sqlCommand">La chuoi command</param>
        /// <returns></returns>
        public int updateData(SqlCommand _sqlCommand)
        {
            int _countRowChange = 0;
            if (this.CheckConnectionDatabase())
            {
                try
                {
                    DataConnection.Instance.m_cmd = _sqlCommand;
                    DataConnection.Instance.m_cmd.Connection = DataConnection.Instance.m_conn;
                    this.m_sqlTransaction = DataConnection.Instance.m_conn.BeginTransaction();
                    DataConnection.Instance.m_cmd.Transaction = this.m_sqlTransaction;
                    _countRowChange = DataConnection.Instance.m_cmd.ExecuteNonQuery();
                    this.m_dataResult.AcceptChanges();
                    this.m_sqlTransaction.Commit();
                }
                catch (SqlException)
                {
                    //DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString());
                    if (this.m_sqlTransaction != null)
                    {
                        this.m_sqlTransaction.Rollback();
                    }

                }
                finally
                {
                    DataConnection.Instance.closeConnection();
                }
            }
            return _countRowChange;
        }

        //Ham tra ve mot chuoi String co parameter
        public String getStringExecute(SqlCommand _sqlCommand)
        {
            try
            {
                String str = null;
                if (this.CheckConnectionDatabase())
                {
                    DataConnection.Instance.m_cmd = _sqlCommand;
                    DataConnection.Instance.m_cmd.Connection = DataConnection.Instance.m_conn;
                    str = DataConnection.Instance.m_cmd.ExecuteScalar().ToString();
                }
                return str;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        //Ham tra ve mot so co parameter
        public int getIntExecuter(SqlCommand _sqlCommand)
        {
            try
            {
                int temp = 0;
                if (this.CheckConnectionDatabase())
                {
                    DataConnection.Instance.m_cmd = _sqlCommand;
                    DataConnection.Instance.m_cmd.Connection = DataConnection.Instance.m_conn;
                    temp = int.Parse(DataConnection.Instance.m_cmd.ExecuteScalar().ToString());
                }
                return temp;
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        /// <summary>
        /// Phuong thuc nay dung de tao mot command
        /// Truyen cac doi so vao phai dung thu tu
        /// Phuong thuc nay chi dung trong cac truong hop muon tao ra cac sqlcomand don gian
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_sqlCommand"></param>
        /// <param name="_dtoObject"></param>
        public void createSqlCmd<T>(string _cmdText, ref T _dtoObject)
        {
            if (this.CheckConnectionDatabase())
            {
                try
                {
                    Type type = typeof(T); //Lay kieu cua doi tuong
                    Assembly assembly = Assembly.GetAssembly(type);
                    //T obj = (T)assembly.CreateInstance(type.FullName);
                    FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
                    DataConnection.Instance.m_cmd = new SqlCommand();
                    DataConnection.Instance.m_cmd.CommandType = CommandType.StoredProcedure;
                    DataConnection.Instance.m_cmd.CommandText = _cmdText;
                    DataConnection.Instance.m_cmd.Connection = DataConnection.Instance.m_conn;
                    SqlCommandBuilder.DeriveParameters(DataConnection.Instance.m_cmd);
                    int count = 0;
                    if (fields.Length > 0)
                    {
                        //Get tat cac ca parameter of storeprocedure
                        SqlParameterCollection paras = DataConnection.Instance.m_cmd.Parameters;
                        foreach (FieldInfo field in fields)
                        {
                            if (paras[count].ParameterName.Equals("@RETURN_VALUE"))
                                count++;
                            paras[count++].SqlValue = field.GetValue(_dtoObject);
                        }
                    }
                    else
                    {
                        throw (new Exception("So luong parameter va value la khong giong nhau"));
                    }
                }
                catch (SqlException e)
                {
                    throw (e);
                }
            }
        }   

        /// <summary>
        /// Phuong thuc nay dung de tao mot command
        /// </summary>
        /// <param name="_sqlCommand"></param>
        public void createSqlCmd(string _cmdText, object[] _conditon)
        {
            if (this.CheckConnectionDatabase())
            {
                try
                {
                    DataConnection.Instance.m_cmd = new SqlCommand();
                    DataConnection.Instance.m_cmd.CommandType = CommandType.StoredProcedure;
                    DataConnection.Instance.m_cmd.CommandText = _cmdText;
                    DataConnection.Instance.m_cmd.Connection = DataConnection.Instance.m_conn;
                    SqlCommandBuilder.DeriveParameters(DataConnection.Instance.m_cmd);
                    int count = 0;
                    if (_conditon.Length > 0)
                    {
                        //Get tat cac ca parameter of storeprocedure
                        SqlParameterCollection paras = DataConnection.Instance.m_cmd.Parameters;
                        foreach (object obj in _conditon)
                        {
                            if (paras[count].ParameterName.Equals("@RETURN_VALUE"))
                                count++;
                            paras[count++].SqlValue = obj;                                                 
                        }
                    }
                    else
                    {
                        throw (new Exception("So luong parameter va value la khong giong nhau"));
                    }
                }
                catch (SqlException e)
                {
                    throw (e);
                }
            }
        }

        public void createSqlCmd(string _cmdText)
        {
            if (this.CheckConnectionDatabase())
            {
                try
                {
                    DataConnection.Instance.m_cmd = new SqlCommand();
                    DataConnection.Instance.m_cmd.CommandType = CommandType.StoredProcedure;
                    DataConnection.Instance.m_cmd.CommandText = _cmdText;
                    DataConnection.Instance.m_cmd.Connection = DataConnection.Instance.m_conn;
                }
                catch (SqlException e)
                {
                    throw (e);
                }
            }
        }

        #endregion

    }
}

