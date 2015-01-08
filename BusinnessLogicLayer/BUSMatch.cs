using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataAcessLayer;
using System.Data;

namespace BusinnessLogicLayer
{
    public class BUSMatch
    {
        public DALMatch m_dalMatch;

        public BUSMatch()
        {
            m_dalMatch = new DALMatch();
        }

        public DataTable getDataByRoundID(string roundID)
        {
            return m_dalMatch.getDataByRoundID(roundID);
        }

        public int updateData(DTOMatch _dtoMatch)
        {
            return m_dalMatch.updateData(_dtoMatch);
        }

        public int deleteData(string matchID)
        {
            return m_dalMatch.deleteData(matchID);
        }

        public int insertData(DTOMatch _dtoMatch)
        {
            return m_dalMatch.insertData(_dtoMatch);
        }

    }
}
