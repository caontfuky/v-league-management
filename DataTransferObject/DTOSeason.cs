using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOSeason
    {
        public string seasonID;
        public string seasonName;
        public DateTime startDate;
        public DateTime endDate;
        public string sponsor;
        public Int64 expenditure;

        public DTOSeason() { }

        public DTOSeason(string _seasonID, string _seasonName, DateTime _startDate, DateTime _endDate, string _sponsor, Int64 _expenditure)
        {
            this.seasonID = _seasonID;
            this.seasonName = _seasonName;
            this.startDate = _startDate;
            this.endDate = _endDate;
            this.sponsor = _sponsor;
            this.expenditure = _expenditure;
        }

       
    }
}
