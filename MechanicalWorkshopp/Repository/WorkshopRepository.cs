using System.IO;
using System.Globalization;
using MechanicalWorkshop.Entities;
using MechanicalWorkshopp.Entities;
using MechanicalWorkshop.DTO;

namespace MechanicalWorkshop.Repository
{
    internal class WorkshopRepository
    {
        public IEnumerable<Cars> GetCars()
        {
            var cars = new List<Cars>();
            string directory = @"C:\Users\ntzzy\source\repos\MechanicalWorkshopp\MechanicalWorkshopp";
            string path = Path.Combine(directory, "carDB.txt");

            Directory.SetCurrentDirectory(directory);

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';') ;
                    cars.Add(new Cars(line[0],(line[1]), int.Parse(line[2]), int.Parse(line[3]), line[4]));
                }
            }

            return cars;
        }
        public IEnumerable<Gears> GetGears()
        {
            var gears = new List<Gears>();
            string directory = @"C:\Users\ntzzy\source\repos\MechanicalWorkshopp\MechanicalWorkshopp";
            string path = Path.Combine(directory, "GearDB.txt");
            
            Directory.SetCurrentDirectory(directory);

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    gears.Add(new Gears(int.Parse(line[0]), line[1], int.Parse(line[2]), double.Parse(line[3]))); 
                }
            }

            return gears;
        }

        public IEnumerable<MechanicalWork> GetMechanicalWork()
        {
            var mWork = new List<MechanicalWork>();
            string directory = @"C:\Users\ntzzy\source\repos\MechanicalWorkshopp\MechanicalWorkshopp";
            string path = Path.Combine(directory, "mechanicalServicesDB.txt");
            
            Directory.SetCurrentDirectory(directory);

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    mWork.Add(new MechanicalWork(int.Parse(line[0]), line[1], double.Parse(line[2])));
                }
            }
            
            return mWork;
        }
        public IEnumerable<Cars> RegisterCars(string make, string model, int year, double value, string engine)
        {
            var cars = new List<Cars>();
            var test = new List<Cars>();
            test.Add(new Cars(make, model, year, value, engine));
            string directory = @"C:\Users\ntzzy\source\repos\MechanicalWorkshopp\MechanicalWorkshopp";
            string path = Path.Combine(directory, "carDB.txt");

            Directory.SetCurrentDirectory(directory);

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    cars.Add(new Cars(line[0], (line[1]), int.Parse(line[2]), int.Parse(line[3]), line[4]));
                    bool verify = test.Equals(cars);
                    if (verify == true)
                    {
                        throw new Exception("This car is already registered");
                    }
                    else if (verify == false) 
                    {
                        cars.Add(new Cars(make, model, year, value, engine));
                    }                                        
                }
            }

            return cars;
        }
    }
}
