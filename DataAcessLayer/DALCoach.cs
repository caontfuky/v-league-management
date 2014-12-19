using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataTransferObject.Global;
using System.Data;

namespace DataAcessLayer
{
    public class DALCoach
    {
        public DALCoach() { }

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllCoachValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getDataBySeason(string seasonName)
        {
            DataExecute.Instance.createSqlCmd("GetCoachBySeason", new object[1] { seasonName });

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public int updateData(DTOCoach _dtoCoach)
        {
            if (_dtoCoach != null)
            {
                DataExecute.Instance.createSqlCmd("UpdateCoachValue", ref _dtoCoach);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteData(string coachID)
        {
            if (coachID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteCoachValue", new object[1] { coachID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int insertData(DTOCoach _dtoCoach)
        {
            if (_dtoCoach != null)
            {
                DataExecute.Instance.createSqlCmd("InsertCoachValue", ref _dtoCoach);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
