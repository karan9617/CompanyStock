using System;
using AlgorithmDecide.Models;
using Microsoft.EntityFrameworkCore;

namespace AlgorithmDecide.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
    }
}
