using System;
using System.Collections.Generic;
using AlgorithmDecide.Data;
using AlgorithmDecide.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace AlgorithmDecide.Controllers
{
    public class MainController: Controller
    {
        ApplicationDbContext applicationDbContext;
        public MainController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(string EmployeeName)
        {
            string ConnectionString = "Server=localhost,1433; Database=AspCoreCRUD; User=sa; Password=Kr96%a5b";
            List<EmployeeInsurance> result = new List<EmployeeInsurance>();
            
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("select Employees.FirstName, Employees.Salary,Insurance.InsuranceName from Employees INNER JOIN Insurance ON Employees.Id = Insurance.Id"))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlConnection.Open();
                        sqlDataAdapter.SelectCommand = sqlCommand;

                        SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                        while (sqlReader.Read())
                        {
                            EmployeeInsurance employeeInsurance = new EmployeeInsurance();
                            employeeInsurance.EmployeeName = sqlReader["FirstName"].ToString();
                            employeeInsurance.Salary = sqlReader["Salary"].ToString();
                            employeeInsurance.InsuranceName = sqlReader["InsuranceName"].ToString();
                            result.Add(employeeInsurance);
                        }
                    }
                    
                }
            }
            ViewData["result"] = result;
            return View();
        }

    }
}
