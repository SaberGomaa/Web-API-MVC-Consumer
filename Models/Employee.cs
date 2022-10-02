using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_API_MVC_Consumer.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="*")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*")]

        public int Age { get; set; }
        [Required(ErrorMessage = "*")]
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "*")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

    }
}