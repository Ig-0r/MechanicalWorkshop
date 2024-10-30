using System.IO;
using System.Globalization;
using MechanicalWorkshop.Entities;
using MechanicalWorkshopp.Entities;

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
    }
}
