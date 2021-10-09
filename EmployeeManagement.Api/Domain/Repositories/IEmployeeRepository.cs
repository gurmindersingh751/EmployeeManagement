using EmployeeManagement.Api.Domain.Models;
using EmployeeManagement.Api.Domain.Services.Communication;

namespace EmployeeManagement.Api.Domain.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> ListAsync();
        Task<Employee> FindByIdAsync(int id);
        Task AddAsync(Employee employee);
        void Update(Employee employee);
        void Remove(Employee employee);
    }
}
