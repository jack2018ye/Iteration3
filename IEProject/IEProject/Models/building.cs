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
    
    public partial class building
    {
        public int Id { get; set; }
        public string Trading_name { get; set; }
        public string Industry_description { get; set; }
        public string Location { get; set; }
        public string Street_address { get; set; }
        public string Accessibility_type { get; set; }
        public string Accessibility_type_description { get; set; }
        public int Accessibility_rating { get; set; }
        public string Area { get; set; }
    }
}