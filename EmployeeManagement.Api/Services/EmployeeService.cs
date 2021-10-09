using EmployeeManagement.Api.Domain.Models;
using EmployeeManagement.Api.Domain.Repositories;
using EmployeeManagement.Api.Domain.Services;
using EmployeeManagement.Api.Domain.Services.Communication;

namespace EmployeeManagement.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeService(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Employee>> ListAsync()
        {
            return await _employeeRepository.ListAsync();
        }

        public async Task<EmployeeResponse> SaveAsync(Employee employee)
        {
            try
            {
                await _employeeRepository.AddAsync(employee);
                _unitOfWork.CompleteAsync();


                return new EmployeeResponse(employee);
            }
            catch (Exception ex)
            {
                return new EmployeeResponse($"An error occured when saving the category: { ex.Message }");
            }
        }
    }
}
