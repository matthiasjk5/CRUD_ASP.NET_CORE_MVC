using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ASP.NET_CORE_MVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage ="This field is required")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Employee Code")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }

        [DisplayName("Office Location")]
        [Column(TypeName = "varchar(100)")]
        public string OfficeLocation { get; set; }

    }
}
