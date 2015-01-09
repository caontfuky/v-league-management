using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcessLayer;
using System.Data;
using DataTransferObject;

namespace BusinnessLogicLayer
{
    public class BUSRound
    {
        DALRound m_round;

        public BUSRound()
        {
            this.m_round = new DALRound();
        }

        public DataTable getAllData()
        {
            return m_round.getAllData();
        }

        public string getMaxRoundIDBySeasonID()
        {
            return m_round.getMaxRoundIDBySeasonID();
        }

        public DataTable getAllRoundValueBySeasonID(string seasonID)
        {
            return m_round.getAllRoundValueBySeasonID(seasonID);
        }

        public DataTable getIDRoundByName(string roundName)
        {
            return m_round.getIDRoundByName(roundName);
        }

        public int updateData(DTORound _dtoRound)
        {
            return m_round.updateData(_dtoRound);
        }

        public int deleteData(string roundID)
        {
            return m_round.deleteData(roundID);
        }

        public int insertData(DTORound _dtoRound)
        {
            return m_round.insertData(_dtoRound);
        }
    }
}
