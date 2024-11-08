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
            string path = Path.Combine(Directory.GetCurrentDirectory(), "carDB.txt");

            Directory.SetCurrentDirectory(Directory.GetCurrentDirectory());

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    cars.Add(new Cars(line[0], (line[1]), int.Parse(line[2]), int.Parse(line[3]), line[4]));
                }
            }

            return cars;
        }
        public IEnumerable<Gears> GetGears()
        {
            var gears = new List<Gears>();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "GearDB.txt");

            Directory.SetCurrentDirectory(Directory.GetCurrentDirectory());

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
            string path = Path.Combine(Directory.GetCurrentDirectory(), "mechanicalServicesDB.txt");

            Directory.SetCurrentDirectory(Directory.GetCurrentDirectory());

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

        public void RegisterCars(string make, string model, int year, double value, string engine)
        {
            var cars = new List<Cars>();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "carDB.txt");

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    cars.Add(new Cars(line[0], line[1], int.Parse(line[2]), double.Parse(line[3]), line[4]));
                }
            }
            bool test = false;

            foreach (var car in cars)
            {
                if (car.Make == make && car.Model == model && car.Year == year && car.Value == value && car.Engine == engine)
                {
                    test = true;                
                }
            }

            if (test == true)
            {
                throw new Exception("This car is already registered.");
            }
            else
            {                
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine($"{make};{model};{year};{value};{engine}");
                    
                }
            }
        }
    }
}

