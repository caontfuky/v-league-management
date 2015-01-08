using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataTransferObject.Global;
using System.Data;

namespace DataAcessLayer
{
    public class DALMatch
    {
        public DALMatch() { }

        public DataTable getDataByRoundID(string roundID)
        {
            DataExecute.Instance.createSqlCmd("GetMatchByRoundID", new object[1] { roundID });

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public int updateData(DTOMatch _dtoMatch)
        {
            if (_dtoMatch != null)
            {
                DataExecute.Instance.createSqlCmd("UpdateMatchValue", ref _dtoMatch);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteData(string matchID)
        {
            if (matchID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteMatchValue", new object[1] { matchID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int insertData(DTOMatch _dtoMatch)
        {
            if (_dtoMatch != null)
            {
                DataExecute.Instance.createSqlCmd("InsertMatchValue", ref _dtoMatch);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
