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
    public class CountriesRepository : ICountriesRepository
    {
        private AppContext context;

        public CountriesRepository(AppContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<Country> GetAllCountries()
        {
            return context.Countries;
        }

        public Country GetCountryByID(int? id)
        {
            Country country = context.Countries.Find(id);
            return country;
        }
    }
}
