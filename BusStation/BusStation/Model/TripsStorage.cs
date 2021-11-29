using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using BusStation.Controller;
using BusStation.View;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BusStation.Model
{

    public class TripsStorage
    {
        public static string JsonParse()
        {
            using StreamReader sr = new StreamReader(@"TripsBase.json");
            {
                string json = sr.ReadToEnd();
                return json;
            }
        }

        public static List<TripModel> Trips = JsonConvert.DeserializeObject<List<TripModel>>(JsonParse());

        public TripModel FindTripById(List<TripModel> trips, int id)
        {            
            var _id = id;
            foreach (var oneTrip in trips)
            {
                if (_id == oneTrip.Id)
                {
                    return oneTrip;
                }                
            }
            return null;
        }

        public List<TripModel> FindTripByDest(List<TripModel> trips, string dest)
        {
            var _dest = dest;
            var _destTrips = new List<TripModel>();
            foreach (var oneTrip in trips)
            {
                if (oneTrip.TripTo.Contains(_dest))
                {
                    _destTrips.Add(oneTrip);
                }
            }
            return _destTrips;
        }

        public List<TripModel> FindWaysForToday(List<TripModel> trips, DateTime date)
        {
            var _date = date;
            var _tripsToday = new List<TripModel>();
            foreach (var oneTrip in trips)
            {
                if (_date == oneTrip.DepartureTime)
                {
                    _tripsToday.Add(oneTrip);
                }
            }
            return _tripsToday;
        }
        
        public List<TripModel> FindWaysForNextSevenDays(List<TripModel> trips, DateTime date)
        {
            var _date = date;
            var _sevenDaysTrips = new List<TripModel>();
            foreach (var oneTrip in trips)
            {
                if (oneTrip.DepartureTime <= _date)
                {
                    _sevenDaysTrips.Add(oneTrip);
                }
            }
            return _sevenDaysTrips;
        }
        
        public List<TripModel> FindCheapTickets(List<TripModel> trips, int price)
        {
            var _price = price;
            var _cheapTrips = new List<TripModel>();
            foreach (var oneTrip in trips)
            {
                if (oneTrip.TicketPrice <= _price)
                {
                    _cheapTrips.Add(oneTrip);                    
                }                
            }
            return _cheapTrips;
        }
        
        public List<TripModel> ShowFreeSeats(List<TripModel> trips)
        {
            var _freeSeatsTrips = new List<TripModel>();
            foreach (var oneTrip in trips)
            {
                if (oneTrip.Bus.Capacity > 0)
                {
                    _freeSeatsTrips.Add(oneTrip);
                }
            }
            return _freeSeatsTrips;
        }

        public bool CheckPass(string pass)
        {
            string _pass = pass;
            if (_pass == "admin")
            {
                return true;
            }
            return false;
        }

        public void AddTrip(List<TripModel> trips, TripModel newTrip)
        {
            trips.Add(newTrip);
        }

        public void RemoveTrip(List<TripModel> trips, int id)
        {
            var _id = id;
            foreach (var oneTrip in trips)
            {
                if (oneTrip.Id.Equals(_id))
                {
                   Trips.Remove(oneTrip);
                   break; 
                }
            }
        }
    }
}