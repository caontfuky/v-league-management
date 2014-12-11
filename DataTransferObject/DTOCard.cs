using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOCard
    {
        public string cardID;
        public string playerID;
        public string matchID;
        public string cardTypeID;
        public int time;

        public DTOCard() { }

        public DTOCard(string _cardID, string _playerID, string _matchID, string _cardTypeID, int _time)
        {
            this.cardID = _cardID;
            this.playerID = _playerID;
            this.matchID = _matchID;
            this.cardTypeID = _cardTypeID;
            this.time = _time;
        }

    }
}
