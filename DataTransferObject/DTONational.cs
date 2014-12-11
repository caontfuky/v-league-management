using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTONational
    {
        public string nationalID;
        public string nationalName;

        public DTONational() { }

        public DTONational(string _nationalID, string _name)
        {
            this.nationalID = _nationalID;
            this.nationalName = _name;
        }

    }
}
