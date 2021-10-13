using AutoMapper;
using EmployeeManagement.Api.Controllers;
using EmployeeManagement.Api.Domain.Models;
using EmployeeManagement.Api.Domain.Repositories;
using EmployeeManagement.Api.Domain.Services;
using EmployeeManagement.Api.Resources;
using EmployeeManagement.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EmployeeManagement.Tests
{
    public class EmployeeControllerTests
    {
        private readonly EmployeeService _employeeService;

        private readonly Mock<IEmployeeRepository> _employeeRepository = new Mock<IEmployeeRepository>();
        private readonly Mock<IUnitOfWork> _unitOfWork = new Mock<IUnitOfWork>();

        public EmployeeControllerTests()
        {
           _employeeService = new EmployeeService(_employeeRepository.Object, _unitOfWork.Object);
        }

        [Fact]
        public async void GetAllEmployees_WhenCalled_ReturnsAllEmployees()
        {
            //Arrange
            var employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Harjinder" },
                new Employee { Id = 2, Name = "Gurminder" }
            };

            //Act

            _employeeRepository.Setup(repo => repo.ListAsync()).ReturnsAsync(employees);

            var result = await _employeeService.ListAsync();

            //Assert

            Assert.Equal(2, result.Count());

        }

    }
}