using System;
using System.Collections.Generic;
using System.Linq;
using DataTransferObject;
using DataAcessLayer;
using System.Data;
using System.Text;

namespace BusinnessLogicLayer
{
    public class BUSRound
    {
        public DALRound m_dalRound;

        public BUSRound()
        {
            m_dalRound = new DALRound();
        }

        public DataTable getDataBySeasonID(string seasonID)
        {
            return m_dalRound.getDataBySeasonID(seasonID);
        }

        public DataTable getDataBySeasonIDAndRoundName(string seasonID, string roundName)
        {
            return m_dalRound.getDataBySeasonIDAndRoundName(seasonID, roundName);
        }

        public int updateData(DTORound _dtoRound)
        {
            return m_dalRound.updateData(_dtoRound);
        }

        public int deleteData(string roundID)
        {
            return m_dalRound.deleteData(roundID);
        }

        public int insertData(DTORound _dtoRound)
        {
            return m_dalRound.insertData(_dtoRound);
        }

    }
}
