using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataAcessLayer;
using System.Data;

namespace BusinnessLogicLayer
{
    public class BUSCoach
    {
        public DALCoach m_dalCoach;

        public BUSCoach()
        {
            m_dalCoach = new DALCoach();
        }

        public DataTable getAllData()
        {
            return m_dalCoach.getAllData();
        }
        public DataTable getDataBySeason(string seasonName)
        {
            return m_dalCoach.getDataBySeason(seasonName);
        }

        public int updateData(DTOCoach _dtoCoach)
        {
            return m_dalCoach.updateData(_dtoCoach);
        }

        public int deleteData(string coachID)
        {
            return m_dalCoach.deleteData(coachID);
        }

        public int insertData(DTOCoach _dtoCoach)
        {
            return m_dalCoach.insertData(_dtoCoach);
        }

    }
}
