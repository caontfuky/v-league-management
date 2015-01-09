using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject.Global;
using System.Data;
using DataTransferObject;

namespace DataAcessLayer
{
    public class DALStanding
    {
        public DALStanding() { }

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllStandingValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }


        public int updateData(DTOStanding _dtoStanding)
        {
            if (_dtoStanding != null)
            {
                DataExecute.Instance.createSqlCmd("UpdateStandingValue", ref _dtoStanding);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteData(string seasonID, string teamID)
        {
            if (teamID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteStandingValue", new object[2] { seasonID, teamID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int insertData(DTOStanding _dtoStanding)
        {
            if (_dtoStanding != null)
            {
                DataExecute.Instance.createSqlCmd("InsertStandingValue", ref _dtoStanding);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}