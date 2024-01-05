using EmployeeService.Domain.Entities;


namespace EmployeeService.Infrastructure.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        // Define specific methods for Employee if needed.
    }
}
