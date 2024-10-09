

using MechanicalWorkshop.Entities;
using System.Reflection;

namespace MechanicalWorkshop.DTO
{
    internal class CarsDto
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Value { get; set; }
        public string Engine { get; set; }

        public string CarInfo()
        {
            return Make
                + ", "
                +Model
                + ", "
                +Year.ToString()
                + ", "
                +Value.ToString()
                + ", "
                +Engine;
        }
    }
}
