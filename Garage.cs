using System;

namespace _05_Garage;

public class Garage
{
    public Vehicle[] Data { get; set; }
    public int Capacity { get; set; }

    public Garage(int capacity)
    {
        Capacity = capacity;
        Data = Vehicle[capacity];
    }
}
