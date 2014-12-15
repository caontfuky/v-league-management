using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataAcessLayer;
using System.Data;

namespace BusinnessLogicLayer
{
    public class BUSSeason
    {
        DALSeason m_season;
        public BUSSeason()
        {
            this.m_season = new DALSeason();
        }

        public DataTable getAllData()
        {
            return m_season.getAllData();
        }

        public DataTable getIDSeasonByName(string seasonName)
        {
            return m_season.getIDSeasonByName(seasonName);
        }

        public DataTable getAllSeasonName()
        {
            return m_season.getAllSeasonName();
        }

        public int updateData(DTOSeason _dtoSeason)
        {
            return m_season.updateData(_dtoSeason);
        }

        public int deleteData(string seasonID)
        {
            return m_season.deleteData(seasonID);
        }

        public int insertData(DTOSeason _dtoSeason)
        {
            return m_season.insertData(_dtoSeason);
        }
    }
}
