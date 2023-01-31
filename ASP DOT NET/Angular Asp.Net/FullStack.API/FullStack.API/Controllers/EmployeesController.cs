using FullStack.API.Data;
using FullStack.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly FullstackDbContext _fullStackDbContext;

        public EmployeesController(FullstackDbContext fullStackDbContext)
        {
            _fullStackDbContext = fullStackDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _fullStackDbContext.Employees.ToListAsync();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();

            await   _fullStackDbContext.Employees.AddAsync(employee);
            await   _fullStackDbContext.SaveChangesAsync();

            return Ok(employee);

        }


        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetEmployee(Guid id)
        {
            var employee = await _fullStackDbContext.Employees
                .FirstOrDefaultAsync(x => x.Id == id);

            if(employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateEmployee(Guid id , Employee employee)
        {
            var employeeUpdate = await _fullStackDbContext.Employees.FindAsync(id);

            if(employeeUpdate == null) { return NotFound(); } 
            
            employeeUpdate.Name = employee.Name;
            employeeUpdate.Email = employee.Email;
            employeeUpdate.Phone = employee.Phone;
            employeeUpdate.Salary = employee.Salary;
            employeeUpdate.Department = employee.Department;

            await _fullStackDbContext.SaveChangesAsync();
            return Ok(employee);

        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteEmployee(Guid id)
        {
            var employee = await _fullStackDbContext.Employees.FindAsync(id);

            if(employee == null) { return NotFound(); }

             _fullStackDbContext.Employees.Remove(employee);
            await _fullStackDbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
