using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOPlayerTeamSeason
    {
        public string playerID;
        public string teamID;
        public string seasonID;

        public DTOPlayerTeamSeason() { }

        public DTOPlayerTeamSeason(string _playerID, string _teamID, string _seasonID)
        {
            this.playerID = _playerID;
            this.teamID = _teamID;
            this.seasonID = _seasonID;
        }

       
    }
}
