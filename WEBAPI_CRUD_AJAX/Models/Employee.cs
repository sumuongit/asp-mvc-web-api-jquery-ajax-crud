using System;
using System.ComponentModel.DataAnnotations;

namespace WEBAPI_CRUD_AJAX.Models
{
    public class Employee
    {
        public Employee()
        {

        }  
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}