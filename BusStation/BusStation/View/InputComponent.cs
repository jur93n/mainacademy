using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.Model;
namespace BusStation.View
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
                Console.WriteLine("Login to admin\n");
                Console.Write("Enter Admin Password: ");
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
                result = new TripModel(id, departureTime, departureCity, arrivalTime, arrivalCity, busModel, ticketPrice);
                Console.WriteLine($"\nTrip № 11 with destination to {arrivalCity} from {departureCity} was added to list!");
            } while (!true);            
            return result;
        }
        public int RemoveTrip()
        {
            int result;
            do
            {
                Console.Write("Enter trip Id for Remove: ");
                var userChoise = int.Parse(Console.ReadLine());                
                result = userChoise;
            } while (!true);
            return result;
        }

    }
}