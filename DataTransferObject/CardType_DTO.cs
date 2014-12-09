using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class CardType_DTO
    {
        private string cardTypeID;
        private string cardTypeName;

        public CardType_DTO() { }

        public CardType_DTO(string _cardTypeID, string _cardTypeName)
        {
            this.cardTypeID = _cardTypeID;
            this.cardTypeName = _cardTypeName;
        }

        public string CardTypeID
        {
            get { return cardTypeID; }
            set { cardTypeID = value; }
        }

        public string CardTypeName
        {
            get { return cardTypeName; }
            set { cardTypeName = value; }
        }


    }
}
