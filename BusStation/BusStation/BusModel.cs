using System;
namespace BusStation
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