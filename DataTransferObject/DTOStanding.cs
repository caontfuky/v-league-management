using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOStanding
    {
        public string seasonID;
        public string teamID;
        public int totalMatch;
        public int totalMatchWon;
        public int totalMatchLost;
        public int totalMatchDrawn;
        public int goalsFor;
        public int goalsAgainst;
        public int goalsDisfference;
        public int point;

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

       

    }
}
