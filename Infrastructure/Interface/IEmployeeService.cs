using Infrastructure.Data.Model.Comman;
using Infrastructure.Data.Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Infrastructure.Interface
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees(); // Renamed to match 'Employee' context
        Task<ServiceResult<Employee>> GetEmployees(int id); // Renamed to match 'Employee' context
        Task<Response> CreateEmployee(Employee employee); // Renamed to 'PostEmployee'
        Task<Response> UpdateEmployee(Employee employee); // Renamed to 'PutEmployee'
        Task<Response> DeleteEmployee(int id); // Renamed to 'DeleteEmployee'
    }

}
