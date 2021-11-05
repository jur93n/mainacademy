using System;
namespace BusStation
{
    public class AdminMenuController
    {
        private AdminMenuView _adminMenuView;
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
            _adminMenuView.AddTrip(TripsStorage.Trips);
            _adminMenuView.BackToAdminMenu();
        }
        public void RemoveTrip()
        {
            _adminMenuView.RemoveTrip(TripsStorage.Trips);
            _adminMenuView.BackToAdminMenu();
        }
    }
}
