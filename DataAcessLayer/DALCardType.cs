using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using System.Reflection;
using System.Data;
using DataTransferObject.Global;

namespace DataAcessLayer
{
    public class DALCardType
    {
        public DALCardType()
        {
            
        }

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllCardTypeValue");
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public int updateData(DTOCardType _dtoCardType)
        {
            if (_dtoCardType != null)
            {
                DataExecute.Instance.createSqlCmd("UpdateCardTypeValue", ref _dtoCardType);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteData(string cardTypeID)
        {
            if (cardTypeID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteCardTypeValue",new object[1]{cardTypeID});
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int insertData(DTOCardType _dtoCardType)
        {
            if (_dtoCardType != null)
            {
                DataExecute.Instance.createSqlCmd("InsertCardTypeValue", ref _dtoCardType);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

    }
}
