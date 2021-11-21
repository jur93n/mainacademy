using System;
namespace BusStation.Model
{
    public class BusModel
    {
    public string Name {get;}
    public int Capacity {get;}
    public BusModel(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
    }    
    }
}