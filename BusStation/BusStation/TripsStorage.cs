using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace BusStation
{
    
    public class TripsStorage
    {
        public static List <TripModel> Trips = new List <TripModel>
        { 
            new TripModel(1, new DateTime(2022,1,1), "Zhmerynka ", new DateTime(2022,1,2), "Lviv    ", new BusModel("Ikarus   ", 8), 650 ),
            new TripModel(2, new DateTime(2022,1,6), "Kyiv      ", new DateTime(2022,1,7), "Bukovel ", new BusModel("Isuzu    ", 1), 1200),
            new TripModel(3, new DateTime(2022,1,4), "Sumy      ", new DateTime(2022,1,5), "Ternopil", new BusModel("LAZ     ", 10), 1000),
            new TripModel(4, new DateTime(2022,1,4), "Vinnytsya ", new DateTime(2022,1,5), "Kharkiv ", new BusModel("Ikarus   ", 9), 1200),
            new TripModel(5, new DateTime(2022,1,5), "Zaporizhya", new DateTime(2022,1,7), "Odesa   ", new BusModel("Bohdan   ", 7), 500 ),
            new TripModel(6, new DateTime(2022,1,9), "Zhytomyr  ", new DateTime(2022,1,9), "Poltava ", new BusModel("Sprinter ", 0), 600 ),
            new TripModel(7, new DateTime(2022,1,7), "Kyiv      ", new DateTime(2022,1,8), "Yaremche", new BusModel("LAZ      ", 6), 1000),
            new TripModel(8, new DateTime(2022,1,2), "Vinnytsya ", new DateTime(2022,1,2), "Lviv    ", new BusModel("Bohdan  ", 13), 700 ),
            new TripModel(9, new DateTime(2022,1,1), "Chernivtsi", new DateTime(2022,1,1), "Rivne   ", new BusModel("Isuzu    ", 0), 600 ),
            new TripModel(9, new DateTime(2022,1,9), "Odesa     ", new DateTime(2022,1,9), "Uzhhorod", new BusModel("Sprinter ", 4), 800 )
        };
    }
}