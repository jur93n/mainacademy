using System;
using BusStation.View;
using BusStation.Model;
namespace BusStation.Controller
{
    public class AdminMenuController
    {
        private AdminMenuView _adminMenuView;
        private TripsStorage _storageModel;
        private MainMenuView _menuView;

        public AdminMenuController()
        {
            _adminMenuView = new AdminMenuView();
            _storageModel = new TripsStorage();
            _menuView = new MainMenuView();
        }

        public void UserInputPass (string _pass)
        {
            var truePass = _storageModel.CheckPass(_pass);
            if (truePass == true)
            {
                _adminMenuView.AdminMenu();
            } 
            else
            {
                _menuView.WrongAdminPass();
            }
        }

        public void ShowAdminMenu()
        {
            _menuView.InputAdminPassEvent += UserInputPass;
            _adminMenuView.AdminMenu();            
        }

        public void AddTrip()
        {
            _storageModel.AddTrip(TripsStorage.Trips);
            _storageModel.BackToAdminMenu();
        }

        public void RemoveTrip()
        {
            _storageModel.RemoveTrip(TripsStorage.Trips);
            _storageModel.BackToAdminMenu();
        }
    }
}
