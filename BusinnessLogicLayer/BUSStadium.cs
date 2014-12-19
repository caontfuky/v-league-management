using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataAcessLayer;
using System.Data;

namespace BusinnessLogicLayer
{
    public class BUSStadium
    {
        public DALStadium m_dalStadium;

        public BUSStadium()
        {
            m_dalStadium = new DALStadium();
        }

        public DataTable getAllData()
        {
            return m_dalStadium.getAllData();
        }

        public DataTable getStadiumIDByStadiumName(string stadiumName)
        {
            return m_dalStadium.getStadiumIDByStadiumName(stadiumName);
        }

        public int updateData(DTOStadium _dtoStadium)
        {
            return m_dalStadium.updateData(_dtoStadium);
        }

        public int deleteData(string stadiumID)
        {
            return m_dalStadium.deleteData(stadiumID);
        }

        public int insertData(DTOStadium _dtoStadium)
        {
            return m_dalStadium.insertData(_dtoStadium);
        }
    }
}
