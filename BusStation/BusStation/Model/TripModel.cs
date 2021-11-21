using System;
namespace BusStation.Model
{
    public class TripModel
    {
        public TripModel(int id, DateTime departureTime, DateTime arrivalTime, string tripTo, BusModel bus, double ticketPrice)
        {
            this.Id = id;
            this.DepartureTime = departureTime;
            this.ArrivalTime = arrivalTime;
            this.TripTo = tripTo;
            this.Bus = bus;
            this.TicketPrice = ticketPrice;
        }
        public int Id { get; }
        public DateTime DepartureTime { get; }
        public string TripFrom { get; }
        public DateTime ArrivalTime { get; }
        public string TripTo { get; }
        public BusModel Bus { get; }
        public double TicketPrice { get; }
        public TripModel( int id, DateTime departureTime, string tripFrom, DateTime arrivalTime, string tripTo, BusModel bus, double ticketPrice)
        {
            Id = id;
            DepartureTime = departureTime;
            TripFrom = tripFrom;
            ArrivalTime = arrivalTime;
            TripTo = tripTo;
            Bus = bus;
            TicketPrice = ticketPrice;
        }

    }
}