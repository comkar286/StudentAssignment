using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentUniversityProject.Models;

namespace StudentUniversityProject.Repositories
{
    public class DepartmentRepository
    {
        public List<Department> GetDepartments()
        {
            using (StudentDBContext sdb= new StudentDBContext())
            {
                return sdb.Departments.ToList();
            }
        }
    }
}