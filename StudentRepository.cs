using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentUniversityProject.Models;

namespace StudentUniversityProject
{
    public class StudentRepository
    {
        public List<Student> GetStudents()
        {
            using (StudentDBContext sdb = new StudentDBContext())
            {
                return sdb.Students.ToList();
            }
        }
        
    }
}