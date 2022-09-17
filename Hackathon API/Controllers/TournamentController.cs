using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Hackathon_API.Models;

namespace Hackathon_API.Controllers
{
   public class TournamentController : ApiController
   {
      [Route("api/tournaments/{tournamentIds}/events")]
      [HttpGet]
      public List<Event> Events(int[] tournamentId, int status, string dateStart)
      {
         List<Event> events = new List<Event>();
         return events;
      }

   }
}
