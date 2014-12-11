using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOCoachTeamSeason
    {
        private string coachID;
        private string teamID;
        private string seasonID;

        public DTOCoachTeamSeason() { }

        public DTOCoachTeamSeason(string _coachID, string _teamID, string _seasonID)
        {
            this.coachID = _coachID;
            this.teamID = _teamID;
            this.seasonID = _seasonID;
        }

        public string CoachID
        {
            get { return coachID; }
            set { coachID = value; }
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
