using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOSeasonFixtures
    {
        private string fixtureID;
        private string seasonID;
        private int roundCount;

        public DTOSeasonFixtures() { }

        public DTOSeasonFixtures(string _fixtureID, string _seasonID, int _roundCount)
        {
            this.fixtureID = _fixtureID;
            this.seasonID = _seasonID;
            this.roundCount = _roundCount;
        }

        public string FixtureID
        {
            get { return fixtureID; }
            set { fixtureID = value; }
        }

        public string SeasonID
        {
            get { return seasonID; }
            set { seasonID = value; }
        }

        public int RoundCount
        {
            get { return roundCount; }
            set { roundCount = value; }
        }


    }
}
