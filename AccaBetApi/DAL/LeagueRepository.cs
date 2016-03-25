using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccaBetApi.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web.Http.Cors;

namespace AccaBetApi.DAL
{
    [EnableCors(origins: "http://localhost:16901", headers: "*", methods: "*")]

    public class LeagueRepository : ILeaguesRepository
    {
        private AppContext context;
        
        public LeagueRepository(AppContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<League> GetAllLeagues()
        {
            return context.Leagues.AsQueryable();
        }

        public League GetLeagueByID(int? id)
        {
            League league = context.Leagues.Find(id);
            return league;
        }

        public List<League> GetLeagueByCountry(int? id)
        {
            var leagues = from l in context.Leagues where l.CountryID == id select l;


            return leagues.ToList();
        }
    }
}
