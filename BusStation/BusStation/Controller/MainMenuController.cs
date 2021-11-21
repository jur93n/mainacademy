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

        private void UserInputId(int _id)        
        {
            var myTrip = _storageModel.FindTripById(TripsStorage.Trips, _id);
            _menuView.ShowTripsTable(new[] { myTrip }.ToList());
        }

        private void UserInputDest(string _dest)
        {
            var myTrip = _storageModel.FindTripByDest(TripsStorage.Trips, _dest);
            _menuView.ShowTripsTable(new[] { myTrip }.ToList());
        }

        private void UserInputWaysForToday(DateTime _date)
        {
            var myTrip = _storageModel.FindWaysForToday(TripsStorage.Trips, _date);
            _menuView.ShowTripsTable(new[] { myTrip }.ToList());
        }

        private void UserInputWaysForNextDays(DateTime _date)
        {
            var myTrip = _storageModel.FindWaysForNextSevenDays(TripsStorage.Trips, _date);
            _menuView.ShowTripsTable(new[] { myTrip }.ToList());
        }

        private void UserInputPrice(int _price)
        {
            var myTrip = _storageModel.FindCheapTickets(TripsStorage.Trips, _price);
            _menuView.ShowTripsTable(new[] { myTrip }.ToList());
        }

        private void UserFreeSeats()
        {
            var myTrip = _storageModel.ShowFreeSeats(TripsStorage.Trips);
            _menuView.ShowTripsTable(new[] { myTrip }.ToList());
        }

        public MainMenuController()
        {
            _menuView = new MainMenuView();
        }

        public void ShowMainMenu()
        {            
            _menuView.ShowHeader();
            _menuView.ShowMenu();            
        }

        public void ShowTripsTable()
        {            
            _menuView.ShowTripsTable(TripsStorage.Trips);
            _menuView.BackToMainMenu();
        }

        public void FindTripById()
        {
            _menuView.InputTripId();
            _menuView.InputIdEvent += UserInputId;
        }

        public void FindTripByDest()
        {
            _menuView.InputDestEvent += UserInputDest;
            _menuView.BackToMainMenu();
        }

        public void FindWaysForToday()
        {
            _menuView.InputWaysForTodayEvent += UserInputWaysForToday;
            _menuView.BackToMainMenu();
        }
        
        public void FindWaysForNextSevenDays()
        {
            _menuView.InputWaysForTodayEvent += UserInputWaysForNextDays;
            _menuView.BackToMainMenu();
        }
        
        public void FindCheapTickets()
        {
            _menuView.InputPriceEvent += UserInputPrice;
            _menuView.BackToMainMenu();
        }
        
        public void ShowFreeSeats()
        {
            _menuView.FreeSeatsEvent += UserFreeSeats;
            _menuView.BackToMainMenu();
        }
        /*
        public void AdminLogin()
        {
            _menuView.AdminLogin();
            _menuView.BackToMainMenu();
        }*/        
    }
}