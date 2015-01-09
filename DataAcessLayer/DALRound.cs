using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataTransferObject.Global;
using DataTransferObject;

namespace DataAcessLayer
{
    public class DALRound
    {
        public DALRound() { }

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllRoundValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getAllRoundName()
        {
            DataExecute.Instance.createSqlCmd("GetAllRoundNameValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getIDRoundByName(string RoundName)
        {
            DataExecute.Instance.createSqlCmd("GetIDRoundByName", new object[1] { RoundName });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }
        
        public int updateData(DTORound _dtoRound)
        {
            if (_dtoRound != null)
            {
                DataExecute.Instance.createSqlCmd("UpdateRoundValue", ref _dtoRound);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteData(string RoundID)
        {
            if (RoundID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteRoundValue", new object[1] { RoundID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int insertData(DTORound _dtoRound)
        {
            if (_dtoRound != null)
            {
                DataExecute.Instance.createSqlCmd("InsertRoundValue", ref _dtoRound);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
