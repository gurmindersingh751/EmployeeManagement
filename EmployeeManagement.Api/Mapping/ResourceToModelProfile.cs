using AutoMapper;
using EmployeeManagement.Api.Domain.Models;
using EmployeeManagement.Api.Resources;

namespace EmployeeManagement.Api.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveEmployeeResource, Employee>();
        }
    }
}
