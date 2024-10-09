

namespace MechanicalWorkshopp.Entities
{
    internal class Gears
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public int PartStock { get; set; }
        public double PartPrice { get; set; }

        Gears() { }

        public Gears(int partID, string partName, int partStock, double partPrice)
        {
            PartID = partID;
            PartName = partName;
            PartStock = partStock;
            PartPrice = partPrice;
        }
    }
}
