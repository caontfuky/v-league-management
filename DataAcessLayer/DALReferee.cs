using DataTransferObject.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataTransferObject;

namespace DataAcessLayer
{
    public class DALReferee
    {
        public DALReferee() { }

        public DataTable getDataBySeason(string seasonName)
        {
            DataExecute.Instance.createSqlCmd("GetRefereeBySeason", new object[1] { seasonName });

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public int updateData(DTOReferee _dtoReferee)
        {
            if (_dtoReferee != null)
            {
                DataExecute.Instance.createSqlCmd("UpdateRefereeValue", ref _dtoReferee);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteData(string refereeID)
        {
            if (refereeID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteRefereeValue", new object[1] { refereeID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int insertData(DTOReferee _dtoReferee)
        {
            if (_dtoReferee != null)
            {
                DataExecute.Instance.createSqlCmd("InsertRefereeValue", ref _dtoReferee);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
