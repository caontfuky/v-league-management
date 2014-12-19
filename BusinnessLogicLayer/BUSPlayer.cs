using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataAcessLayer;
using System.Data;

namespace BusinnessLogicLayer
{
    public class BUSPlayer
    {
        DALPlayer m_dalPlayer;

        public BUSPlayer()
        {
            m_dalPlayer = new DALPlayer();
        }

        public DataTable getAllData()
        {
            return m_dalPlayer.getAllData();
        }

        public DataTable getPlayerBySeasonID(string seasonID)
        {
            return m_dalPlayer.getPlayerBySeasonID(seasonID);
        }

        public DataTable getPlayerBySeasonIDAndPlayerID(string seasonID, string PlayerID)
        {
            return m_dalPlayer.getPlayerBySeasonIDAndPlayerID(seasonID, PlayerID);
        }

        public DataTable getPlayerBySeasonIDAndTeamID(string seasonID, string TeamID)
        {
            return m_dalPlayer.getPlayerBySeasonIDAndTeamID(seasonID, TeamID);
        }

        public DataTable getPlayerFreeBySeasonID(string seasonID)
        {
            return m_dalPlayer.getPlayerFreeBySeasonID(seasonID);
        }

        public int insertData(DTOPlayer _dtoPlayer)
        {
            return m_dalPlayer.insertData(_dtoPlayer);
        }
        
        public int updateData(DTOPlayer _dtoPlayer)
        {
            return m_dalPlayer.updateData(_dtoPlayer);
        }

        public int deleteData(string playerID)
        {
            return m_dalPlayer.deleteData( playerID);
        }

        public int deletePlayerIDInSeason(string seasonID, string playerID)
        {
            return m_dalPlayer.deletePlayerIDInSeason(seasonID, playerID);
        }
    }
}
