using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Position_DTO
    {
        private string positionID;
        private string positionName;

        public Position_DTO()
        {

        }

        public Position_DTO(string _positionID, string _name)
        {
            this.positionID = _positionID;
            this.positionName = _name;
        }

        public string PositionID
        {
            get { return positionID; }
            set { positionID = value; }
        }
        public string PositionName
        {
            get { return positionName; }
            set { positionName = value; }
        }

    }
}
