using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon_API.Models
{
   public class Selections
   {
      public int id { get; set; }
      public string decimalnum { get; set; }
      public string fraction { get; set; }
      public string american { get; set; }
      public bool frozen { get; set; }
      public string selectionName { get; set; }
      public string selectionName2 { get; set; }
      public string selectionNameTranslation { get; set; }
      public string numerator { get; set; }
      public string denominator { get; set; }
      public string additionalValue { get; set; }
      public EachWay eachWay { get; set; }
      public RaceInfo raceInfo { get; set; }
      public int participantId { get; set; }
   }         
}