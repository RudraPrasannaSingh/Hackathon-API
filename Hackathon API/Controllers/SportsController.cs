using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Hackathon_API.Models;

namespace Hackathon_API.Controllers
{
   public class SportsController : ApiController
   {
      [HttpGet]
      [Route("api/sports/{sportIds}/tournaments")]
      public List<Tournaments> GetTournaments(int[] sportsIds, int[] countryIds, string languageCode)
      {
         List<Tournaments> tournaments = new List<Tournaments>();

         return tournaments;
      }

      [HttpGet]
      [Route("api/sports")]
      public List<Sports> GetSports()
      {
         List<Sports> sports = new List<Sports>();
         return sports;
      }

   }
}
