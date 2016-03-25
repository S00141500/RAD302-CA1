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

        public LeaguesController(ILeaguesRepository repository)
        {
            repo = repository;
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

        // PUT: api/Leagues/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutLeague(int id, League league)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != league.ID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(league).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LeagueExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/Leagues
        //[ResponseType(typeof(League))]
        //public IHttpActionResult PostLeague(League league)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Leagues.Add(league);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (LeagueExists(league.ID))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = league.ID }, league);
        //}

        //// DELETE: api/Leagues/5
        //[ResponseType(typeof(League))]
        //public IHttpActionResult DeleteLeague(int id)
        //{
        //    League league = db.Leagues.Find(id);
        //    if (league == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Leagues.Remove(league);
        //    db.SaveChanges();

        //    return Ok(league);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repo.Dispose();
            }
            base.Dispose(disposing);
        }

        //private bool LeagueExists(int id)
        //{
        //    return db.Leagues.Count(e => e.ID == id) > 0;
        //}
    }
}