using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOSeason
    {
        private string seasonID;
        private string seasonName;
        private string startDate;
        private string endDate;
        private string sponsor;
        private int expenditure;

        public DTOSeason() { }

        public DTOSeason(string _seasonID, string _seasonName, string _startDate, string _endDate, string _sponsor, int _expenditure)
        {
            this.seasonID = _seasonID;
            this.seasonName = _seasonName;
            this.startDate = _startDate;
            this.endDate = _endDate;
            this.sponsor = _sponsor;
            this.expenditure = _expenditure;
        }

        public string SeasonID
        {
            get { return seasonID; }
            set { seasonID = value; }
        }

        public string SeasonName
        {
            get { return seasonName; }
            set { seasonName = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string Sponsor
        {
            get { return sponsor; }
            set { sponsor = value; }
        }

        public int Expenditure
        {
            get { return expenditure; }
            set { expenditure = value; }
        }


    }
}
