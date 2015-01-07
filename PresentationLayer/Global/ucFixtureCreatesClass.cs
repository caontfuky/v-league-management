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
        private string startDate;

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private string referee;

        public string Referee
        {
            get { return referee; }
            set { referee = value; }
        }

        public ChildRecordMatch() { }

        public ChildRecordMatch(string _matchID, string _homeTeam, string _visitingTeam, string _stadium, string _startDate, string _referee)
        {
            this.matchID = _matchID;
            this.homeTeam = _homeTeam;
            this.visitingTeam = _visitingTeam;
            this.stadium = _stadium;
            this.startDate = _startDate;
            this.referee = _referee;
        }
    }

}
