using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hackathon_API.Models;
using System.Web.Http;

namespace Hackathon_API.Controllers
{
    public class EventsController : ApiController
    {
      [HttpGet]
      [System.Web.Http.Route("api/tournaments/{tournamentIds}/events")]
      public List<Markets> Markets( )
      {
         List<Markets> markets = new List<Markets>();
         return markets;
      }
    }
}