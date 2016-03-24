using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccaBetApi.Models;

namespace AccaBetApi.DAL
{
    public class LeagueRepository : ILeaguesRepository
    {
        private AppContext context;

        public LeagueRepository(AppContext context)
        {
            context = this.context;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<League> GetAllLeagues()
        {
            throw new NotImplementedException();
        }

        public League GetLeagueByID(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
