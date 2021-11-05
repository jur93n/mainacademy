using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainController = new MainController();
            while (true)
            {
                mainController.Run();
            }
        }
    }
}
