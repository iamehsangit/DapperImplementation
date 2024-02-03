using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts;

namespace WebApplication1.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmpolyeeRepository _empolyeeRepository;

        public EmployeeController(IEmpolyeeRepository empolyeeRepository)
        {
            _empolyeeRepository = empolyeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployee()

        {
            var employess =await _empolyeeRepository.GetEmployees();
            return Ok(employess);
        }
    }
}
