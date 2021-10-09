using EmployeeManagement.Api.Domain.Models;
using EmployeeManagement.Api.Domain.Repositories;
using EmployeeManagement.Api.Domain.Services.Communication;
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
            return await _context.Employees.ToListAsync();
        }
        public async Task<Employee> FindByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task AddAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
        }

        public void Remove(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

    }
}
