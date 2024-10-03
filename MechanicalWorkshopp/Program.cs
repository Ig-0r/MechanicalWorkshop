
using MechanicalWorkshop.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var carService = new CarService();
        var carsDto = carService.GetCarsDto();

        foreach (var car in carsDto) 
        {
            Console.WriteLine(car.CarInfo());
        }

    }
}