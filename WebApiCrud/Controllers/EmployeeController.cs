using Infrastructure.Data.Model.Comman;
using Infrastructure.Data.Model.Employee;
using Infrastructure.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService empService)
        {
            _employeeService = empService;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            try
            {
                var employee = await _employeeService.GetEmployees();

                if (employee == null)
                {
                    return NotFound();
                }

                return Ok(employee);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "Internal server error");
            }
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<ActionResult<Response>> Post(Employee employee)
        {
            try
            {
                var res = await _employeeService.CreateEmployee(employee);

                if (res == null)
                {
                    return NotFound();
                }

                return Ok(res);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Response>> Put(Employee employee)
        {
            try
            {
                var res = await _employeeService.UpdateEmployee(employee);

                if (res == null)
                {
                    return NotFound();
                }

                return Ok(res);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "Internal server error");
            }
        }


        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public  async Task<ActionResult<Response>> Delete(int id)

        {
            try
            {
                var res = await _employeeService.DeleteEmployee( id);

                if (res == null)
                {
                    return NotFound();
                }

                return Ok(Delete);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
