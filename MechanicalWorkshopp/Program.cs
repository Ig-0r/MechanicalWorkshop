
using MechanicalWorkshop.Services;
using MechanicalWorkshopp.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var carTable = new CarService();
        var carsDto = carTable.GetCarsDto();

        foreach (var car in carsDto) 
        {
            Console.WriteLine(car.CarInfo());
        }
        Console.WriteLine();
        Console.WriteLine("GearsInfo:");
        var gearTable = new GearService();
        var gearsDto = gearTable.GetGearsDto();

        foreach (var gear in gearsDto)
        {
            Console.WriteLine(gear.GearInfo());
        }

        Console.WriteLine();
        Console.WriteLine("Services Info:");
        var service = new MechanicalWorkService();
        var n = service.GetMechanicalWorkDto();

        foreach (var t in n)
        {
            Console.WriteLine(t.mWorkInfo());

        }
        

    }
}