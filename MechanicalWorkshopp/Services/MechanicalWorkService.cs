using MechanicalWorkshop.Repository;
using MechanicalWorkshopp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalWorkshopp.Services
{
    internal class MechanicalWorkService
    {
        public IEnumerable<MechanicalWorkDto> GetMechanicalWorkDto()
        {
            var wRepository = new WorkshopRepository();
            var mWork = wRepository.GetMechanicalWork();
            var mWorkDto = new List<MechanicalWorkDto>();

            foreach (var m in mWork)
            {
                var mDto = new MechanicalWorkDto();
                mDto.Id = m.Id;
                mDto.ProcedureName = m.ProcedureName;
                mDto.WorkCost = m.WorkCost;

                mWorkDto.Add(mDto);
            }
            return mWorkDto;
        }
    }
}
