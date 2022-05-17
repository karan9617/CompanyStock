using System;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmDecide.Models
{
    public class Insurance
    {
        [Key]
        public int Id { set; get; }

        public string InsuranceName { get; set; }
        public double PercentageTax { get; set; }
    }
}
