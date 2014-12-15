using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOReferee
    {
        public string refereeID;
        public string refereeName;
        public string email;
        public string phoneNumber;
        public string birthDate;
        public string seasonID;
        public string address;

        public DTOReferee() { }

        public DTOReferee(string _refereeID, string _refereeName, string _email, string _phoneNumber, string _birthDate, string _seasonID, string _address)
        {
            this.refereeID = _refereeID;
            this.refereeName = _refereeName;
            this.email = _email;
            this.phoneNumber = _phoneNumber;
            this.birthDate = _birthDate;
            this.seasonID = _seasonID;
            this.address = _address;
        }

      
    }
}
