

namespace MechanicalWorkshopp.Entities
{
    internal class MechanicalWork
    {
        public int Id { get; set; }
        public string ProcedureName { get; set; }
        public double WorkCost { get; set; }

        MechanicalWork() { }

        public MechanicalWork(int id, string procedureName, double workCost)
        {
            Id = id;
            ProcedureName = procedureName;
            WorkCost = workCost;
        }
    }
}
