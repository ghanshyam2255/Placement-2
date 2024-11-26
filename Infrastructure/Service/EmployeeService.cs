using Infrastructure.Data.Model.Comman;
using Infrastructure.Data.Model.Employee;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class EmployeeService : IEmployeeService //implement interface
    {
        private readonly AppDbContext _context; //private readonly vaiable                                                             
        private object ex;

        public EmployeeService(AppDbContext context)// construcotr 
        {
            _context = context;
        }


      
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            try
            {
                var activeEmployee = await _context.Employee
                                                    //.Where(c => (bool)c.IsActive == true)
                                                    .ToListAsync();
                return activeEmployee;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //public Task<ServiceResult<Employee>> GetEmployee(int id)
        //{

        //}

        
        public async Task<Response> UpdateEmployee( Employee employee)
        {
            try
            {

                var Data = _context.Employee.Update(employee);
                await _context.SaveChangesAsync();
                ////.Where(c => (bool)c.IsActive == true)
                //.ToListAsync();
                return new Response { StatuseCode = 200, Message = "Successfully Updated", Result = true };

            }
            catch (Exception)
            {

                return new Response { StatuseCode = 417, Message = $"{ex}", Result = false };

            }
        }

        public async Task<Response> DeleteEmployee(int id)
        {
            try
            {

                //var teacher =DbContext.Where(async => async.Id ==  id).FirstOrDefault();
                await _context.SaveChangesAsync();
                ////.Where(c => (bool)c.IsActive == true)
                //.ToListAsync();
                return new Response { StatuseCode = 200, Message = "Deleted Successfully", Result = true };

            }
            catch (Exception)
            {

                return new Response { StatuseCode = 417, Message = $"{ex}", Result = false };

            }
        }


        public async Task<Response> CreateEmployee(Employee employee)
        {
            Response res = new Response();
            try
            {
                employee.Createdby = "ghanshyam";
                employee.CreatedAt = DateTime.Now;
                employee.IsActive = true;
                employee.ModifiedAt = DateTime.Now;

                await _context.Employee.AddAsync(employee);
                await _context.SaveChangesAsync();


                res.Result = true;
                res.Message = "Data saved succesffuly";
                res.StatuseCode = 200;


            }
            catch (Exception ex)
            {

            }
            return res;
        }

        Task<ServiceResult<Employee>> IEmployeeService.GetEmployees(int id)
        {
            throw new NotImplementedException();
        }
    }
}
