
using MechanicalWorkshop.DTO;
using MechanicalWorkshop.Repository;

namespace MechanicalWorkshop.Services
{
    internal class CarService
    {
        public IEnumerable<CarDto> GetCarsDto()
        {
            var workshopRepository = new WorkshopRepository();
            var cars = workshopRepository.GetCars();
            var carsDto = new List<CarDto>();
            foreach (var car in cars)
            {
                var carDto = new CarDto();
                carDto.Make = car.Make;
                carDto.Model = car.Model;
                carDto.Year = car.Year;
                carDto.Value = car.Value;
                carDto.Engine = car.Engine;

                carsDto.Add(carDto);
            }



            return carsDto;
        }
    }

}
