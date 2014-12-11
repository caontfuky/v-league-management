
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
        public string fixtureID;
        public int matchCount;

        public DTORound() { }

        public DTORound(string _roundID, string _fixtureID, int _matchCount)
        {
            this.roundID = _roundID;
            this.fixtureID = _fixtureID;
            this.matchCount = _matchCount;
        }
    }
}
