using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentUniversityProject.Models;

namespace StudentUniversityProject.Repositories
{
    public class InstructorRepository
    {
        public List<Instructor> GetInstructors()
        {
            using (StudentDBContext sdb= new StudentDBContext())
            {
                return sdb.Instructors.ToList();
                
            }
        }
    }
}