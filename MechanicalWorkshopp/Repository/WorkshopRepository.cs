using System.IO;
using System.Globalization;

using MechanicalWorkshop.Entities;

namespace MechanicalWorkshop.Repository
{
    internal class WorkshopRepository
    {
        public IEnumerable<Car> GetCars()
        {
            var cars = new List<Car>();
            string path = @"C:\Users\ntzzy\source\repos\MechanicalWorkshopp\MechanicalWorkshopp\carDB.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';') ;
                    cars.Add(new Car(line[0],(line[1]), int.Parse(line[2]), int.Parse(line[3]), line[4]));
                }
            }

            return cars;
        }
    }
}
