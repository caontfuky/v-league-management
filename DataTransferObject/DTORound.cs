
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTORound
    {
        public string roundID;
        public string roundName;
        public string seasonID;

        public DTORound() { }

        public DTORound(string _roundID, string _roundName, string _seasonID)
        {
            this.roundName = _roundName;
            this.roundID = _roundID;
            this.seasonID = _seasonID;
        }
    }
}
