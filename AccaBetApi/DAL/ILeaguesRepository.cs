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
        IQueryable<League> GetAllLeagues();

        League GetLeagueByID(int? id);

        List<League> GetLeagueByCountry(int? country_id);
    }
}
