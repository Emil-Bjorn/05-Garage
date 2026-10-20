using System;

namespace _05_Garage;

public class Garage
{
    public Vehicle[] Data { get; set; }
    public int Capacity { get; set; }

    public Garage(int capacity)
    {
        Capacity = capacity;
        Data = new Vehicle[capacity];
    }

    public void AddVehicle(Vehicle vehicle)
    {
        int emptyIndex = Array.IndexOf(Data, null);
        if (emptyIndex != -1)
        {
            Data[emptyIndex] = vehicle;
        }
        else
        {
            throw new InvalidOperationException("Error: No free space in garage.");
        }
    }
    public Vehicle? findVehicleByRegistrationNumber(string registrationNumber)
    {
        foreach (Vehicle vehicle in Data)
        {
            if (vehicle.RegistrationNumber == registrationNumber)
            {
                return vehicle;
            }
            else
            {
                return null;
            }
        }
        return null;
    }
}
