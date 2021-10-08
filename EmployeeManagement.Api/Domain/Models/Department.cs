namespace EmployeeManagement.Api.Domain.Models
{
    public class Department
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public int EmployeeId {  get; set; }
        public Employee Employee {  get; set; }
    }
}
