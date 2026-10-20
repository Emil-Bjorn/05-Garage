using System;

namespace _05_Garage;

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string registrationNumber, string color, int numberOfWheels, bool hasSidecar)
        : base(registrationNumber, color, numberOfWheels)
    {
        HasSidecar = hasSidecar;
    }
}
