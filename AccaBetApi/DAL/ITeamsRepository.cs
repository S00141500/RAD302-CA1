using AccaBetApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccaBetApi.DAL
{
    public interface ITeamsRepository :IDisposable
    {
        List<Team> GetAllTeams();

        Team GetTeamByID(int? id);
    }
}
