using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccaBetApi.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace AccaBetApi.DAL
{
    public class LeagueRepository : ILeaguesRepository
    {
        private AppContext context;

          private string BaseApiAddress;
        private string ApiSuffix;

        public LeagueRepository(string baseAddress, string apiSuffix)
        {
            BaseApiAddress = baseAddress;
            ApiSuffix = apiSuffix;
        }

        private HttpClient CreateHttpClient()
        {
            return new HttpClient()
            {
                BaseAddress = new Uri(BaseApiAddress),
            };
        }
        

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
