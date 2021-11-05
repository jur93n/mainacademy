using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusStation
{
    public class AdminMenuView
    {
        
        public void AdminHeader()
        {
            Console.Clear();
            Console.WriteLine("Howdy, Admin!\n");
        }
        public void AdminMenu()
        {            
            Console.WriteLine("Admin Menu\n");
            Console.WriteLine("1 - Add Trip");
            Console.WriteLine("2 - Remove Trip by ID");            
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
            Console.WriteLine("Enter Trip Id for remove: ");
            foreach (var oneTrip in trips)
            {
                if (_id == oneTrip.Id)
                {
                    Console.WriteLine($"Trip № {oneTrip.Id} with destination to {oneTrip.TripTo} from {oneTrip.TripFrom} was deleted!");
                    TripsStorage.Trips.Remove(oneTrip);
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
