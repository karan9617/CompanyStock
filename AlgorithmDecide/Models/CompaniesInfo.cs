using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlgorithmDecide.Models
{
    public class CompaniesInfo
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string location { get; set; }
        public float StockPrice { get; set; }
        public float Evalutation { get; set; }
 
        public DateTime DateOfOrigin { get; set; }
    }
}
