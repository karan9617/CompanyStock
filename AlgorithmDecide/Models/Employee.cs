﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmDecide.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public int Salary { get; set; }

        public string Gender { get; set; } = "male";
        public virtual Insurance EmployeeInsurance { get; set; }
    }
}
