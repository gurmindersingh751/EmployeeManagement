using EmployeeManagement.Api.Domain.Models;
using EmployeeManagement.Api.Domain.Repositories;
using EmployeeManagement.Api.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Persistence.Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Employee>> ListAsync()
        {
            var result = await _context.Employees.ToListAsync();
            return result;
        }
    }
}
