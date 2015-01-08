
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTORound
    {
        public string roundID;
        public string seasonID;
        public string roundName;
        public int matchCount;

        public DTORound() { }

        public DTORound(string _roundID, string _seasonID, string _roundName,int _matchCount)
        {
            this.roundID = _roundID;
            this.seasonID = _seasonID;
            this.roundName = _roundName;
            this.matchCount = _matchCount;
        }
    }
}
