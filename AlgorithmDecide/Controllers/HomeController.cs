using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlgorithmDecide.Models;
using AlgorithmDecide.Data;

namespace AlgorithmDecide.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext applicationDbContext;
        public HomeController(ILogger<HomeController> logger,ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            this.applicationDbContext = applicationDbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {

            //return Ok(applicationDbContext.Employees.ToList());
            return View();
        }

        [HttpPost]
        public IActionResult FormForLogin(string username, string password)
        {
            
            Employee employeeToFind1 = applicationDbContext.Employees.FirstOrDefault(employee => employee.FirstName == username);
            if (employeeToFind1 == null)
            {
                return Content("not found");

            }
            else
            {
                return View("~/Views/Main/Index.cshtml",employeeToFind1);
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> Register(string firstName, string lastName, string Address, string salary)
        {
            Employee employeeToInsert = new Employee();
            employeeToInsert.FirstName = firstName;
            employeeToInsert.LastName = lastName;
            employeeToInsert.Address = Address;
            employeeToInsert.Salary = Int32.Parse(salary);
            applicationDbContext.Add(employeeToInsert);
           
            await applicationDbContext.SaveChangesAsync();


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
