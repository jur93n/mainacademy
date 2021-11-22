using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.View;

namespace BusStation.Controller
{
    public class AdminController
    {        
        private AdminMenuController _adminMenuController;
        private MainMenuView _mainMenuView;
        private AdminMenuView _adminMenuView;

        public AdminController()
        {
            _adminMenuView = new AdminMenuView();
            _adminMenuController = new AdminMenuController();
            _mainMenuView = new MainMenuView();
        }

        public void RunAdmin()
        {
            _adminMenuView.AdminMenu();
            var result = _mainMenuView.MenuInput();
            switch (result)
            {
                case 1:
                    _adminMenuController.AddTrip();
                    break;
                case 2:
                    _adminMenuController.RemoveTrip();
                    break;
            }
        }
    }
}