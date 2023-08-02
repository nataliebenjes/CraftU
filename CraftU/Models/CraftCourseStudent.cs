using System.Collections.Generic;

namespace CraftU.Models
{
    public class CraftCourseStudent
    {
        public int CraftCourseStudentId {get; set;}
        public int CourseStudentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public CraftCourse CraftCourse { get; set; }
        public Student Student { get; set; }
    }
}