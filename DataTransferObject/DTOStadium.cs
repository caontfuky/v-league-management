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
        public int tankage;
        public string address;

        public DTOStadium() { }

        public DTOStadium(string _stadiumID, string _stadiumName, int _tankage,  string _address)
        {
            this.stadiumID = _stadiumID;
            this.stadiumName = _stadiumName;
            this.address = _address;
            this.tankage = _tankage;
        }

    }
}
