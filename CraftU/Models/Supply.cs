using System.Collections.Generic;



namespace CraftU.Models
{
    public class Supply
    {
        public int SupplyId { get; set; }
        public int CraftCourseId { get; set; }
        public string SupplyName { get; set; }
        public int SupplyCost { get; set; }
        public List<CraftCourseSupply> JoinEntities { get; }
    }
}