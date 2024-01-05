using EmployeeService.Domain.Entities;
using EmployeeService.Infrastructure.Data;

namespace EmployeeService.Infrastructure.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context) { }
    }
}
