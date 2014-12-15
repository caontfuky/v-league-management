using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOTeam
    {
        public string teamID;
        public string name;
        public string chairman;
        public string stadiumID;
        public string email;
        public string establishedYear;
        public string cEO;
        public string address;
        public string phoneNumber;
        public string fax;
        public byte[] logo;

        public DTOTeam() { }

        public DTOTeam(string _teamID, string _name, string _chairman, string _stadiumID, string _email, string _establishedYear, string _ceo, string _address, string _phoneNumber, string _fax, byte[] _logo)
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
            this.logo = _logo;
        }
    }
}
