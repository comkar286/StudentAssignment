using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentUniversityProject.Models;

namespace StudentUniversityProject.Repositories
{
    public class CourseRespository
    {
        public List<Course> GetCourses()
        {
            using (StudentDBContext sdb=new StudentDBContext())
            {
                return sdb.Courses.ToList();
            }
        }
    }
}