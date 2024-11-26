using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Model.Department
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        //[Column(TypeName = "Varchar(50)")]
        [Required]
        public string? DepartmentName { get; set; }

        //[Column(TypeName = "Varchar(50)")]
        //public string Email { get; set; }

        //[Column(TypeName = "Varchar(20)")]
        //public string ContactNumber { get; set; }

        //[Column(TypeName = "Varchar(100)")]
        //public string Address { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? Modifiedby { get; set; }

    }
}
