using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using BusStation.Controller;
using BusStation.View;
using System.IO;
using Newtonsoft.Json;

namespace BusStation.Model
{
    
    public class TripsStorage
    {        
        public static List <TripModel> Trips = new List <TripModel>
        { 
            new TripModel(1, new DateTime(2022,1,1), "Zhmerynka", new DateTime(2022,1,2), "Lviv", new BusModel("Ikarus", 8), 650 ),
            new TripModel(2, new DateTime(2022,1,6), "Kyiv", new DateTime(2022,1,7), "Bukovel", new BusModel("Isuzu", 1), 1200),
            new TripModel(3, new DateTime(2022,1,4), "Sumy", new DateTime(2022,1,5), "Ternopil", new BusModel("LAZ", 10), 1000),
            new TripModel(4, new DateTime(2022,1,4), "Vinnytsya", new DateTime(2022,1,5), "Kharkiv", new BusModel("Ikarus", 9), 1200),
            new TripModel(5, new DateTime(2022,1,5), "Zaporizhya", new DateTime(2022,1,7), "Odesa", new BusModel("Bohdan", 7), 500 ),
            new TripModel(6, new DateTime(2022,1,9), "Zhytomyr", new DateTime(2022,1,9), "Poltava", new BusModel("Sprinter", 0), 600 ),
            new TripModel(7, new DateTime(2022,1,7), "Kyiv", new DateTime(2022,1,8), "Yaremche", new BusModel("LAZ", 6), 1000),
            new TripModel(8, new DateTime(2022,1,2), "Vinnytsya", new DateTime(2022,1,2), "Lviv", new BusModel("Bohdan", 13), 700 ),
            new TripModel(9, new DateTime(2022,1,1), "Chernivtsi", new DateTime(2022,1,1), "Rivne", new BusModel("Isuzu", 0), 600 ),
            new TripModel(9, new DateTime(2022,1,9), "Odesa", new DateTime(2022,1,9), "Uzhhorod", new BusModel("Sprinter", 4), 800 )
        };

        /*public void JsonSer()
        {
            string json = JsonConvert.SerializeObject(Trips);
            Console.WriteLine(json);
        }*/

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

        public void AddTrip(List<TripModel> trips)
        {
            var _input = new InputComponent();
            var _addTrip = _input.AddTrip();
            trips.Add(_addTrip);
        }

        public void RemoveTrip(List<TripModel> trips)
        {
            Console.Clear();
            var _input = new InputComponent();
            var _id = _input.RemoveTrip();
            foreach (var oneTrip in trips)
            {
                if (oneTrip.Id.Equals(_id))
                {
                    Console.WriteLine($"\nTrip № {oneTrip.Id} with destination to {oneTrip.TripTo} from {oneTrip.TripFrom} was deleted!");
                    TripsStorage.Trips.Remove(oneTrip);
                    break;
                }
            }
        }

        public void BackToAdminMenu()
        {
            Console.Write("\nPress <Backspace> and back to Admin Menu...");
            while (Console.ReadKey().Key != ConsoleKey.Backspace) { }
            AdminMenuController adminMenuController = new AdminMenuController();
            adminMenuController.ShowAdminMenu();
        }

        public void BackToMainMenu()
        {
            Console.Write("\nPress <Backspace> and back to Main Menu...");
            while (Console.ReadKey().Key != ConsoleKey.Backspace) { }
            MainController mainController = new MainController();
            mainController.Run();
        }
    }
}