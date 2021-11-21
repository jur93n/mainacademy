using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.Model
{
    public class MenuChoiseStorage
    {
        public List<MenuChoiseModel> Choices { get; }
        private static MenuChoiseStorage _instance;

        private MenuChoiseStorage()
        {
            Choices = new List<MenuChoiseModel>
            {
                new MenuChoiseModel (1, "Show all trips"),
                new MenuChoiseModel (2, "Find trip by Id"),
                new MenuChoiseModel (3, "Find trip by destination"),
                new MenuChoiseModel (4, "Find ways for today"),
                new MenuChoiseModel (5, "Find ways for the next 7 days"),
                new MenuChoiseModel (6, "Find tickets for your price"),
                new MenuChoiseModel (7, "Show trips with free seats"),
                new MenuChoiseModel (8, "Login to admin panel"),
                new MenuChoiseModel (9, "Exit application")
            };
        }

        public static MenuChoiseStorage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MenuChoiseStorage();
            }
            return _instance;
        }
    }
}
