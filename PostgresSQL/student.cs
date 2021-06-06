using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritance.PostgresSQL
{
    [Table("student")]
    public partial class student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long studentid { get; set; }

        [Required]
        public string studentname { get; set; }

        public int age { get; set; }

        public long departmentid { get; set; }

        public virtual department department { get; set; }
    }
}
