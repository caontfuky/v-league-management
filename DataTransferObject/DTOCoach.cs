using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOCoach
    {
        private string coachID;
        private string coachName;
        private string birthDay;
        private string address;
        private int phoneNumber;

        public DTOCoach() { }

        public DTOCoach(string _coachID, string _coachName, string _birthDay, string _address, int _phoneNumber)
        {
            this.coachID = _coachID;
            this.coachName = _coachName;
            this.birthDay = _birthDay;
            this.address = _address;
            this.phoneNumber = _phoneNumber;
        }

        public string CoachID
        {
            get { return coachID; }
            set { coachID = value; }
        }

        public string CoachName
        {
            get { return coachName; }
            set { coachName = value; }
        }

        public string BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


    }
}
