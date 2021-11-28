using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.View;
using BusStation.Model;

namespace BusStation.Controller
{
    public class MainController
    {
        private readonly MainMenuController _menuController;
        private readonly MainMenuView _menuView;
        //private readonly TripsStorage _tripsStorage;

        public MainController()
        {
            _menuController = new MainMenuController();
            _menuView = new MainMenuView();
            //_tripsStorage = new TripsStorage();
        }

        public void Run()
        {            
            _menuController.ShowMainMenu();
            var result = _menuView.MenuInput();
            switch (result)
            {
                case 1:
                    _menuController.ShowTripsTable();                    
                    break;
                case 2:
                    _menuController.FindTripById();
                    break;
                case 3:
                    _menuController.FindTripByDest();
                    //_tripsStorage.JsonSer();
                    break;
                case 4:
                    _menuController.FindWaysForToday();
                    break;
                case 5:
                    _menuController.FindWaysForNextSevenDays();
                    break;
                case 6:
                    _menuController.FindCheapTickets();
                    break;
                case 7:
                    _menuController.ShowFreeSeats();
                    break;
                case 8:
                    _menuController.AdminLogin();
                    break;
                case 9:
                    _menuController.ApplicationExit();
                    break;
            }
            _menuView.BackToMainMenu();
        }
    }
}