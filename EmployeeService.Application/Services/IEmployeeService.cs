
using EmployeeService.Application.Model;

namespace EmployeeService.Application.Services
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetEmployees();
        EmployeeDto GetEmployeeById(int id);
        void CreateEmployee(EmployeeDto employeeDto);
        void UpdateEmployee(int id, EmployeeDto employeeDto);
        void DeleteEmployee(int id);
    }
}
