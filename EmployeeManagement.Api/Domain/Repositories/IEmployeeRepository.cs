using EmployeeManagement.Api.Domain.Models;

namespace EmployeeManagement.Api.Domain.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> ListAsync();
    }
}
