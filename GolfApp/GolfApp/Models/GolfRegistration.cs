using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfApp.Models
{
    public class GolfRegistration
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Handicap { get; set; }
        public string GUINumber { get; set; }
    }
}