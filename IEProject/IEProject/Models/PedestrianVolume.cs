//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PedestrianVolume
    {
        public int Id { get; set; }
        public double Sensor_ID { get; set; }
        public string Day { get; set; }
        public int Time { get; set; }
        public int HoursCount { get; set; }
        public string Coordinates { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
