using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOCardType
    {
        public string cardTypeID;
        public string cardTypeName;

        public DTOCardType() { }

        public DTOCardType(string _cardTypeID, string _cardTypeName)
        {
            this.cardTypeID = _cardTypeID;
            this.cardTypeName = _cardTypeName;
        }

    }
}
