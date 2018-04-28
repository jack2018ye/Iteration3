using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IEProject.Models
{
    public class BuildingsNearby
    {

        public double distance { get; set; }
        public string address { get; set; }
        public string type { get; set; }
        public string industrydesc { get; set; }

        public string accessdesc { get; set; }
        public string accesstype { get; set; }
        public int accessrate { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }

    }
}