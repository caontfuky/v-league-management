using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataAcessLayer;
using System.Data;

namespace BusinnessLogicLayer
{
    public class BUSPosition
    {
        DALPosition m_dalPosition;

        public BUSPosition()
        {
            m_dalPosition = new DALPosition();
        }

        public DataTable getAllData()
        {
            return m_dalPosition.getAllData();
        }

        public DataTable getPositionIDByPositionName(string positionName)
        {
            return m_dalPosition.getPositionIDByPositionName(positionName);
        }

        public int updateData(DTOPosition _dtoPosition)
        {
            return m_dalPosition.updateData(_dtoPosition);
        }

        public int deleteData(string positionID)
        {
            return m_dalPosition.deleteData(positionID);
        }

        public int insertData(DTOPosition _dtoPosition)
        {
            return m_dalPosition.insertData(_dtoPosition);
        }
    }
}
