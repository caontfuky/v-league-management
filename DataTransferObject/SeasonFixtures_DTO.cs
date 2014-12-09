using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class SeasonFixtures_DTO
    {
        private string fixtureID;
        private string seasonID;
        private int roundCount;

        public SeasonFixtures_DTO() { }

        public SeasonFixtures_DTO(string _fixtureID, string _seasonID, int _roundCount)
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
