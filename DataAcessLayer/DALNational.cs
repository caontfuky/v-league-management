using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataTransferObject.Global;
using System.Data;

namespace DataAcessLayer
{
    public class DALNational
    {
        public DALNational() { }

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllNationalValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getNationalIDByNationalName(string nationalName)
        {
            DataExecute.Instance.createSqlCmd("GetNationalIDByNationalName", new object[1] { nationalName });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public int updateData(DTONational _dtoNational)
        {
            if (_dtoNational != null)
            {
                DataExecute.Instance.createSqlCmd("UpdateNationalValue", ref _dtoNational);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteData(string nationalID)
        {
            if (nationalID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteNationalValue", new object[1] { nationalID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int insertData(DTONational _dtoNational)
        {
            if (_dtoNational != null)
            {
                DataExecute.Instance.createSqlCmd("InsertNationalValue", ref _dtoNational);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
