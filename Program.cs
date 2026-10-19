namespace _05_Garage;

class Program
{
    static void Main(string[] args)
    {
        Garage garage;
        bool running = true;

        Console.WriteLine("Hello, World!");
        while (running == true)
        {
            Console.WriteLine("0. Exit application");
            Console.WriteLine("1. Create new garage.");
            Console.Write("Please input a command: ");
            string? cmd = Console.ReadLine();
            switch (cmd)
            {
                case "0":
                running = false;
                Console.WriteLine("Exiting application.");
                break;
                case "1":
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
        }
    }
}
