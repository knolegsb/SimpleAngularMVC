using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAngularMVC.Models
{
    public class Speakers
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Expertise { get; set; }
        public int TalkDelivered { get; set; }
    }
}