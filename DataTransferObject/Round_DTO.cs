
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Round_DTO
    {
        private string roundID;
        private string fixtureID;
        private int matchCount;

        public Round_DTO() { }

        public Round_DTO(string _roundID, string _fixtureID, int _matchCount)
        {
            this.roundID = _roundID;
            this.fixtureID = _fixtureID;
            this.matchCount = _matchCount;
        }

        public string RoundID
        {
            get { return roundID; }
            set { roundID = value; }
        }

        public string FixtureID
        {
            get { return fixtureID; }
            set { fixtureID = value; }
        }

        public int MatchCount
        {
            get { return matchCount; }
            set { matchCount = value; }
        }

    }
}
