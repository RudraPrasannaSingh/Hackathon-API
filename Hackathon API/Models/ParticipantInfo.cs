using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon_API.Models
{
   public class ParticipantInfo
   {
      public int id { get; set; }
      public int eventId { get; set; }
      public bool isReserve { get; set; }
      public bool isNonrunner { get; set; }
      public string selectionName { get; set; }
      public string shortname { get; set; }

      public int number { get; set; }

      public string Jockeyname { get; set; }
      public bool draw { get; set; }




   }
}