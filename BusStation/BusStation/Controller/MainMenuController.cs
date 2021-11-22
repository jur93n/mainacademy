using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.View;
using BusStation.Model;

namespace BusStation.Controller
{
    public class MainMenuController
    {
        private MainMenuView _menuView;
        private TripsStorage _storageModel;
        private AdminMenuController _adminMenuController;

        public MainMenuController()
        {
            _menuView = new MainMenuView();
            _storageModel = new TripsStorage();
            _adminMenuController = new AdminMenuController();
        }

        private void UserInputId(int _id)        
        {
            var myTrip = _storageModel.FindTripById(TripsStorage.Trips, _id);
            _menuView.ShowTripsTable(new List<TripModel> { myTrip });
        }

        private void UserInputDest(string _dest)
        {
            var myTrip = _storageModel.FindTripByDest(TripsStorage.Trips, _dest);
            _menuView.ShowTripsTable(myTrip.OrderBy(t => t.DepartureTime).ToList());
        }

        private void UserInputWaysForToday(DateTime _date)
        {
            var myTrip = _storageModel.FindWaysForToday(TripsStorage.Trips, _date);
            _menuView.ShowTripsTable(myTrip);
        }

        private void UserInputWaysForNextDays(DateTime _date)
        {
            var myTrip = _storageModel.FindWaysForNextSevenDays(TripsStorage.Trips, _date);
            _menuView.ShowTripsTable(myTrip.OrderBy(t => t.DepartureTime).ToList());
        }

        private void UserInputPrice(int _price)
        {
            var myTrip = _storageModel.FindCheapTickets(TripsStorage.Trips, _price);
            _menuView.ShowTripsTable(myTrip.OrderBy(t => t.DepartureTime).ToList());
        }

        private void UserFreeSeats()
        {
            var myTrip = _storageModel.ShowFreeSeats(TripsStorage.Trips);
            _menuView.ShowTripsTable(myTrip.OrderBy(t => t.DepartureTime).ToList());
        }

        public void ShowMainMenu()
        {            
            _menuView.ShowHeader();
            _menuView.ShowMenu();            
        }

        public void ShowTripsTable()
        {
            _menuView.ShowTripsTable(TripsStorage.Trips.OrderBy(t => t.DepartureTime).ToList());
        }

        public void FindTripById()
        {
            _menuView.InputIdEvent += UserInputId;
            _menuView.InputTripId();
        }

        public void FindTripByDest()
        {
            _menuView.InputDestEvent += UserInputDest;
            _menuView.InputTripDest();
        }

        public void FindWaysForToday()
        {
            _menuView.InputWaysForTodayEvent += UserInputWaysForToday;
            _menuView.InputWaysForToday();
        }
        
        public void FindWaysForNextSevenDays()
        {
            _menuView.InputWaysForNextSevenDaysEvent += UserInputWaysForNextDays;
            _menuView.InputForNextSevenDays();
        }
        
        public void FindCheapTickets()
        {
            _menuView.InputPriceEvent += UserInputPrice;
            _menuView.InputPriceTickets();
        }
        
        public void ShowFreeSeats()
        {
            _menuView.FreeSeatsEvent += UserFreeSeats;
            _menuView.ShowFreeSeats();
        }
        
        public void AdminLogin()
        {
            _menuView.InputAdminPassEvent += _adminMenuController.UserInputPass;
            _menuView.AdminLogin();            
        }        
    }
}