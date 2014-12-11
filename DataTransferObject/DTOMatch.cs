using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOMatch
    {
        public string matchID;
        public string homeTeam;
        public string visitingTeam;
        public string stadiumID;
        public string startDate;
        public string refereeID;
        public string roundID;

        public DTOMatch() { }

        public DTOMatch(string _matchID, string _homeTeam, string _visitingTeam, string _stadiumID, string _startDate, string _refereeID, string _roundID)
        {
            this.matchID = _matchID;
            this.homeTeam = _homeTeam;
            this.visitingTeam = _visitingTeam;
            this.stadiumID = _stadiumID;
            this.startDate = _startDate;
            this.refereeID = _refereeID;
            this.roundID = _roundID;
        }

    }
}
