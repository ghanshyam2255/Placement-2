using Infrastructure.Data.Model.Comman;
using Infrastructure.Data.Model.Department;
using Infrastructure.Data.Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Infrastructure.Interface
{
    public interface IDpartmentService
    {
        Task<IEnumerable<Department>> GetDepartment(); // Renamed to match 'Employee' context
        //Task<ServiceResult<Department>> GetDepartment(int id); // Renamed to match 'Employee' context
        //Task<Response> CreateEmployee(Department Department); // Renamed to 'PostEmployee'
        //Task<Response> UpdateEmployee(int id, Employee employee); // Renamed to 'PutEmployee'
        //Task<Response> DeleteEmployee(int id); // Renamed to 'DeleteEmployee'
        //Task GetEmployee();
        //Task CreateDepartment(Department data);
    }

}
