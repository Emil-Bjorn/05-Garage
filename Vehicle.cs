using System;

namespace _05_Garage;

public class Vehicle
{
    public string RegistrationNumber { get; set; }
    public string Color { get; set; }
    public int NumberOfWheels { get; set; }

    public Vehicle(string registrationNumber, string color, int numberOfWheels)
    {
        RegistrationNumber = registrationNumber;
        Color = color;
        NumberOfWheels = numberOfWheels;
    }

    public override string ToString()
    {
        return $"{RegistrationNumber} - Color: {Color}, Number of wheels: {NumberOfWheels}";
    }
}
