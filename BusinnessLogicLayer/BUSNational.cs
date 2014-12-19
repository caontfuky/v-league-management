using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataAcessLayer;
using System.Data;

namespace BusinnessLogicLayer
{
    public class BUSNational
    {
        DALNational m_dalNational;

        public BUSNational()
        {
            m_dalNational = new DALNational();
        }

        public DataTable getAllData()
        {
            return m_dalNational.getAllData();
        }

        public DataTable getNationalIDByNationalName(string nationalName)
        {
            return m_dalNational.getNationalIDByNationalName(nationalName);
        }

        public int updateData(DTONational _dtoNational)
        {
            return m_dalNational.updateData(_dtoNational);
        }

        public int deleteData(string nationalID)
        {
            return m_dalNational.deleteData(nationalID);
        }

        public int insertData(DTONational _dtoNational)
        {
            return m_dalNational.insertData(_dtoNational);
        }
    }
}
