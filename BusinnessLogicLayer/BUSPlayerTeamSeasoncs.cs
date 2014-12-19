using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataAcessLayer;

namespace BusinnessLogicLayer
{
    public class BUSPlayerTeamSeasoncs
    {
        DALPlayerTeamSeason _dalPlayerTeamSeason;

        public BUSPlayerTeamSeasoncs()
        {
            _dalPlayerTeamSeason = new DALPlayerTeamSeason();
        }

        public int deleteDataBySeasonID(string seasonID)
        {
            return _dalPlayerTeamSeason.deleteDataBySeasonID(seasonID);
        }

        public int deleteDataBySeasonIDAndTeamID(string seasonID, string teamID)
        {
            return _dalPlayerTeamSeason.deleteDataBySeasonIDAndTeamID(seasonID, teamID);
        }

        public int deleteDataBySeasonIDAndTeamIDAndPlayerID(string seasonID, string teamID, string playerID)
        {
            return _dalPlayerTeamSeason.deleteDataBySeasonIDAndTeamIDAndPlayerID(seasonID, teamID, playerID);
        }

        public int insertData(DTOPlayerTeamSeason _dtoPlayerTeamSeason)
        {
            return _dalPlayerTeamSeason.insertData(_dtoPlayerTeamSeason);
        }
    }
}
