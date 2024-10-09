using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalWorkshopp.Dto
{
    internal class GearsDto
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public int PartStock { get; set; }
        public double PartPrice { get; set; }
        
        public string GearInfo()
        { 
        return PartID.ToString()
                +", "
                +PartName
                +", "
                +PartStock.ToString()
                +", "
                +PartPrice.ToString();        
        }
    }
}
