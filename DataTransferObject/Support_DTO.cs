using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Support_DTO
    {
        private string name;
        private int value;

        public Support_DTO() { }

        public Support_DTO(string _name, int _value)
        {
            this.name = _name;
            this.value = _value;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }


    }
}
