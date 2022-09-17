using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon_API.Models
{
   public class Event
   {
      public int id { get; set; }
      public string  name { get; set; }
      public int  sportId   { get; set; }
      public int  countryId   { get; set; }
      public int  tournamentId   { get; set; }
      public string  dateStart   { get; set; }
      public bool  isLive   { get; set; }
      public bool  isRacingEvent   { get; set; }
      public List<Teams>  Teams   { get; set; }
      public List<RaceInfo>  RaceInfos   { get; set; }
      public List<ParticipantInfo> participantInfo { get; set; }
      //public string  outright   { get; set; }
   }
}