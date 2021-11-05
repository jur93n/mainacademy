using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusStation
{
    public class InputComponent
    {
        public int GetInputInt()
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
        }
        public int GetInputId()
        {
            bool isParsed;
            int result;
            do
            {
                Console.Write("Enter trip Id: ");
                var userChoise = Console.ReadLine();
                isParsed = int.TryParse(userChoise, out result);
            } while (!isParsed);
            return result;
        }
        public string GetInputDest()
        {
            string result;
            do
            {
                Console.WriteLine("Enter trip Destination: ");
                result = Console.ReadLine();
            } while (!true);
            return result;
        }
        public DateTime FindWaysForToday()
        {
            DateTime Date = new DateTime(2022, 1, 1);
            return Date;
        }
        public DateTime WaysForNextSevenDays()
        {
            DateTime Date = new DateTime(2022, 1, 7);
            return Date;
        }
        public int FindCheapTickets()
        {
            bool isParsed;
            int result;
            do
            {
                Console.Write("Enter max tickets price: ");
                var userChoise = Console.ReadLine();
                isParsed = int.TryParse(userChoise, out result);
            } while (!isParsed);
            return result;
        }
        public string AdminPass()
        {
            string result;
            do
            {
                Console.WriteLine("Enter Admin Password: ");
                result = Console.ReadLine();
            } while (!true);
            return result;
        }
        public TripModel AddTrip()
        {
            TripModel result;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter Departure Time in format (yyyy, m, d): ");
                var departureTime = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Departure City: ");
                var departureCity = Console.ReadLine();
                Console.WriteLine("Enter Arrival Time in format (yyyy, m, d): ");
                var arrivalTime = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Arrival City: ");
                var arrivalCity = Console.ReadLine();
                Console.WriteLine("Enter Bus Model in Format (Ikarus, 2): ");
                BusModel busModel = new BusModel("ikarus", int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter Ticket price: ");
                double ticketPrice = int.Parse(Console.ReadLine());
                result = new TripModel(11, departureTime, departureCity, arrivalTime, arrivalCity, busModel, ticketPrice);
            } while (!true);
            
            return result;
        }
        public int RemoveTrip()
        {
            bool isParsed;
            int result;
            do
            {
                Console.Write("Enter trip Id: ");
                var userChoise = Console.ReadLine();
                isParsed = int.TryParse(userChoise, out result);
            } while (!isParsed);
            return result;
        }

    }
}