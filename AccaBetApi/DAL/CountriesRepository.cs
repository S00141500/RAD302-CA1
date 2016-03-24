using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccaBetApi.Models;

namespace AccaBetApi.DAL
{
    public class CountriesRepository : ICountriesRepository
    {
        private AppContext context;

        public CountriesRepository(AppContext context)
        {
            context = this.context;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Country GetCountryByID(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
