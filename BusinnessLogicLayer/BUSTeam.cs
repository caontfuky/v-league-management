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

        public DataTable getTeamBySeasonName(string seasonName)
        {
            return m_dalTeam.getTeamBySeasonName(seasonName);
        }

        public DataTable getTeamBySeasonNameAndTeamName(string seasonName, string teamName)
        {
            return m_dalTeam.getTeamBySeasonNameAndTeamName(seasonName, teamName);
        }

        public int insertTeam(DTOTeam _dtoTeam)
        {
            return m_dalTeam.insertData(_dtoTeam);
        }
    }
}
