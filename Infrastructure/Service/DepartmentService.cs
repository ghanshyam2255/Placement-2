using Infrastructure.Data.Model.Comman;
using Infrastructure.Data.Model.Department;
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
    public class DepartmentService : IDpartmentService //implement interface
    {
        private readonly AppDbContext _context; //private readonly vaiable


        public DepartmentService(AppDbContext context)// construcotr
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetDepartment()
        {
            try
            {
                var activeEmployee = await _context.Department
                                                    //.Where(c => (bool)c.IsActive == true)
                                                    .ToListAsync();
                return activeEmployee;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}