using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTONational
    {
        private string nationalID;
        private string nationalName;

        public DTONational() { }

        public DTONational(string _nationalID, string _name)
        {
            this.nationalID = _nationalID;
            this.nationalName = _name;
        }

        public string NationalID
        {
            get { return nationalID; }
            set { nationalID = value; }
        }

        public string NationalName
        {
            get { return nationalName; }
            set { nationalName = value; }
        }


    }
}
