using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.Model;
using BusStation.Controller;

namespace BusStation.View
{
    public class AdminMenuView
    {
        
        public void AdminHeader()
        {
            
        }

        public void AdminMenu()
        {
            Console.Clear();
            Console.WriteLine("Howdy, Admin!\n");
            Console.WriteLine("Admin Menu\n");
            Console.WriteLine("1 - Add Trip");
            Console.WriteLine("2 - Remove Trip by ID");            
        }

        public void ShowAdminPanel(bool truePass)
        {
            var _truePass = truePass;
            if (_truePass == true)
            {

            }
        }
    }
}
