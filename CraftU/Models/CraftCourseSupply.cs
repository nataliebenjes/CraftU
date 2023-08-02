using System.Collections.Generic;

namespace CraftU.Models
{
    public class CraftCourseSupply
    {
        public int CraftCourseSupplyId { get; set; }
        public int CraftCourseId { get; set; }
        public int SupplyId { get; set; }

        public Supply Supply {get; set;}
        public CraftCourse CraftCourse {get; set;}
    }
}