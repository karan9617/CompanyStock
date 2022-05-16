using System;
using AlgorithmDecide.Models;
using Microsoft.EntityFrameworkCore;

namespace AlgorithmDecide.Data
{
    public class ApplicationDbContextForCompanies: DbContext
    {
        public ApplicationDbContextForCompanies(DbContextOptions<ApplicationDbContextForCompanies> optionsForCompanies) : base(optionsForCompanies)
        {

        }
        public DbSet<CompaniesInfo> Companies { get; set; }
    }
}
