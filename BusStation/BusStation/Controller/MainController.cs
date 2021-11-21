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
        private readonly InputComponent _input;
        private readonly MainMenuController _menuController;
        private readonly TripsStorage _tripsStorage;
        private readonly MainMenuView _menuView;

        public MainController()
        {
            _input = new InputComponent();
            _menuController = new MainMenuController();
            _menuView = new MainMenuView();
        }

        public void Run()
        {            
            _menuController.ShowMainMenu();
            var result = _input.GetInputInt();
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
                    break;/*
                case 8:
                    _menuController.AdminLogin();
                    break;*/
            }
            _menuView.BackToMainMenu();
        }
    }
}