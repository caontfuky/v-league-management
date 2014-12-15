using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataAcessLayer;
using System.Data;

namespace BusinnessLogicLayer
{
    public class BUSRefereee
    {
        DALReferee m_referee;

        public BUSRefereee()
        {
            this.m_referee = new DALReferee();
        }

        public DataTable getDataBySeason(string seasonName)
        {
            return m_referee.getDataBySeason(seasonName);
        }

        public int updateData(DTOReferee _dtoReferee)
        {
            return m_referee.updateData(_dtoReferee);
        }

        public int deleteData(string refereeID)
        {
            return m_referee.deleteData(refereeID);
        }

        public int insertData(DTOReferee _dtoReferee)
        {
            return m_referee.insertData(_dtoReferee);
        }
    }
}
