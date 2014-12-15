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

        //Sang test
        //Demo get len mot truong lay len dc ko a m????
        /// <summary>
        /// Neu muon lay len ma can dieu kien DataExecute.Instance.createSqlCmd(""/*Truyen vao storeprocedure*/, Object[condition1, condition2...])
        /// Hoac  DataExecute.Instance.createSqlCmd(""/*Truyen vao storeprocedure*/,DTOObject)
        /// Lay khong co dieu kien  DataExecute.Instance.createSqlCmd("")
        /// "": la ten store
        /// </summary>
        /// <returns>Tra ve mot SqlCommand, tuc la giong mot cau lenh trong SQL</returns> tao muon lay dua vao ten cua cardtype co ma????
        public DataTable getCardTypeName()
        {
            DataExecute.Instance.createSqlCmd("GetCardTypeName"/*Truyen vao storeprocedure*/);
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }
        //e e tu tu, may lay gia tri len thi sao ma biet dc no co id bao nhieu ma truyen vo, may phai truyen ten vao chu???
        //May thich lay theo Id hay Name thi tuy :D :D
        //Nhung ma neu cai cartTypeName no trung thi lay len nhieu dong do nghe, roi de lam thu

        public DataTable getCardTypeIdByName(string cardTypeName)
        {
            DataExecute.Instance.createSqlCmd("GetCardTypeIdByName"/*Truyen vao storeprocedure*/, new object[1] { cardTypeName });
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
