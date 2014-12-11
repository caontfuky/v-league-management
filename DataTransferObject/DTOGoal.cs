
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOGoal
    {
        public string goalID;
        public string playerID;
        public string matchID;
        public int time;

        public DTOGoal() { }

        public DTOGoal(string _goalID, string _playerID, string _matchID, int _time)
        {
            this.goalID = _goalID;
            this.playerID = _playerID;
            this.matchID = _matchID;
            this.time = _time;
        }

    }
}
