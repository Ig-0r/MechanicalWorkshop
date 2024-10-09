
using MechanicalWorkshop.Services;
using MechanicalWorkshopp.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var carTable = new CarTable();
        var carsDto = carTable.GetCarsDto();

        foreach (var car in carsDto) 
        {
            Console.WriteLine(car.CarInfo());
        }
        Console.WriteLine();
        Console.WriteLine("GearsInfo:");
        var gearTable = new GearTable();
        var gearsDto = gearTable.GetGearsDto();

        foreach (var gear in gearsDto)
        {
            Console.WriteLine(gear.GearInfo());
        }

    }
}