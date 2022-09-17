using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon_API.Models
{
   public class Tournaments
   {
      public int id { get; set; }
      public string name { get; set; }
      public string Translation { get; set; }
      public int sportId { get; set; }
      public int countryId { get; set; }
      public int live { get; set; }
      public int prematch { get; set; }
      public string meetingDate { get; set; }
   }
}