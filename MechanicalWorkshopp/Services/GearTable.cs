
using MechanicalWorkshop.DTO;
using MechanicalWorkshop.Repository;
using MechanicalWorkshopp.Dto;
using System.ComponentModel;

namespace MechanicalWorkshopp.Services
{
    internal class GearTable
    {
        public IEnumerable<GearsDto> GetGearsDto()
        {
            var workshopRepository = new WorkshopRepository();
            var gears = workshopRepository.GetGears();
            var gearsDto = new List<GearsDto>();
            foreach (var gear in gears)
            {
                var gearDto = new GearsDto();
                gearDto.PartID = gear.PartID;
                gearDto.PartName = gear.PartName;
                gearDto.PartStock = gear.PartStock;
                gearDto.PartPrice = gear.PartPrice;

                gearsDto.Add(gearDto); 
            }



            return gearsDto;
        }
    }
}
