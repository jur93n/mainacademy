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
            Console.Clear();
            Console.WriteLine("Howdy, Admin!\n");
        }
        public void AdminMenu()
        {            
            Console.WriteLine("Admin Menu\n");
            Console.WriteLine("1 - Add Trip");
            Console.WriteLine("2 - Remove Trip by ID");            
        }
        
    }
}
