// ***********************************************************************
// Assembly         : IEProject
// Author           : Kenneth
// Created          : 03-23-2018
//
// Last Modified By : Kenneth
// Last Modified On : 03-28-2018
// ***********************************************************************
// <copyright file="HomeController.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary>This is a controller class that determines what request to send back to the user when a request is made on the website.
// This controller is part of the MVC design pattern. This class controls all the action links on the website.</summary>
// ***********************************************************************
using IEProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.IO;
using System.Web.Mvc;
using System.Device.Location;
using System.Linq;
using System.Text.RegularExpressions;

using System.Linq.Expressions;
using System.Net;
using System.Xml.Linq;
using Geocoding.Google;
using Geocoding;
using System.Web;

/// <summary>
/// The Controllers namespace.
/// </summary>
namespace IEProject.Controllers
{
    /// <summary>
    /// Class HomeController.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class HomeController : Controller
    {
        /// <summary>
        /// The database
        /// </summary>
        private AccessibilityEntities db = new AccessibilityEntities();
        /// <summary>
        /// This method returns the landing page of the website.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// This method returns the About page of the website.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// This method returns the contact page of the website.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        /// <summary>
        /// This method returns the Wheelchair Public Toilet page upon clicking the menu button that is named Wheelchair public toilets.
        /// </summary>
        /// <returns>ActionResult.</returns>
        /// 
        
        [HttpGet]
        public ActionResult JourneyPlanner()
        {
            ViewBag.Message = "Wheelchair public toilets.";
            var model = new PublicToiletForm();
            var PublicToilets = new List<PublicToilet>();
            PublicToilets = db.PublicToilets.ToList();



            return View(model);
        }

        /// <summary>
        /// This is a post method that returns the nearest Wheelchair accessibility toilets after the destination address has been typed into the search box.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>ActionResult.</returns>
        /// 
        [HttpPost]
        public ActionResult JourneyPlanner(PublicToiletForm model)
        {

            ViewBag.Message = "Journey Planner.";
            IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "AIzaSyCF8dUfrXUwf5-fqeBOTJNPBw4iYYsI_bk" };

            IEnumerable<Address> addresses = new List<Address>();
            if (model.Address != null)
            {
                 addresses = geocoder.Geocode(model.Address);
            }

            if (addresses.Any() == true)
            {
                model.Latitude = addresses.First().Coordinates.Latitude;
                model.Longitude = addresses.First().Coordinates.Longitude;
            }else
            {
                model.Address = "";
            }
            
            
            var PublicToilets = new List<PublicToilet>();
            var TrainStations = new List<TrainStation>();
            var Buildings = new List<building>();
            var parkingspots = new List<Parking>();
            PublicToilets = db.PublicToilets.ToList();
            TrainStations = db.TrainStations.ToList();
            var something = new List<String>();
            if (model.cafeselect == true)
                something.Add("Cafes and Restaurants");

            if (model.barselect == true)
                something.Add("Pubs, Taverns and Bars");

            if (model.convenienceselect == true)
                something.Add("Convenience Store");
            if (model.supermarketselect == true)
                something.Add("Supermarket and Grocery Stores");
            if (model.retailselect == true)
                something.Add("Clothing Retailing");
            if (model.entertainmentselect == true)
                something.Add("Entertainment Media Retailing");
            if (model.accomodationselect == true)
                something.Add("Accommodation");
            if (model.hairdressingselect == true)
                something.Add("Hairdressing and Beauty Services");





            if (something.Count() > 0)
            {
                foreach (building b in db.buildings)
                {
                    foreach (string a in something)
                    {
                        if (b.Industry_description.Equals(a))
                        {
                            
                            
                                Buildings.Add(b);
                            
                        }
                    }
                }
            }
            else
            {
                //    var buildnames = db.buildings.Select(o => new { o.Id, o.Trading_name }).Distinct();


                //    Buildings = db.buildings.Where(x => buildnames.Any(y => y.Id == x.Id)).ToList();
                Buildings = db.buildings.ToList();
            }


            //Buildings = db.buildings.Where(building => building.Trading_name.Contains("Retail")).ToList(); 
            parkingspots = db.Parkings.ToList();
            GeoCoordinate distanceFrom = new GeoCoordinate();
            GeoCoordinate distanceTo = new GeoCoordinate();
            model.toilets = PublicToilets;
            model.stations = TrainStations;
            model.buildings = Buildings;
            distanceFrom.Latitude = model.Latitude;
            distanceFrom.Longitude = model.Longitude;
            List<ToiletNearby> ordered = new List<ToiletNearby>();
            List<StationsNearby> nearest = new List<StationsNearby>();
            List<BuildingsNearby> nearestbuilding = new List<BuildingsNearby>();
            List<ParkingNearby> nearestparking = new List<ParkingNearby>();



            /// <summary>
            /// This is a for loop that calculates the distance for all the wheelchair public toilets from the destination address, and adds them to a new List.
            /// </summary>
            foreach (var toilet in PublicToilets)
            {
                string[] tempLocation = toilet.location.Trim().Substring(toilet.location.IndexOf("(") + 1, toilet.location.LastIndexOf(")") - 1).Split(',');
                double latitude = Double.Parse(tempLocation[0]);
                double longitude = Double.Parse(tempLocation[1]);
                distanceTo.Latitude = latitude;
                distanceTo.Longitude = longitude;
                ordered.Add(new ToiletNearby { name = toilet.name,wheelchair=toilet.wheelchair,male=toilet.male,female=toilet.female, distance = Math.Round(distanceFrom.GetDistanceTo(distanceTo), 0), address = toilet.Address,latitude=toilet.lat,longitude=toilet.lon });
            }

            foreach (var station in TrainStations)
            {
                string[] tempLocation = station.location.Trim().Substring(station.location.IndexOf("(") + 1, station.location.LastIndexOf(")") - 1).Split(',');
                double latitude = Double.Parse(tempLocation[0]);
                double longitude = Double.Parse(tempLocation[1]);
                distanceTo.Latitude = latitude;
                distanceTo.Longitude = longitude;
                nearest.Add(new StationsNearby { name = station.station, distance = Math.Round(distanceFrom.GetDistanceTo(distanceTo), 0),lift=station.lift,lat=latitude,lon=longitude });
            }
            foreach (var building in Buildings)
            {
                if (building.Location.Length > 0)
                {
                    if (building.Location.Length > 2)
                    {
                        if (building.Location.StartsWith("(") && building.Location.EndsWith(")"))
                        {
                            building.Location = building.Location.Substring(1, building.Location.Length - 2);
                        }
                    }
                    string[] tempLocation = building.Location.Trim().Substring(0, building.Location.Length - 1).Split(',');
                    string w = tempLocation[0].Trim();
                    string b = tempLocation[1].Trim();
                    double latitude = Double.Parse(w);
                    double longitude = Double.Parse(b);

                    distanceTo.Latitude = latitude;
                    distanceTo.Longitude = longitude;

                    nearestbuilding.Add(new BuildingsNearby { distance = Math.Round(distanceFrom.GetDistanceTo(distanceTo), 0), address = building.Street_address, type = building.Trading_name,industrydesc=building.Industry_description,accesstype=building.Accessibility_type,accessdesc=building.Accessibility_type_description,accessrate=building.Accessibility_rating,lat = latitude,lon= longitude });
                }
            }

            foreach (var parkingspot in parkingspots)
            {

                double latitude = parkingspot.lat;
                double longitude = parkingspot.lon;
                distanceTo.Latitude = latitude;
                distanceTo.Longitude = longitude;
                nearestparking.Add(new ParkingNearby { distance = Math.Round(distanceFrom.GetDistanceTo(distanceTo), 0), id = parkingspot.BayId,lat=parkingspot.lat,lon=parkingspot.lon });
            }

            /// <summary>
            /// This sorts all items in the list named ordered and adds the top 5 items(wheelchair public toilets) to another list.
            /// </summary>
            //if (model.select == false)
            //{
            //    model.Address = "";
            //}
            var regex = "^[#.0-9a-zA-Z\\s,-]+$";
            Match match = Regex.Match(model.Address ?? "", regex, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                List<StationsNearby> SortedTrains = nearest.OrderBy(a => a.distance).ToList();
                List<ToiletNearby> SortedList = ordered.OrderBy(a => a.distance).ToList();
                List<BuildingsNearby> SortedBuildings = nearestbuilding.OrderBy(a => a.distance).ToList();
                List<ParkingNearby> SortedParkingspots = nearestparking.OrderBy(a => a.distance).ToList();

                int to = 3;
                if (SortedList.Count < to)
                    to = SortedBuildings.Count;
                for (int i = 0; i < to; i++)
                {
                    if (SortedList[i].distance <= 1000)
                    {

                        model.sorttoilets.Add(SortedList[i]);

                        model.sorttoilets[i].name = model.sorttoilets[i].name.Substring(model.sorttoilets[i].name.LastIndexOf('-') + 1);

                    }

                }
                for (int i = 0; i < 1; i++)
                {

                    model.sorttrains.Add(SortedTrains[i]);




                }
                if (SortedBuildings.Count > 0)

                {
                    int co = 7;
                    if ( SortedBuildings.Count<co)
                        co = SortedBuildings.Count;
                    for (int i = 0; i < co; i++)
                    {

                       
                            model.sortbuildings.Add(SortedBuildings[i]);
                        



                    }
                }
                for (int i = 0; i < 5; i++)
                {

                    model.sortparkingspots.Add(SortedParkingspots[i]);




                }

                return View(model);
            }
            else
            {
                model.sorttoilets.Clear();
                model.sortbuildings.Clear();
                return View(model);
            }
        }


        
    }


}