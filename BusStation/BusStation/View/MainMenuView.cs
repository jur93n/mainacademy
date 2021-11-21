using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.Model;

namespace BusStation.View
{
    public class MainMenuView
    {
        public event Action<int> InputIdEvent;
        public event Action<string> InputDestEvent;
        public event Action<DateTime> InputWaysForTodayEvent;
        public event Action<DateTime> InputWaysForNextSevenDaysEvent;
        public event Action<int> InputPriceEvent;
        public event Action FreeSeatsEvent;
        public event Action<string> InputAdminPassEvent;

        public void ShowHeader()
        {
            Console.WriteLine("Howdy, Traveller! How can I help you?\n");
        }

        private void ShowTripsHeader()
        {
            Console.WriteLine("{0, -3} {1, -10} {2, -15} {3, -10} {4, -15} {5, -10} {6, -10} {7, -5}\n",
                                     "№", "DEPARTURE", "FROM", "TO", "ARRIVAL", "BUS", "(SEATS)", "PRICE");
        }

        public void ShowTripsTable(List<TripModel> trips)
        {
            Console.Clear();
            Console.WriteLine("Trips Table:\n");
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                Console.WriteLine("{0, -3} {1, -10} {2, -15} {3, -10} {4, -15} {5, -10} {6, -10} {7, -5}",
                                 $"{oneTrip.Id}", $"{oneTrip.DepartureTime.ToShortDateString()}", $"{oneTrip.TripFrom}",
                                 $"{oneTrip.TripTo}", $"{oneTrip.ArrivalTime.ToShortDateString()}", $"{oneTrip.Bus.Name}",
                                 $"({oneTrip.Bus.Capacity})", $"{oneTrip.TicketPrice}");
            }
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu\n");
            Console.WriteLine("1 - Show all trips");
            Console.WriteLine("2 - Find trip by Id");
            Console.WriteLine("3 - Find trip by destination");
            Console.WriteLine("4 - Find ways for today");
            Console.WriteLine("5 - Find ways for the next seven days");
            Console.WriteLine("6 - Find tickets for your price");
            Console.WriteLine("7 - Show trips whith free seats");
            Console.WriteLine("8 - Login to admin panel");
            Console.WriteLine("9 - Exit application");
        }
        
        public void InputTripId()
        {
            Console.Clear();            
            Console.WriteLine("Find trip by Id\n");
            Console.Write("Input integer: ");
            var _id = int.Parse(Console.ReadLine());
            InputIdEvent?.Invoke(_id);            
        }

        public void InputTripDest()
        {
            Console.Clear();
            Console.WriteLine("Find trip by Destination\n");
            Console.Write("Input yout Destination: ");            
            var _dest = Console.ReadLine();
            InputDestEvent?.Invoke(_dest);
        }

        public void InputWaysForToday()
        {
            Console.Clear();
            Console.WriteLine("Find ways for today (1 of january 2022)\n");            
            DateTime _date = new DateTime(2022, 1, 1);
            InputWaysForTodayEvent?.Invoke(_date);
        }

        public void InputForNextSevenDays()
        {
            Console.Clear();
            Console.WriteLine("Find ways from 1 to 7 of january 2022\n");
            DateTime _date = new DateTime(2022, 1, 7);
            InputWaysForNextSevenDaysEvent?.Invoke(_date);
        }
        
        public void InputPriceTickets()
        {
            Console.Clear();
            Console.WriteLine($"Find tickets for your price\n");
            Console.Write("Input your max price: ");
            var _price = int.Parse(Console.ReadLine());
            InputPriceEvent?.Invoke(_price);
        }
        
        public void ShowFreeSeats()
        {
            Console.Clear();                      
            Console.WriteLine("Show Buses with free seats\n");
            FreeSeatsEvent?.Invoke();
        }

        public void AdminLogin()
        {
            Console.Clear();
            Console.WriteLine("Your try to login in admin Panel\n");
            Console.Write("Enter admin password: ");
            var _pass = Console.ReadLine();
            InputAdminPassEvent?.Invoke(_pass);
        }

        public void WrongAdminPass()
        {
            Console.Clear();
            Console.WriteLine("ERROR! Wrong password try again\n");
            Console.Write("Enter admin password: ");
            var _pass = Console.ReadLine();
            InputAdminPassEvent?.Invoke(_pass);
        }
               
        public void BackToMainMenu()
        {
            Console.Write("\nPress <Backspace> and back to Main Menu...");
            while (Console.ReadKey().Key != ConsoleKey.Backspace) { }

        }
    }
}