using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOReferee
    {
        private string refereeID;
        private string refereeName;

        public DTOReferee() { }

        public DTOReferee(string _refereeID, string _refereeName)
        {
            this.refereeID = _refereeID;
            this.refereeName = _refereeName;
        }

        public string RefereeID
        {
            get { return refereeID; }
            set { refereeID = value; }
        }

        public string RefereeName
        {
            get { return refereeName; }
            set { refereeName = value; }
        }


    }
}
