﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EmployeesCh12.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Department")]
        public string Name { get; set; }

        // Navgation property
        public virtual ICollection<Employee> Employees { get; set; }

        // Navigation Property

        public ICollection<DepartmentLocation> DepartmentLocations { get; set; }
    }
}