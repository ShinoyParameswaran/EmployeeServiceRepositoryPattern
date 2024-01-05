using EmployeeService.Infrastructure.Repositories;
using EmployeeService.Infrastructure.UnitOfWork;

namespace EmployeeServiceEF_Code_First.UnitOfWork
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; }       

        int Complete();
    }

}
