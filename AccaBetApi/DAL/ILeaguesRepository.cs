using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccaBetApi.Models;

namespace AccaBetApi.DAL
{
    public interface ILeaguesRepository:IDisposable
    {
        List<League> GetAllLeagues();

        League GetLeagueByID(int? id);
    }
}
