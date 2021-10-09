using EmployeeManagement.Api.Domain.Models;
using EmployeeManagement.Api.Domain.Services.Communication;

namespace EmployeeManagement.Api.Domain.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> ListAsync();
        Task<EmployeeResponse> SaveAsync(Employee employee);
        Task<EmployeeResponse> UpdateAsync(int id, Employee employee);
        Task<EmployeeResponse> DeleteAsync(int id);
    }
}
