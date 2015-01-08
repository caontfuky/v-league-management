using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataTransferObject.Global;
using System.Data;

namespace DataAcessLayer
{
    public class DALStadium
    {
        public DALStadium() { }

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllStadiumValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getStadiumIDByStadiumName(string stadiumName)
        {
            DataExecute.Instance.createSqlCmd("GetStadiumIDByStadiumName", new object[1] { stadiumName });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getStadiumByStadiumID(string stadiumID)
        {
            DataExecute.Instance.createSqlCmd("GetStadiumByStadiumID", new object[1] { stadiumID });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public int updateData(DTOStadium _dtoStadium)
        {
            if (_dtoStadium != null)
            {
                DataExecute.Instance.createSqlCmd("UpdateStadiumValue", ref _dtoStadium);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteData(string stadiumID)
        {
            if (stadiumID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteStadiumValue", new object[1] { stadiumID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int insertData(DTOStadium _dtoStadium)
        {
            if (_dtoStadium != null)
            {
                DataExecute.Instance.createSqlCmd("InsertStadiumValue", ref _dtoStadium);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
