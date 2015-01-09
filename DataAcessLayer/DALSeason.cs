using DataTransferObject.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataTransferObject;

namespace DataAcessLayer
{
    public class DALSeason
    {
        public DALSeason() { }

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllSeasonValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getAllSeasonName()
        {
            DataExecute.Instance.createSqlCmd("GetAllSeasonNameValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }


        public DataTable getIDSeasonByName(string seasonName)
        {
            DataExecute.Instance.createSqlCmd("GetIDSeasonByName", new object[1] { seasonName });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }
        
        public int updateData(DTOSeason _dtoSeason)
        {
            if (_dtoSeason != null)
            {
                DataExecute.Instance.createSqlCmd("UpdateSeasonValue", ref _dtoSeason);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteData(string seasonID)
        {
            if (seasonID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteSeasonValue", new object[1] { seasonID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int insertData(DTOSeason _dtoSeason)
        {
            if (_dtoSeason != null)
            {
                DataExecute.Instance.createSqlCmd("InsertSeasonValue", ref _dtoSeason);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
