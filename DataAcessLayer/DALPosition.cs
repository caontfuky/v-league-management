using DataTransferObject;
using DataTransferObject.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAcessLayer
{
    public class DALPosition
    {
        public DALPosition() { }

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllPositionValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getPositionIDByPositionName(string positionName)
        {
            DataExecute.Instance.createSqlCmd("GetPositionIDByPositionName", new object[1] { positionName });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public int updateData(DTOPosition _dtoPosition)
        {
            if (_dtoPosition != null)
            {
                DataExecute.Instance.createSqlCmd("UpdatePositionValue", ref _dtoPosition);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteData(string positionID)
        {
            if (positionID != null)
            {
                DataExecute.Instance.createSqlCmd("DeletePositionValue", new object[1] { positionID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int insertData(DTOPosition _dtoPosition)
        {
            if (_dtoPosition != null)
            {
                DataExecute.Instance.createSqlCmd("InsertPositionValue", ref _dtoPosition);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
