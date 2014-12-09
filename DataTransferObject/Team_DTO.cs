using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Team_DTO
    {
        private string teamID;
        private string name;
        private string chairman;
        private string stadiumID;
        private string email;
        private string establishedYear;
        private string cEO;
        private string address;
        private string phoneNumber;
        private string fax;

        public Team_DTO() { }

        public Team_DTO(string _teamID, string _name, string _chairman, string _stadiumID, string _email, string _establishedYear, string _ceo, string _address, string _phoneNumber, string _fax)
        {
            this.teamID = _teamID;
            this.name = _name;
            this.chairman = _chairman;
            this.stadiumID = _stadiumID;
            this.email = _email;
            this.establishedYear = _establishedYear;
            this.cEO = _ceo;
            this.address = _address;
            this.phoneNumber = _phoneNumber;
            this.fax = _fax;
        }

        public string TeamID
        {
            get { return teamID; }
            set { teamID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Chairman
        {
            get { return chairman; }
            set { chairman = value; }
        }

        public string StadiumID
        {
            get { return stadiumID; }
            set { stadiumID = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string EstablishedYear
        {
            get { return establishedYear; }
            set { establishedYear = value; }
        }

        public string CEO
        {
            get { return cEO; }
            set { cEO = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }



    }
}
