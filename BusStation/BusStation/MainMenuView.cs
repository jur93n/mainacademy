
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusStation
{
    public class MainMenuView
    {
        public void ShowHeader()
        {
            System.Console.WriteLine("Howdy, Traveller! How can I help you?\n");
        }
        public void ShowTripsTable(List<TripModel> trips)
        {
            Console.Clear();
            Console.WriteLine("All Trips\n");
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                Console.WriteLine($"{oneTrip.Id} | {oneTrip.DepartureTime.ToShortDateString()}  | {oneTrip.TripFrom} -> {oneTrip.TripTo} | {oneTrip.ArrivalTime.ToShortDateString()} | {oneTrip.Bus.Name}({oneTrip.Bus.Capacity}) | {oneTrip.TicketPrice}");
            }
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu\n");
            System.Console.WriteLine("1 - Show All");//Done
            System.Console.WriteLine("2 - Find trip by Id");//Done
            System.Console.WriteLine("3 - Find trip by Destination");//Done
            System.Console.WriteLine("4 - Find ways for today");
            System.Console.WriteLine("5 - Find ways the next seven days");
            System.Console.WriteLine("6 - Find tickets for your price");
            System.Console.WriteLine("7 - Show trips whith free seats");
            System.Console.WriteLine("8 - Login like Admin");
            System.Console.WriteLine("9 - Exit application");
        }
        private void ShowTripsHeader()
        {
            System.Console.WriteLine("№   DEPARTURE   FROM          TO         ARRIVAL    BUS  (SEATS)   PRICE");
        }
        public void FindTripById(List<TripModel> trips)
        {
            Console.Clear();            
            Console.WriteLine("Find trip by Id\n");            
            var _input = new InputComponent();
            var _id = _input.GetInputId();
            foreach (var oneTrip in trips)
            {
                if (_id == oneTrip.Id)
                {
                    Console.Clear();
                    Console.WriteLine("Find trip by Id\n");
                    ShowTripsHeader();
                    Console.WriteLine($"{oneTrip.Id} | {oneTrip.DepartureTime.ToShortDateString()}  | {oneTrip.TripFrom} -> {oneTrip.TripTo} | {oneTrip.ArrivalTime.ToShortDateString()} | {oneTrip.Bus.Name}({oneTrip.Bus.Capacity}) | {oneTrip.TicketPrice}");
                }
            }
            
        }
        public void FindTripByDest(List<TripModel> trips)
        {
            Console.Clear();
            Console.WriteLine("Find trip by Destination\n");
            var _input = new InputComponent();
            var _dest = _input.GetInputDest();
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                if (oneTrip.TripTo.Contains(_dest))
                {
                    Console.WriteLine($"{oneTrip.Id} | {oneTrip.DepartureTime.ToShortDateString()}  | {oneTrip.TripFrom} -> {oneTrip.TripTo} | {oneTrip.ArrivalTime.ToShortDateString()} | {oneTrip.Bus.Name}({oneTrip.Bus.Capacity}) | {oneTrip.TicketPrice}");
                }
            }
        }
        public void FindWaysForToday(List<TripModel> trips)
        {
            Console.Clear();
            Console.WriteLine("Find ways for today (1 of january 2022)\n");
            var _input = new InputComponent();
            var _date = _input.FindWaysForToday();
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                if (_date == oneTrip.DepartureTime)
                {
                    Console.WriteLine($"{oneTrip.Id} | {oneTrip.DepartureTime.ToShortDateString()}  | {oneTrip.TripFrom} -> {oneTrip.TripTo} | {oneTrip.ArrivalTime.ToShortDateString()} | {oneTrip.Bus.Name}({oneTrip.Bus.Capacity}) | {oneTrip.TicketPrice}");
                }
            }
        }
        public void WaysForNextSevenDays(List<TripModel> trips)
        {
            Console.Clear();
            Console.WriteLine("Find ways from 1 to 7 of january 2022\n");
            var _input = new InputComponent();
            var _date = _input.WaysForNextSevenDays();
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                if (oneTrip.DepartureTime <= _date)
                {
                    Console.WriteLine($"{oneTrip.Id} | {oneTrip.DepartureTime.ToShortDateString()}  | {oneTrip.TripFrom} -> {oneTrip.TripTo} | {oneTrip.ArrivalTime.ToShortDateString()} | {oneTrip.Bus.Name}({oneTrip.Bus.Capacity}) | {oneTrip.TicketPrice}");
                }
            }
        }
        public void FindCheapTickets(List<TripModel> trips)
        {
            Console.Clear();
            var _input = new InputComponent();
            var _cheaperPrice = _input.FindCheapTickets();
            Console.WriteLine($"Find tickets cheap then {_cheaperPrice} UAH\n");
            Console.Clear();
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                if (oneTrip.TicketPrice <= _cheaperPrice)
                {
                    Console.WriteLine($"{oneTrip.Id} | {oneTrip.DepartureTime.ToShortDateString()}  | {oneTrip.TripFrom} -> {oneTrip.TripTo} | {oneTrip.ArrivalTime.ToShortDateString()} | {oneTrip.Bus.Name}({oneTrip.Bus.Capacity}) | {oneTrip.TicketPrice}");
                }
            }
        }
        public void ShowFreeSeats(List<TripModel> trips)
        {
            Console.Clear();
            var _input = new InputComponent();            
            Console.WriteLine("Show ways with free seats\n");
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                if (oneTrip.Bus.Capacity > 0)
                {
                    Console.WriteLine($"{oneTrip.Id} | {oneTrip.DepartureTime.ToShortDateString()}  | {oneTrip.TripFrom} -> {oneTrip.TripTo} | {oneTrip.ArrivalTime.ToShortDateString()} | {oneTrip.Bus.Name}({oneTrip.Bus.Capacity}) | {oneTrip.TicketPrice}");
                }
            }
        }
        public void AdminLogin()
        {
            Console.Clear();
            var _realPass = "admin";
            var _input = new InputComponent();
            var _inputPass = _input.AdminPass();
            var _adminController = new AdminController();
            Console.WriteLine("Login to Admin Panel");            
            if (_inputPass == _realPass)
            {
                Console.Clear();
                Console.WriteLine("Welocome, Admin!\n");
                Console.WriteLine("1 - Add new Trip by Id");
                Console.WriteLine("2 - Remove Trip by Id");
                _adminController.RunAdmin();
            }
            else
            {
                AdminLogin();
                BackToMainMenu();
            }
        }
        
        public void BackToMainMenu()
        {
            Console.Write("\nPress <Backspace> and back to Main Menu...");
            while (Console.ReadKey().Key != ConsoleKey.Backspace) { }

        }
    }
}