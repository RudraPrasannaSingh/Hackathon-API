using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon_API.Models
{
   public class RaceInfo
   {
      public string going { get; set; }
      public string isAntepost { get; set; }
      public bool racelink { get; set; }
      public bool raceName { get; set; }
      public bool raceStatus { get; set; }
   }
}