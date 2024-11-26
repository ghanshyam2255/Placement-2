    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Model.Employee
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }
        //[Required]
        //[Column(TypeName = "Varchar(50)")]
        public string? Name { get; set; }
        //[Required]
        //[Column(TypeName = "Varchar(50)")]
        public string? Email { get; set; }
        //[Required]
        //[Column(TypeName = "Varchar(20)")]
        public string? ContactNumber { get; set; }
        //[Required]
        //[Column(TypeName = "Varchar(100)")]

        public string? Address { get; set; }

        public string? Skills { get; set; }


        public bool? IsActive { get; set; } 
        public DateTime? CreatedAt { get; set; }
        public string? Createdby { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? Modifiedby { get; set; }





    }
}
