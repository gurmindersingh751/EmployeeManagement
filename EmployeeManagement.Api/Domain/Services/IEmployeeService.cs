using EmployeeManagement.Api.Domain.Models;

namespace EmployeeManagement.Api.Domain.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> ListAsync();
    }
}
