using System;

namespace _05_Garage;

public class Garage
{
    public Vehicle?[] Data { get; set; }
    public int Capacity { get; set; }

    public Garage(int capacity)
    {
        Capacity = capacity;
        Data = new Vehicle[capacity];
    }

    public void AddVehicle(Vehicle vehicle)
    {
        // Find the first index in Data that is empty
        int emptyIndex = Array.IndexOf(Data, null);
        // If there is an empty index in Data and the registration number is not used by another vehicle, set empty index to provided vehicle
        if (emptyIndex != -1)
        {
            if (findVehicleByRegistrationNumber(vehicle.RegistrationNumber, out int index) == null)
            {
                Data[emptyIndex] = vehicle;
            }
            else
            {
                throw new InvalidOperationException(
                    "Error: Vehicle with that registration number already exists"
                );
            }
        }
        else
        {
            throw new InvalidOperationException("Error: No free space in garage.");
        }
    }

    // Returns true if operation is successful and false if not
    public bool RemoveVehicle(string registrationNumber)
    {
        findVehicleByRegistrationNumber(registrationNumber, out int index);
        if (index != -1)
        {
            Data[index] = null;
            return true;
        }
        else
        {
            return false;
        }
    }

    public Vehicle? findVehicleByRegistrationNumber(string registrationNumber, out int index)
    {
        index = -1;
        for (int i = 0; i < Data.Length; i++)
        {
            Vehicle? vehicle = Data[i];
            if (vehicle != null && vehicle.RegistrationNumber == registrationNumber)
            {
                index = i;
                return vehicle;
            }
        }
        return null;
    }
}
