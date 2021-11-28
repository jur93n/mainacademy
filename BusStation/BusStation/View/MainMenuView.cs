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
        public event Action<TripModel> AddTripEvent;
        public event Action<int> RemoveTripEvent;

        /*public int MenuInput()
        {
            bool isParsed;
            int result;
            do
            {
                Console.Write("\nEnter integer, and press Enter: ");
                var userChoise = Console.ReadLine();
                isParsed = int.TryParse(userChoise, out result);
            }
            while (!isParsed);
            return result;
        }*/

        public int MenuInput()
        {
            int userInput;
            bool isParsed;
            do
            {
                int _userInput;
                Console.Write("\nEnter integer, and press Enter: ");                
                isParsed = int.TryParse(Console.ReadLine(), out _userInput);
                if (_userInput > 0 && _userInput < 9)
                {
                    return _userInput;
                }
                else
                {
                    Console.WriteLine("\nERROR! Wrong input, try again.");
                }
                userInput = _userInput;
            } while (!isParsed || userInput <= 0 || userInput > 9);
            return userInput;
        }

        public int AdminMenuInput()
        {
            bool isParsed;
            int userInput;
            do
            {
                Console.Write("\nEnter integer, and press Enter: ");
                int _userInput;
                isParsed = int.TryParse(Console.ReadLine(), out _userInput);
                if (_userInput > 0 && _userInput < 3)
                {
                    return _userInput;
                }
                else
                {
                    Console.WriteLine("\nERROR! Wrong input, try again.\n");
                }
                userInput = _userInput;
            } while (!isParsed || userInput <= 0 || userInput > 2);
            return userInput;
        }

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
            try
            {
                foreach (var oneTrip in trips)
                {
                    Console.WriteLine("{0, -3} {1, -10} {2, -15} {3, -10} {4, -15} {5, -10} {6, -10} {7, -5}",
                                     $"{oneTrip.Id}", $"{oneTrip.DepartureTime.ToShortDateString()}", $"{oneTrip.TripFrom}",
                                     $"{oneTrip.TripTo}", $"{oneTrip.ArrivalTime.ToShortDateString()}", $"{oneTrip.Bus.Name}",
                                     $"({oneTrip.Bus.Capacity})", $"{oneTrip.TicketPrice}");
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Trips Table:\n");
                Console.WriteLine("ERROR INPUT! Come back to main menu and try again.");
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

        public void AdminMenu()
        {
            Console.Clear();
            Console.WriteLine("Howdy, Admin!\n");
            Console.WriteLine("Admin Menu\n");
            Console.WriteLine("1 - Add Trip");
            Console.WriteLine("2 - Remove Trip by ID");
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

        public void AddTrip()
        {
            TripModel _result;
            do
            {
                Console.Clear();
                var id = 11;
                Console.Write("Enter Departure Time in format (yyyy, m, d): ");
                var departureTime = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter Departure City: ");
                var departureCity = Console.ReadLine();
                Console.Write("Enter Arrival Time in format (yyyy, m, d): ");
                var arrivalTime = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter Arrival City: ");
                var arrivalCity = Console.ReadLine();
                Console.Write("Enter Bus Model: ");
                var busName = Console.ReadLine();
                Console.Write("Enter bus Capacity: ");
                var busCapacity = int.Parse(Console.ReadLine());
                BusModel busModel = new BusModel(busName, busCapacity);
                Console.Write("Enter Ticket price: ");
                double ticketPrice = int.Parse(Console.ReadLine());
                _result = new TripModel(id, departureTime, departureCity, arrivalTime, arrivalCity, busModel, ticketPrice);
                AddTripEvent?.Invoke(_result);
                Console.WriteLine($"\nTrip № 11 with destination to {arrivalCity} from {departureCity} was added to list!");
            } while (!true);            
        }

        public void RemoveTrip()
        {
            Console.Clear();
            Console.WriteLine("You want to remove trip?\n");
            Console.Write("Please enter trip Id for delete: ");
            var _inputId = int.Parse(Console.ReadLine());
            RemoveTripEvent?.Invoke(_inputId);
        }

        public void ApplicationExit()
        {
            Console.Clear();
            Console.WriteLine("Are you shure?\n");
            string userInput;                
            do
            {
                Console.Write("Input 'Y' to exit application or 'N' to back in main menu: ");
                var _userInput = Console.ReadLine();
                if (_userInput == "y" || _userInput == "Y")
                {
                    Environment.Exit(0);
                }
                if (_userInput == "n" || _userInput == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nERROR! Input 'Y' or 'N'\n");
                }
                userInput = _userInput;
            } while (!true || userInput != "y" || userInput != "n" || userInput != "Y" || userInput != "N");            
        }

    }
}