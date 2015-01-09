using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace PresentationLayer.Global
{
    public class NestedRecords : ArrayList
    {
        public NestedRecords()
        {
           // Add(new RoundRecord("Vòng 1", new RoundValueRecord()));
        }
        public virtual new RoundRecord this[int index]
        {
            get { return (RoundRecord)(base[index]); }
        }
    }
    public class RoundRecord
    {
        private string fID;
        private string fName;
        ArrayList fChildList = null;

        public RoundRecord()
        {

        }

        public RoundRecord(string name, ArrayList childList)
        {
            this.fName = name;
            this.fChildList = childList;
        }

        public string ID
        {
            get { return fID; }
            set { fID = value; }
        }

        public string Name
        {
            get { return fName; }
            set { fName = value; }
        }

        public ArrayList Match
        {
            get { return fChildList; }
            set { fChildList = value; }
        }
    }
    public class RoundValueRecord : ArrayList
    {
        public RoundValueRecord()
        {
            //Add(new ChildRecordMatch("M0001", "Long An", "Đồng Nai", "Gò đậu", "01/12/2015", "Nguyễn Trọng Thư"));
            //Add(new ChildRecordMatch("M0001", "Long An", "Đồng Nai", "Gò đậu", "01/12/2015", "Nguyễn Trọng Thư"));
            //Add(new ChildRecordMatch("M0001", "Long An", "Đồng Nai", "Gò đậu", "01/12/2015", "Nguyễn Trọng Thư"));
            //Add(new ChildRecordMatch("M0001", "Long An", "Đồng Nai", "Gò đậu", "01/12/2015", "Nguyễn Trọng Thư"));
        }
    }
   
    public class ChildRecordMatch
    {
        private string matchID;

        public string MatchID
        {
            get { return matchID; }
            set { matchID = value; }
        }
        private string homeTeam;

        public string HomeTeam
        {
            get { return homeTeam; }
            set { homeTeam = value; }
        }

        private string homeTeamID;

        public string HomeTeamID
        {
            get { return homeTeamID; }
            set { homeTeamID = value; }
        }

        private string visitingTeamID;

        public string VisitingTeamID
        {
            get { return visitingTeamID; }
            set { visitingTeamID = value; }
        }

        private string visitingTeam;

        public string VisitingTeam
        {
            get { return visitingTeam; }
            set { visitingTeam = value; }
        }
        private string stadium;

        public string Stadium
        {
            get { return stadium; }
            set { stadium = value; }
        }

        private string stadiumID;

        public string StadiumID
        {
            get { return stadiumID; }
            set { stadiumID = value; }
        }

        private string startDate;

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private string startTime;

        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private string referee;

        public string Referee
        {
            get { return referee; }
            set { referee = value; }
        }

        private string refereeID;

        public string RefereeID
        {
            get { return refereeID; }
            set { refereeID = value; }
        }

        private string roundID;

        public string RoundID
        {
            get { return roundID; }
            set { roundID = value; }
        }

        private string score;

        public string Score
        {
            get { return score; }
            set { score = value; }
        }

        public ChildRecordMatch() { }

        public ChildRecordMatch(string _matchID, string _homeTeam, string _visitingTeam, string _stadium, string _startDate, string _referee)
        {
            this.matchID = _matchID;
            this.homeTeam = _homeTeam;
            this.visitingTeam = _visitingTeam;
            this.stadium = _stadium;
            //this.startDate = _startDate;
            this.referee = _referee;
        }
    }

    public class TeamInfo
    {
        public string teamID;
        public string teamName;
        public string stadiumID;
        public string stadiumName;

        public TeamInfo()
        {
        }
    }

}
