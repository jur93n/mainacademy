using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusStation
{
    public class MainMenuController
    {
        private MainMenuView _menuView;

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
            _menuView.FindTripById(TripsStorage.Trips);
            _menuView.BackToMainMenu();
        }
        public void FindTripByDest()
        {
            _menuView.FindTripByDest(TripsStorage.Trips);
            _menuView.BackToMainMenu();
        }
        public void FindWaysForToday()
        {
            _menuView.FindWaysForToday(TripsStorage.Trips);
            _menuView.BackToMainMenu();
        }
        public void WaysForNextSevenDays()
        {
            _menuView.WaysForNextSevenDays(TripsStorage.Trips);
            _menuView.BackToMainMenu();
        }
        public void FindCheapTickets()
        {
            _menuView.FindCheapTickets(TripsStorage.Trips);
            _menuView.BackToMainMenu();
        }
        public void ShowFreeSeats()
        {
            _menuView.ShowFreeSeats(TripsStorage.Trips);
            _menuView.BackToMainMenu();
        }
        public void AdminLogin()
        {
            _menuView.AdminLogin();
            _menuView.BackToMainMenu();
        }        
    }
}