using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Hackathon_API.Models;

namespace Hackathon_API.Controllers
{
    public class CountriesController : ApiController
    {
      [HttpGet]
      [Route("api/countries")]
      public List<Countries> GetCountries(string languageCode)
      {
         List<Countries> countries = new List<Countries>();
         return countries;
      }
    }
}
