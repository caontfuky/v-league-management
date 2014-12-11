using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOStadium
    {
        private string stadiumID;
        private string stadiumName;
        private string address;
        private int tankage;

        public DTOStadium() { }

        public DTOStadium(string _stadiumID, string _stadiumName, string _address, int _tankage)
        {
            this.stadiumID = _stadiumID;
            this.stadiumName = _stadiumName;
            this.address = _address;
            this.tankage = _tankage;
        }

        public string StadiumID
        {
            get { return stadiumID; }
            set { stadiumID = value; }
        }

        public string StadiumName
        {
            get { return stadiumName; }
            set { stadiumName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Tankage
        {
            get { return tankage; }
            set { tankage = value; }
        }


    }
}
