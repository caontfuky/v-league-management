using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAcessLayer;
using DataTransferObject;

namespace BusinnessLogicLayer
{
    public class BUSStanding
    {
        public BUSStanding()
        {
        }

        public DataTable getAllData()
        {
            return new DALStanding().getAllData();
        }

        public int insertData(DTOStanding dtoStanding)
        {
            return new DALStanding().insertData(dtoStanding);
        }

        public int updateData(DTOStanding dtoStanding)
        {
            return new DALStanding().updateData(dtoStanding);
        }

        public int deleteData(string seasonID, string teamID)
        {
            return new DALStanding().deleteData(seasonID, teamID);
        }
    }
}
