using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IEProject.Models
{
    public class ToiletNearby
    {
      
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string wheelchair { get; set; }
        public string male { get; set; }
        public string female { get; set; }

        public double distance { get; set; }
        public string address { get; set; }
       
    }
}