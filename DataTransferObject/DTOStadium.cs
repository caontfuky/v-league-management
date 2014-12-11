using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOStadium
    {
        public string stadiumID;
        public string stadiumName;
        public string address;
        public int tankage;

        public DTOStadium() { }

        public DTOStadium(string _stadiumID, string _stadiumName, string _address, int _tankage)
        {
            this.stadiumID = _stadiumID;
            this.stadiumName = _stadiumName;
            this.address = _address;
            this.tankage = _tankage;
        }

    }
}
