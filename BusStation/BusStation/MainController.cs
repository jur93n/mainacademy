using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusStation
{
    public class MainController
    {
        private readonly InputComponent _input;
        private readonly MainMenuController _menuController;
        public MainController()
        {
            _input = new InputComponent();
            _menuController = new MainMenuController();               
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
                    break;
                case 4:
                    _menuController.FindWaysForToday();
                    break;
                case 5:
                    _menuController.WaysForNextSevenDays();
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

            }            
        }
    }
}