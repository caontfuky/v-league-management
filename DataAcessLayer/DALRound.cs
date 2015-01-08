using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataTransferObject.Global;
using System.Data;

namespace DataAcessLayer
{
    public class DALRound
    {
        public DALRound() { }

        public DataTable getDataBySeasonID(string seasonID)
        {
            DataExecute.Instance.createSqlCmd("GetRoundBySeasonID", new object[1] { seasonID });

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

        public int deleteData(string roundID)
        {
            if (roundID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteRoundValue", new object[1] { roundID });
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
