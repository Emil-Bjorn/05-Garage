namespace _05_Garage;

class Program
{
    static void Main(string[] args)
    {
        Garage? garage = null;
        bool running = true;

        Console.WriteLine("Hello, World!");
        while (running == true)
        {
            Console.WriteLine("0. Exit application");
            Console.WriteLine("1. Create new garage.");
            Console.WriteLine("2. Add new vehicle");
            Console.Write("Please input a command: ");
            string? cmd = Console.ReadLine();
            switch (cmd)
            {
                case "0":
                {
                    running = false;
                    Console.WriteLine("Exiting application.");
                    break;
                }
                case "1":
                {
                    Console.Write("Please define garage size: ");
                    if (int.TryParse(Console.ReadLine(), out int garageSize))
                    {
                        garage = new Garage(garageSize);
                        Console.WriteLine("Garage created.");
                    }
                    else
                    {
                        Console.WriteLine("Garage size can only be whole integers.");
                    }
                    break;
                }
                case "2":
                {
                    if (garage == null)
                    {
                        Console.WriteLine("Error: Garage has not been initialized.");
                    }
                    else
                    {
                        Console.WriteLine("1. Car");
                        Console.WriteLine("2. Motorcycle");
                        Console.WriteLine("3. Bus");
                        Console.WriteLine("4. Boat");
                        Console.WriteLine("5. Airplane");
                        Console.WriteLine("6. Other");
                        Console.Write("Please input vehicle type: ");
                        string? vehicleType = Console.ReadLine();
                        Console.Write("Please input registration number: ");
                        string? registrationNumber = Console.ReadLine();
                        Console.Write("Please input color: ");
                        string? color = Console.ReadLine();
                        Console.Write("Please input number of wheels: ");
                        if (!int.TryParse(Console.ReadLine(), out int numberOfWheels))
                        {
                            Console.WriteLine("Error: Number of wheels must be a whole integer");
                            break;
                        }
                        else if (registrationNumber == null || color == null)
                        {
                            Console.WriteLine(
                                "Error: registration number or color can not be null."
                            );
                            break;
                        }
                        else
                        {
                            try
                            {
                                switch (vehicleType)
                                {
                                    case "1":
                                        Console.Write("Please input fuel type: ");
                                        string? fuelType = Console.ReadLine();
                                        if (fuelType != null)
                                        {
                                            garage.AddVehicle(
                                                new Car(
                                                    registrationNumber,
                                                    color,
                                                    numberOfWheels,
                                                    fuelType
                                                )
                                            );
                                        }
                                        else
                                        {
                                            Console.WriteLine(
                                                "Error: Fuel type type can not be null."
                                            );
                                        }
                                        break;
                                    case "2":
                                        Console.Write(
                                            "Does the motorcycle have a sidecar attached?(y/n): "
                                        );
                                        string? hasSidecar = Console.ReadLine();
                                        switch (hasSidecar)
                                        {
                                            case "y":
                                                garage.AddVehicle(
                                                    new Motorcycle(
                                                        registrationNumber,
                                                        color,
                                                        numberOfWheels,
                                                        true
                                                    )
                                                );
                                                break;
                                            case "n":
                                                garage.AddVehicle(
                                                    new Motorcycle(
                                                        registrationNumber,
                                                        color,
                                                        numberOfWheels,
                                                        false
                                                    )
                                                );
                                                break;
                                            default:
                                                Console.WriteLine(
                                                    "You must specify whether the motorcycle has a sidecar by writing [y] or [n]."
                                                );
                                                break;
                                        }
                                        break;
                                    case "6":
                                        garage.AddVehicle(
                                            new Vehicle(registrationNumber, color, numberOfWheels)
                                        );
                                        break;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                    break;
                }
            }
        }
    }
}
