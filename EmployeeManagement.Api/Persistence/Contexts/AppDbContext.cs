using EmployeeManagement.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees {  get; set; }
        public DbSet<Department> Departments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Employee>().ToTable("Employees");
            builder.Entity<Employee>().HasKey(e => e.Id);
            builder.Entity<Employee>().Property(e => e.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Employee>().Property(e => e.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Employee>().HasOne(e => e.Department).WithOne(e => e.Employee).HasForeignKey<Department>(e => e.EmployeeId);

            builder.Entity<Employee>().HasData
                (
                new Employee { Id = 1, Name = "Harjinder" }
                );

            builder.Entity<Department>().ToTable("Departments");
            builder.Entity<Department>().HasKey(d => d.Id);
            builder.Entity<Department>().Property(d => d.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Department>().Property(d => d.Name).IsRequired().HasMaxLength(50);

        }
    }
}
