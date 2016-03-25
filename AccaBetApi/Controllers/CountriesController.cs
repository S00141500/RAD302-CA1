using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AccaBetApi.Models;
using System.Web.Http.Cors;
using AccaBetApi.DAL;

namespace AccaBetApi.Controllers
{
    [EnableCors(origins: "http://localhost:16901", headers: "*", methods: "*")]
    public class CountriesController : ApiController
    {
        private ICountriesRepository repo;

        public CountriesController()
        {
            repo = new CountriesRepository(new AppContext());
        }
        // GET: api/Countries
        public IQueryable<Country> GetCountries()
        {
            return repo.GetAllCountries();
        }

        // GET: api/Countries/5
        [ResponseType(typeof(Country))]
        public IHttpActionResult GetCountry(int id)
        {
            Country country = repo.GetCountryByID(id);
            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repo.Dispose();
            }
            base.Dispose(disposing);
        }
        
    }
}