using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon_API.Models
{
   public class Markets
   {
      public int eventId { get; set; }
      public int marketid { get; set; }
      public string marketName { get; set; }
      public string marketTranslation { get; set; }

      public EachWay EachWay { get; set; }
      public List<Selections> selections { get; set; }
      //public string participatntId { get; set; }
   }
}