using System;
using BusStation.View;
using BusStation.Model;
namespace BusStation.Controller
{
    public class AdminMenuController
    {
        private AdminMenuView _adminMenuView;
        private TripsStorage _storageModel;
        public AdminMenuController()
        {
            _adminMenuView = new AdminMenuView();
        }
        public void ShowAdminMenu()
        {
            _adminMenuView.AdminHeader();
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
