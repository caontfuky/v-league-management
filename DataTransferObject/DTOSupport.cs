using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOSupport
    {
        public string name;
        public int value;

        public DTOSupport() { }

        public DTOSupport(string _name, int _value)
        {
            this.name = _name;
            this.value = _value;
        }

       
    }
}
