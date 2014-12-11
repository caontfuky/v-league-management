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

        public DTOReferee() { }

        public DTOReferee(string _refereeID, string _refereeName)
        {
            this.refereeID = _refereeID;
            this.refereeName = _refereeName;
        }

      
    }
}
