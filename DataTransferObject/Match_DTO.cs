using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Match_DTO
    {
        private string matchID;
        private string homeTeam;
        private string visitingTeam;
        private string stadiumID;
        private string startDate;
        private string refereeID;
        private string roundID;

        public Match_DTO() { }

        public Match_DTO(string _matchID, string _homeTeam, string _visitingTeam, string _stadiumID, string _startDate, string _refereeID, string _roundID)
        {
            this.matchID = _matchID;
            this.homeTeam = _homeTeam;
            this.visitingTeam = _visitingTeam;
            this.stadiumID = _stadiumID;
            this.startDate = _startDate;
            this.refereeID = _refereeID;
            this.refereeID = _roundID;
        }

        public string MatchID
        {
            get { return matchID; }
            set { matchID = value; }
        }

        public string HomeTeam
        {
            get { return homeTeam; }
            set { homeTeam = value; }
        }

        public string VisitingTeam
        {
            get { return visitingTeam; }
            set { visitingTeam = value; }
        }

        public string StadiumID
        {
            get { return stadiumID; }
            set { stadiumID = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string RefereeID
        {
            get { return refereeID; }
            set { refereeID = value; }
        }

        public string RoundID
        {
            get { return roundID; }
            set { roundID = value; }
        }


    }
}
