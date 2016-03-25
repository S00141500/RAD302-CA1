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
    public class LeaguesController : ApiController
    {
        private ILeaguesRepository repo;

        public LeaguesController()
        {
            repo = new LeagueRepository(new AppContext());
        }
        // GET: api/Leagues
        public IQueryable<League> GetLeagues()
        {
            return repo.GetAllLeagues();
        }

        // GET: api/Leagues/5
        [ResponseType(typeof(League))]
        public IHttpActionResult GetLeague(int id)
        {
            League league = repo.GetLeagueByID(id);
            if (league == null)
            {
                return NotFound();
            }

            return Ok(league);
        }

        // get league by country
        [Route("api/Leagues/{country_id}/leagueCountry")]
        [ResponseType(typeof(League))]
        public IHttpActionResult GetLeagueByCountry(int country_id)
        {
            List<League> league = repo.GetLeagueByCountry(country_id);
            if (league == null)
            {
                return NotFound();
            }

            return Ok(league);
        }

        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
               repo.Dispose();
            }
            //base.Dispose(disposing);
        }

        
    }
}