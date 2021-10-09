using AutoMapper;
using EmployeeManagement.Api.Domain.Models;
using EmployeeManagement.Api.Resources;

namespace EmployeeManagement.Api.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Employee, EmployeeResource>();
        }
    }
}
