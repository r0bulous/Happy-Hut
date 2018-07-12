using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Happy_Hut.Models
{
    public class Employee
    {
        [Key]

        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePhone { get; set; }
        public int EmployeeNum { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string HireDate { get; set; }

    }
}