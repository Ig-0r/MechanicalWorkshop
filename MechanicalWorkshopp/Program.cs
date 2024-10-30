
using MechanicalWorkshop.Services;
using MechanicalWorkshopp.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("                                       _________________________________");
        Console.WriteLine("                                      | WELCOME TO MECHANICAL WORKSHOP! |");
        Console.WriteLine("                                       ---------------------------------");
        Console.WriteLine();
        Console.WriteLine("Which action below you want to execute?");
        Console.WriteLine("1: Register");
        Console.WriteLine("2: Add");
        Console.WriteLine("3: Remove");
        Console.WriteLine("4: Search");
        Console.WriteLine("5: Close the program");

        ConsoleKeyInfo n = Console.ReadKey();

        switch (n.KeyChar)
        {
            case '1':
                Console.Clear();

                break;
            case '2':
                Console.Clear();

                break;
            case '3':
                Console.Clear();

                break;
            case '4':
                Console.Clear();

                break;
            case '5':
                Console.Clear();

                break;


        }
    }
}