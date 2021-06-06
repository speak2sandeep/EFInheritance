using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritance.PostgresSQL
{
    public partial class StudentsPGDBContext : DbContext
    {
        public StudentsPGDBContext()
            : base("name=StudentsPGDBContext")
        {
        }

        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<StudentsPGDBContext>(null);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Entity<department>()
                .HasMany(e => e.students)
                .WithRequired(e => e.department)
                .WillCascadeOnDelete(false);
        }
    }
}
