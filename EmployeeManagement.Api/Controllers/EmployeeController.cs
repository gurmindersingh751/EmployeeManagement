using EmployeeManagement.Api.Domain.Models;
using EmployeeManagement.Api.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult HealthCheck()
        {
            return Ok("Welcome to Employee Management.");
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            var result = await _employeeService.ListAsync();
            return result;
        }
    }
}
