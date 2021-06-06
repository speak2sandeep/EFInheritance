namespace EFInheritance.MSSQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student : Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        //public int? DepartmentId { get; set; }

        [StringLength(50)]
        public string StudentName { get; set; }

        public short? Age { get; set; }

        //public virtual Department Department { get; set; }
    }
}
