using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentUniversityProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; } 
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }

        public List<Course> courses { get; set; }
        public Department department { get; set; }
        public Instructor instructor { get; set; }
        
    }
}