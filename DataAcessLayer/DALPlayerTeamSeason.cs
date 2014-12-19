using DataTransferObject.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;

namespace DataAcessLayer
{
    public class DALPlayerTeamSeason
    {
        public DALPlayerTeamSeason() { }

        public int deleteDataBySeasonID(string seasonID)
        {
            if (seasonID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteDataBySeasonID", new object[1] { seasonID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteDataBySeasonIDAndTeamID(string seasonID, string teamID)
        {
            if (seasonID != null && teamID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteDataBySeasonIDAndTeamID", new object[2] { seasonID , teamID});
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteDataBySeasonIDAndTeamIDAndPlayerID(string seasonID, string teamID, string playerID)
        {
            if (seasonID != null && teamID != null && playerID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteDataBySeasonIDAndTeamIDAndPlayerID", new object[3] { seasonID, teamID, playerID});
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int insertData(DTOPlayerTeamSeason _dtoPlayerTeamSeason)
        {
            if (_dtoPlayerTeamSeason != null)
            {
                DataExecute.Instance.createSqlCmd("InsertPlayerTeamSeasonValue", ref _dtoPlayerTeamSeason);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
