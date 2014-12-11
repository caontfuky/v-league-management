using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOStanding
    {
        private string seasonID;
        private string teamID;
        private int totalMatch;
        private int totalMatchWon;
        private int totalMatchLost;
        private int totalMatchDrawn;
        private int goalsFor;
        private int goalsAgainst;
        private int goalsDisfference;
        private int point;

        public DTOStanding() { }

        public DTOStanding(string _seasonID, string _teamID, int _totalMatch, int _totalMatchWon, int _totalMatchLost, int _totalMatchDrawn, int _goalsFor, int _goalsAgainst, int _goalsDifference, int _point)
        {
            this.seasonID = _seasonID;
            this.teamID = _teamID;
            this.totalMatch = _totalMatch;
            this.totalMatchWon = _totalMatchWon;
            this.totalMatchLost = _totalMatchLost;
            this.totalMatchDrawn = _totalMatchDrawn;
            this.goalsFor = _goalsFor;
            this.goalsAgainst = _goalsAgainst;
            this.goalsDisfference = _goalsDifference;
            this.point = _point;
        }

        public string SeasonID
        {
            get { return seasonID; }
            set { seasonID = value; }
        }

        public string TeamID
        {
            get { return teamID; }
            set { teamID = value; }
        }

        public int TotalMatch
        {
            get { return totalMatch; }
            set { totalMatch = value; }
        }

        public int TotalMatchWon
        {
            get { return totalMatchWon; }
            set { totalMatchWon = value; }
        }

        public int TotalMatchLost
        {
            get { return totalMatchLost; }
            set { totalMatchLost = value; }
        }

        public int TotalMatchDrawn
        {
            get { return totalMatchDrawn; }
            set { totalMatchDrawn = value; }
        }

        public int GoalsFor
        {
            get { return goalsFor; }
            set { goalsFor = value; }
        }

        public int GoalsAgainst
        {
            get { return goalsAgainst; }
            set { goalsAgainst = value; }
        }

        public int GoalsDisfference
        {
            get { return goalsDisfference; }
            set { goalsDisfference = value; }
        }

        public int Point
        {
            get { return point; }
            set { point = value; }
        }


    }
}
