using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritance.PostgresSQL
{
    public class PGRepository
    {
        public List<student> getData()
        {
            using (var contextPG = new StudentsPGDBContext())
            {
                //var deps = contextSQL.departments.ToList();
                var student = contextPG.students.ToList();
                return student;
            }
        }
        public void insertData()
        {
            using (var contextPG = new StudentsPGDBContext())
            {
                contextPG.students.Add(
                    new student
                    {
                        department=new department() { departmentname="department-1"},
                        studentname = "student -1",
                        age = 19
                    }

                    );
                contextPG.SaveChanges();
            }
        }
    }
}
