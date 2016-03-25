using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccaBetApi.Models;
using System.Web.Http.Cors;

namespace AccaBetApi.DAL
{
    [EnableCors(origins: "http://localhost:16901", headers: "*", methods: "*")]
    public class TeamRepository : ITeamsRepository
    {
        private AppContext context;

        public TeamRepository(AppContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<Team> GetAllTeams()
        {
            return context.Teams;
        }

        public Team GetTeamByID(int? id)
        {
           Team team = context.Teams.Find(id);
            return team;
        }

        public List<Team> GetLeagueByCountry(int? id)
        {
            var teams = from t in context.Teams where t.LeagueID == id select t;


            return teams.ToList();
        }
    }
}
