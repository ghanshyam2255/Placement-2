using Infrastructure.Data.Model.Comman;
using Infrastructure.Data.Model.Department;
using Infrastructure.Interface;
using Infrastructure.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        
        private readonly IDpartmentService _departmentService;

        public DepartmentController(IDpartmentService empService)
        {
            _departmentService = empService;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<Department>>> Get()
        {
            try
            {
                var employee = await _departmentService.GetDepartment();

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
        public async Task<ActionResult<Response>> Post(Department data)
        {
            //try
            //{
            //    var res = await _departmentService.CreateDepartment(data);

            //    if (res == null)
            //    {
            //        return NotFound();
            //    }

            //    return Ok(res);
            //}
            //catch (Exception ex)
            //{
            //    // Log the exception
            //    return StatusCode(500, "Internal server error");
            //}
            return null;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {


        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    }

