using System;
using BusStation.View;
using BusStation.Model;
namespace BusStation.Controller
{
    public class AdminMenuController
    {
        private TripsStorage _storageModel;
        private MainMenuView _menuView;

        public AdminMenuController()
        {
            _storageModel = new TripsStorage();
            _menuView = new MainMenuView();
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
                _menuView.InputAdminPassAgainEvent += UserInputPass;
                _menuView.WrongAdminPass();
            }
        }

        public void ShowAdminMenu()
        {
            _menuView.InputAdminPassEvent += UserInputPass;            
            _menuView.AdminMenu();           
        }

        public void UserAddTrip(TripModel _result)
        {
            _storageModel.AddTrip(TripsStorage.Trips, _result);
        }

        public void UserRemoveTrip(int _id)
        {
            _storageModel.RemoveTrip(TripsStorage.Trips, _id);
        }

        public void AddTrip()
        {
            _menuView.AddTripEvent += UserAddTrip;
            _menuView.AddTrip();
            
        }        

        public void RemoveTrip()
        {
            _menuView.RemoveTripEvent += UserRemoveTrip;
            _menuView.RemoveTrip();
        }

        public void RunAdmin()
        {
            _menuView.AdminMenu();
            var result = _menuView.AdminMenuInput();
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
