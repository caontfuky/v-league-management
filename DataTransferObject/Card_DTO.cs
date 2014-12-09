using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Card_DTO
    {
        private string cardID;
        private string playerID;
        private string matchID;
        private string cardTypeID;
        private int time;

        public Card_DTO() { }

        public Card_DTO(string _cardID, string _playerID, string _matchID, string _cardTypeID, int _time)
        {
            this.cardID = _cardID;
            this.playerID = _playerID;
            this.matchID = _matchID;
            this.cardTypeID = _cardTypeID;
            this.time = _time;
        }

        public string CardID
        {
            get { return cardID; }
            set { cardID = value; }
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

        public string CardTypeID
        {
            get { return cardTypeID; }
            set { cardTypeID = value; }
        }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }


    }
}
