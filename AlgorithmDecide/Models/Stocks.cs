using System;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmDecide.Models
{
    public class Stocks
    {
        [Key]
        public int StockId { get; set; }
        public string Username { get; set; }
        public string CompanyName { get; set; }
        public int StockPrice { get; set; }

    }
}
