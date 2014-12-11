using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOCoachTeamSeason
    {
        public string coachID;
        public string teamID;
        public string seasonID;

        public DTOCoachTeamSeason() { }

        public DTOCoachTeamSeason(string _coachID, string _teamID, string _seasonID)
        {
            this.coachID = _coachID;
            this.teamID = _teamID;
            this.seasonID = _seasonID;
        }

    }
}
