using System;
using System.Linq;
using System.Threading.Tasks;
using AlgorithmDecide.Data;
using AlgorithmDecide.Models;
using Microsoft.AspNetCore.Mvc;



namespace AlgorithmDecide.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController: Controller
    {
        private readonly ApplicationDbContext databaseObject;
        public EmployeeController(ApplicationDbContext databaseObject)
        {
            this.databaseObject = databaseObject;
        }
        public IActionResult GetEmployees()
        {
            return Ok(databaseObject.Employees.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee objEmployee)
        {
            databaseObject.Add(objEmployee);

            await databaseObject.SaveChangesAsync();

            return new JsonResult("Employee successfully");
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] int id,[FromBody] Employee objEmployee)
        {
            if(objEmployee == null || id != objEmployee.Id)
            {
                return new JsonResult("Empoyee iis not found");
            }
            else
            {
                databaseObject.Update(objEmployee);
                await databaseObject.SaveChangesAsync();
                return new JsonResult("Emplooyee suuccessfully updated");
            }
           
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] int id, [FromBody] Employee objEmployee)
        {
            if (objEmployee == null || id != objEmployee.Id)
            {
                return new JsonResult("Empoyee iis not found");
            }
            else
            {
                databaseObject.Remove(objEmployee);
                await databaseObject.SaveChangesAsync();
                return new JsonResult("Emplooyee suuccessfully updated");
            }

        }
    }
}
