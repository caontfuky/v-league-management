using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;
using DataTransferObject;
using System.Data;

namespace BusinnessLogicLayer
{
    public class BUSTeam
    {
        DALTeam m_dalTeam;

        public BUSTeam()
        {
            m_dalTeam = new DALTeam();
        }

        public DataTable getAllData()
        {
            return m_dalTeam.getAllData();
        }

        public DataTable getTeamByTeamID(string teamID)
        {
            return m_dalTeam.getTeamByTeamID(teamID);
        }

        public DataTable getTeamNotInSeasonID(string seasonID)
        {
            return m_dalTeam.getTeamNotInSeasonID(seasonID);
        }

        public DataTable getTeamBySeasonName(string seasonName)
        {
            return m_dalTeam.getTeamBySeasonName(seasonName);
        }

        public DataTable getTeamBySeasonNameAndTeamName(string seasonName, string teamName)
        {
            return m_dalTeam.getTeamBySeasonNameAndTeamName(seasonName, teamName);
        }

        public DataTable getTeamBySeasonNameAndTeamID(string seasonName, string teamID)
        {
            return m_dalTeam.getTeamBySeasonNameAndTeamID(seasonName, teamID);
        }

        public DataTable getTeamIDByTeamName(string teamName)
        {
            return m_dalTeam.getTeamIDByTeamName(teamName);
        }

        public int insertTeam(DTOTeam _dtoTeam)
        {
            return m_dalTeam.insertData(_dtoTeam);
        }

        public int updateTeam(DTOTeam _dtoTeam)
        {
            return m_dalTeam.updateData(_dtoTeam);
        }

        public int deleteTeamDataFromSeason(string seasonID, string teamID)
        {
            return m_dalTeam.deleteTeamDataFromSeason(seasonID, teamID);
        }

        public int deleteTeamData( string teamID)
        {
            return m_dalTeam.deleteTeamData(teamID);
        }
    }
}
