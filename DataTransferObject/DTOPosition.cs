using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOPosition
    {
        public string positionID;
        public string positionName;

        public DTOPosition()
        {

        }

        public DTOPosition(string _positionID, string _name)
        {
            this.positionID = _positionID;
            this.positionName = _name;
        }

       
    }
}
