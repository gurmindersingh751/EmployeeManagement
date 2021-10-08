using EmployeeManagement.Api.Persistence.Contexts;

namespace EmployeeManagement.Api.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
