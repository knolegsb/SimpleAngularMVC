using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAngularMVC.Models
{
    public class TalkRepository
    {
        public Talks[] GetTalks()
        {
            var talks = new[]
            {
                new Talks { Id = 1001, Name = "Real Time Web Applications with SignalR", Speaker = "Sean You", Venue = "Hall 101", Duration = "45m" },
                new Talks { Id = 1002, Name = "Power of Node.js", Speaker = "Earnest Hemington", Venue = "Hall 102", Duration = "45m" },
                new Talks { Id = 1003, Name = "Getting started with AngularJS", Speaker = "Monte Vista", Venue = "Hall 103", Duration = "60m" },
                new Talks { Id = 1004, Name = "Microsoft Azure - Your cloud destination", Speaker = "Gaurav mantri", Venue = "Hall 104", Duration = "45m" }
            };
            return talks;
        }

        public Speakers[] GetSpeakers()
        {
            var speakers = new[]
            {
                new Speakers { Id="S001", Name="Sean You", Expertise="Client Script, ASP.NET", TalkDelivered=28 },
                new Speakers { Id="S002", Name="Hansome Boy", Expertise="Node.js, WCF", TalkDelivered=54 },
                new Speakers { Id="S003", Name="Lonsome Girl", Expertise="Microsoft Azure", TalkDelivered=68 }
            };
            return speakers;
        }
    }
}