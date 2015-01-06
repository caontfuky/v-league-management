using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOCoach
    {
        public string coachID;
        public string coachName;
        public int birthDay;
        public string address;
        public int phoneNumber;

        public DTOCoach() { }

        public DTOCoach(string _coachID, string _coachName, int _birthDay, string _address, int _phoneNumber)
        {
            this.coachID = _coachID;
            this.coachName = _coachName;
            this.birthDay = _birthDay;
            this.address = _address;
            this.phoneNumber = _phoneNumber;
        }

    }
}
