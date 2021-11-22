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
        //private AdminController _adminController;

        public AdminMenuController()
        {
            _adminMenuView = new AdminMenuView();
            _storageModel = new TripsStorage();
            _menuView = new MainMenuView();
           // _adminController = new AdminController();
        }

        public void UserInputPass(string _pass)
        {
            var truePass = _storageModel.CheckPass(_pass);
            if (truePass == true)
            {
                RunAdmin();
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

        public void UserAddTrip(TripModel _result)
        {
            _storageModel.AddTrip(TripsStorage.Trips, _result);

        }

        public void AddTrip()
        {
            _menuView.AddTripEvent += UserAddTrip;
            _menuView.AddTrip();
            _storageModel.BackToAdminMenu();
        }

        public void RemoveTrip()
        {
            _storageModel.RemoveTrip(TripsStorage.Trips);
            _storageModel.BackToAdminMenu();
        }

        public void RunAdmin()
        {
            _adminMenuView.AdminMenu();
            var result = _menuView.MenuInput();
            switch (result)
            {
                case 1:
                    AddTrip();
                    break;
                case 2:
                    RemoveTrip();
                    break;
            }
        }
    }
}
