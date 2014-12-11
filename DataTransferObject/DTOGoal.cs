
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOGoal
    {
        private string goalID;
        private string playerID;
        private string matchID;
        private int time;

        public DTOGoal() { }

        public DTOGoal(string _goalID, string _playerID, string _matchID, int _time)
        {
            this.goalID = _goalID;
            this.playerID = _playerID;
            this.matchID = _matchID;
            this.time = _time;
        }

        public string GoalID
        {
            get { return goalID; }
            set { goalID = value; }
        }

        public string PlayerID
        {
            get { return playerID; }
            set { playerID = value; }
        }

        public string MatchID
        {
            get { return matchID; }
            set { matchID = value; }
        }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }


    }
}
