using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObject;
using DataTransferObject.Global;
using System.Data;

namespace DataAcessLayer
{
    public class DALTeam
    {
        public DALTeam() { }

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllTeamValue");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getTeamBySeasonName(string seasonName)
        {
            DataExecute.Instance.createSqlCmd("GetTeamBySeasonName", new object[1] { seasonName });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getTeamNotInSeasonID(string seasonID)
        {
            DataExecute.Instance.createSqlCmd("GetTeamNotInSeasonID", new object[1] { seasonID });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getTeamByTeamID(string teamID)
        {
            DataExecute.Instance.createSqlCmd("GetTeamByTeamID", new object[1] { teamID });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getTeamBySeasonNameAndTeamName(string seasonName, string teamName)
        {
            DataExecute.Instance.createSqlCmd("GetTeamBySeasonNameAndTeamName", new object[2] { seasonName, teamName });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getTeamBySeasonNameAndTeamID(string seasonName, string teamID)
        {
            DataExecute.Instance.createSqlCmd("GetTeamBySeasonNameAndTeamID", new object[2] { seasonName, teamID });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }


        public DataTable getTeamIDByTeamName(string TeamName)
        {
            DataExecute.Instance.createSqlCmd("GetTeamIDByTeamName", new object[1] { TeamName });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public int insertData(DTOTeam _dtoTeam)
        {
            if(_dtoTeam != null)
            {
                DataExecute.Instance.createSqlCmd("InsertTeamValue", ref _dtoTeam);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int updateData(DTOTeam _dtoTeam)
        {
            if (_dtoTeam != null)
            {
                DataExecute.Instance.createSqlCmd("UpdateTeamValue", ref _dtoTeam);
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteTeamDataFromSeason(string seasonID, string teamID)
        {
            if (teamID != null && seasonID != null)
            {
                DataExecute.Instance.createSqlCmd("DeleteTeamValue", new object[2] { seasonID, teamID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }

        public int deleteTeamData( string teamID)
        {
            if (teamID != null )
            {
                DataExecute.Instance.createSqlCmd("DeleteTeamIntoTeamTable", new object[1] { teamID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
            }
            return 0;
        }
    }
}
