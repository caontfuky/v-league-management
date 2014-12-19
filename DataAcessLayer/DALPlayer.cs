using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataTransferObject.Global;
using System.Data;

namespace DataAcessLayer
{
    public class DALPlayer
    {
        public DALPlayer() { }

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllPlayerValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getPlayerBySeasonID(string seasonID)
        {
            DataExecute.Instance.createSqlCmd("GetPlayerBySeasonID", new object[1] { seasonID });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getPlayerBySeasonIDAndPlayerID(string seasonID, string PlayerID)
        {
            DataExecute.Instance.createSqlCmd("GetPlayerBySeasonIDAndPlayerID", new object[2] { seasonID, PlayerID });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getPlayerFreeBySeasonID(string seasonID)
        {
            DataExecute.Instance.createSqlCmd("GetPlayerFreeBySeasonID", new object[1] { seasonID });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }


        public DataTable getPlayerBySeasonIDAndTeamID(string seasonID, string TeamID)
        {
            DataExecute.Instance.createSqlCmd("GetPlayerBySeasonIDAndTeamID", new object[2] { seasonID, TeamID });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public int insertData(DTOPlayer _dtoPlayer)
        {
            if (_dtoPlayer != null)
            {
                DataExecute.Instance.createSqlCmd("InsertPlayerValue", ref _dtoPlayer);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int updateData(DTOPlayer _dtoPlayer)
        {
            if (_dtoPlayer != null)
            {
                DataExecute.Instance.createSqlCmd("UpdatePlayerValue", ref _dtoPlayer);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteData(string playerID)
        {
            if (playerID != null )
            {
                DataExecute.Instance.createSqlCmd("DeletePlayerValue", new object[1] { playerID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
        public int deletePlayerIDInSeason(string seasonID, string playerID)
        {
            if (playerID != null && seasonID != null)
            {
                DataExecute.Instance.createSqlCmd("DeletePlayerIDInSeason", new object[2] { seasonID, playerID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
