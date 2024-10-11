using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalWorkshopp.Dto
{
    internal class MechanicalWorkDto
    {
        public int Id { get; set; }
        public string ProcedureName { get; set; }
        public double WorkCost { get; set; }

        public string mWorkInfo()
        {
            return Id
                + ", "
                + ProcedureName
                + ", "
                + WorkCost;
        }
    }
}
