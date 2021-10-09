using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Api.Resources
{
    public class SaveEmployeeResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
