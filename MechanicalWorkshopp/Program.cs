
using MechanicalWorkshop.Repository;
using MechanicalWorkshop.Services;
using MechanicalWorkshopp.Services;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("                                       _________________________________");
        Console.WriteLine("                                      | WELCOME TO MECHANICAL WORKSHOP! |");
        Console.WriteLine("                                       ---------------------------------");
        Console.WriteLine();
        Console.WriteLine("Choose an option below to execute:");
        Console.WriteLine("1: Open cars menu");
        Console.WriteLine("2: Open services menu");
        Console.WriteLine("3: Open gears menu");
        Console.WriteLine("4: End program");      

        ConsoleKeyInfo n = Console.ReadKey();

        switch (n.KeyChar)
        {
            case '1':
                Console.Clear();
                Console.WriteLine("Which action below you want to execute?");
                Console.WriteLine("1: Show cars already registered");
                Console.WriteLine("2: Register a new car");
                Console.WriteLine("3: Delet a car");
                ConsoleKeyInfo r = Console.ReadKey();
                if (r.KeyChar == '1')
                {
                    Console.Clear();

                    Console.WriteLine("Cars list:");
                    var carService = new CarService();
                    var carsDto = carService.GetCarsDto();

                    foreach (var car in carsDto)
                    {
                        Console.WriteLine(car.CarInfo());
                    }
                }
                else if (r.KeyChar == '2')
                {
                    Console.Clear();
                    Console.WriteLine("Write the make, model, year, value and engine below, separated by \";\" respectively:");
                    string[] line = Console.ReadLine().Split(';');
                    var verify = new WorkshopRepository();
                    verify.RegisterCars(line[0], (line[1]), int.Parse(line[2]), int.Parse(line[3]), line[4]);
                    
                }
                else if (r.KeyChar == '3')
                {

                }              
                break;

            case '2':
                Console.Clear();                
                Console.WriteLine("Which action below you want to execute?");
                Console.WriteLine("1: Show parts already registered");
                Console.WriteLine("2: Register a new part");
                Console.WriteLine("3: Delet a part");

                ConsoleKeyInfo t = Console.ReadKey();

                if (t.KeyChar == '1')
                {

                }
                else if (t.KeyChar == '2')
                { 
                
                }
                else if (t.KeyChar == '3')
                {
                    Console.WriteLine();
                }
                break;

            case '3':
                Console.Clear();

                break;

            case '4':
                Console.Clear();
                Environment.Exit(0);
                break;
            
        }
    }
}