﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IEProject.Models
{
    public class StationsNearby
    {
        public string name { get; set; }

        public double distance { get; set; }

        public string lift { get; set; }

        public double lat { get; set; }
        public double lon { get; set; }


    }
}