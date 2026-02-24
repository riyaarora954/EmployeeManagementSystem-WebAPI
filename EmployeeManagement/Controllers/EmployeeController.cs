using EMS.ServiceLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EMS.WebAPI.Controllers
{
    [Controller]
    [Route("/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public IActionResult GetEmployee()
        {
            return Ok(_employeeService.GetEmployee());
        }
    }
}