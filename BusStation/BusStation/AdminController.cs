using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusStation
{
    public class AdminController
    {
        private readonly InputComponent _input;
        private readonly AdminMenuController _adminMenuController;
        public AdminController()
        {
            _input = new InputComponent();
            _adminMenuController = new AdminMenuController();
        }
        public void RunAdmin()
        {
            _adminMenuController.ShowAdminMenu();
            var result = _input.GetInputInt();
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