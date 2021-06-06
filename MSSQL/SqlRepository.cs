using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritance.MSSQL
{
    public class SqlRepository
    {
        public List<Student> getData()
        {
            using (var contextSQL = new StudentsSQLDBContext())
            {
                var deps = contextSQL.Departments.ToList();
                var student = contextSQL.Departments.OfType<Student>().ToList();
                return student;
            }
        }
        public void insertData()
        {
            using (var contextSQL = new StudentsSQLDBContext())
            {
                contextSQL.Departments.Add(
                    new Student
                    {
                        DepartmentName = "Department -6",
                        StudentName = "Student -6",
                        Age = 18
                    }

                    );
                contextSQL.SaveChanges();
            }
        }
    }
}
