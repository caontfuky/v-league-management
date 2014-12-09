using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Referee_DTO
    {
        private string refereeID;
        private string refereeName;

        public Referee_DTO() { }

        public Referee_DTO(string _refereeID, string _refereeName)
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
