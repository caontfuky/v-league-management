using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOSeasonFixtures
    {
        public string fixtureID;
        public string seasonID;
        public int roundCount;

        public DTOSeasonFixtures() { }

        public DTOSeasonFixtures(string _fixtureID, string _seasonID, int _roundCount)
        {
            this.fixtureID = _fixtureID;
            this.seasonID = _seasonID;
            this.roundCount = _roundCount;
        }

    }
}
