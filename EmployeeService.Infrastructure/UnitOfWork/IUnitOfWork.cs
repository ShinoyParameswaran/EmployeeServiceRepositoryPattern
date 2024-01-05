using EmployeeService.Infrastructure.Repositories;
using EmployeeService.Infrastructure.UnitOfWork;

namespace EmployeeService.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; }       

        int Complete();
    }

}
