using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOPlayerTeamSeason
    {
        private string playerID;
        private string teamID;
        private string seasonID;

        public DTOPlayerTeamSeason() { }

        public DTOPlayerTeamSeason(string _playerID, string _teamID, string _seasonID)
        {
            this.playerID = _playerID;
            this.teamID = _teamID;
            this.seasonID = _seasonID;
        }

        public string PlayerID
        {
            get { return playerID; }
            set { playerID = value; }
        }

        public string TeamID
        {
            get { return teamID; }
            set { teamID = value; }
        }

        public string SeasonID
        {
            get { return seasonID; }
            set { seasonID = value; }
        }


    }
}
