using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccaBetApi.Models;

namespace AccaBetApi.DAL
{
    public class TeamRepository : ITeamsRepository
    {
        private AppContext context;

        public TeamRepository(AppContext context)
        {
            context = this.context;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Team> GetAllTeams()
        {
            throw new NotImplementedException();
        }

        public Team GetTeamByID(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
