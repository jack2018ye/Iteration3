// ***********************************************************************
// Assembly         : IEProject
// Author           : Kenneth
// Created          : 03-23-2018
//
// Last Modified By : Kenneth
// Last Modified On : 03-28-2018
// ***********************************************************************
// <copyright file="PublicToiletForm.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary> This is a model class that stores all the variable values for the Wheelchair Public Toilet page. This makes it possible to store variables and
// pass them for use in the controller. The model class follows the MVC design pattern.</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/// <summary>
/// The Models namespace.
/// </summary>
namespace IEProject.Models
{
    /// <summary>
    /// Class PublicToiletForm.
    /// </summary>
    public class PublicToiletForm
    {

        public bool select { get; set; }

        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>The distance.</value>
        public double Distance { get; set; }
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>The latitude.</value>
        /// 
        [Required(ErrorMessage = "Required")]
        public double Latitude { get; set; }
        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>The longitude.</value>
        /// 
        [Required(ErrorMessage = "Required")]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        [Required(ErrorMessage = "Address field cannot be empty!!")]
        [RegularExpression("^[0-9a-zA-Z /,]+$", ErrorMessage = "Invalid address, please input a correct address.")]
        [StringLength(100, ErrorMessage = "Invalid Input")]
        public string Address { get; set; }






        /// <summary>
        /// Gets or sets the toilets.
        /// </summary>
        /// <value>The toilets.</value>
        public List<PublicToilet> toilets { get; set; }
        /// <summary>
        /// Gets or sets the sorttoilets.
        /// </summary>
        /// <value>The sorttoilets.</value>
        public List<ToiletNearby> sorttoilets { get; set; }
        public List<StationsNearby> sorttrains { get; set; }

        public List<BuildingsNearby> sortbuildings { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicToiletForm"/> class.
        /// </summary>
        /// 

        public List<ParkingNearby> sortparkingspots { get; set; }
        public List<TrainStation> stations { get; set; }

        public List<building> buildings { get; set; }

        public bool barselect { get; set; }
        public bool retailselect { get; set; }
        public bool cafeselect { get; set; }
        public bool supermarketselect { get; set; }

       
        public bool entertainmentselect { get; set; }
        public bool convenienceselect { get; set; }
        public bool accomodationselect { get; set; }
        public bool hairdressingselect { get; set; }
        public bool cartick { get; set; }
        public bool traintick { get; set; }
        public bool toilettick { get; set; }

        public string hour { get; set; }
        public string day { get; set; }

        public IEnumerable<SelectListItem> hours { get; set; }
        public IEnumerable<SelectListItem> days { get; set; }

        public  List<PedestrianVolume> pedestrians { get; set; }


    public PublicToiletForm()
        {
           pedestrians= new List<PedestrianVolume>();
            toilets = new List<PublicToilet>();
            sorttoilets = new List<ToiletNearby>();
            stations = new List<TrainStation>();
            sorttrains = new List<StationsNearby>();
            buildings = new List<building>();
            sortbuildings = new List<BuildingsNearby>();
            sortparkingspots = new List<ParkingNearby>();
          







        }


    }
}