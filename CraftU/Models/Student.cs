using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CraftU
{
    public class Student
    {
        public int StudentId { get; set; }
        public int CraftCourseId { get; set; }
        public string StudentName { get; set; }

    }
}