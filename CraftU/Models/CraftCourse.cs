using System.Collections.Generic;

namespace CraftU.Models
{
    public class CraftCourse
    {
        public int CraftCourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDate { get; set; }
        public List<Supply> Supplies { get; set; }
        public List<Student> Students { get; set; }
        public List<CraftCourseStudent> JoinEntities {get;}
        public List<CraftCourseSupply> JoinMoreEntities {get;}
    }
}
