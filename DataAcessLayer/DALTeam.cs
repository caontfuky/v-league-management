using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataTransferObject.Global;
using System.Data;

namespace DataAcessLayer
{
    public class DALTeam
    {
        public DALTeam() { }

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllTeamValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public int insertData(DTOTeam _dtoTeam)
        {
            if(_dtoTeam != null)
            {
                DataExecute.Instance.createSqlCmd("InsertTeamValue", ref _dtoTeam);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
