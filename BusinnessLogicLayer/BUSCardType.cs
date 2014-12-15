using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcessLayer;
using System.Data;
using DataTransferObject;

namespace BusinnessLogicLayer
{
    public class BUSCardType
    {
        DALCardType m_dalCardType;
        public BUSCardType()
        {
            this.m_dalCardType = new DALCardType();
        }

        public DataTable getCardTypeName()
        {
            return m_dalCardType.getCardTypeName();
        }

        public DataTable getCardTypeIdByName(string cardTypeName)
        {
            return m_dalCardType.getCardTypeIdByName(cardTypeName);
        }

        public DataTable getAllData()
        {
            return m_dalCardType.getAllData();
        }

        public int updateData(DTOCardType _dtoCardType)
        {
            return m_dalCardType.updateData(_dtoCardType);
        }

        public int deleteData(string cardTypeID)
        {
            return m_dalCardType.deleteData(cardTypeID);
        }

        public int insertData(DTOCardType _dtoCardType)
        {
            return m_dalCardType.insertData(_dtoCardType);
        }

    }
}
