using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFInheritance.MSSQL
{
    public partial class StudentsSQLDBContext : DbContext
    {
        public StudentsSQLDBContext()
            : base("name=StudentsSQLDBContext")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        //public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>()
            //    .Property(e => e.StudentName)
            //    .IsUnicode(false);
        }
    }
}
