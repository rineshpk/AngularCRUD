using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            return Ok(await _employeeRepository.GetEmployees());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetEmployee(int id)
        {
            return Ok(await _employeeRepository.GetEmployee(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee(Employee employee)
        {
            return Ok(await _employeeRepository.AddEmployee(employee));
        }
        
        [HttpPut]
        public async Task<ActionResult> UpdateEmployee(Employee employee)
        {
            return Ok(await _employeeRepository.UpdateEmployee(employee));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            return Ok(await _employeeRepository.DeleteEmployee(id));
        }
    }
}