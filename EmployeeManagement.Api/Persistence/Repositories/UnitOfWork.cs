using EmployeeManagement.Api.Domain.Repositories;
using EmployeeManagement.Api.Persistence.Contexts;

namespace EmployeeManagement.Api.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
