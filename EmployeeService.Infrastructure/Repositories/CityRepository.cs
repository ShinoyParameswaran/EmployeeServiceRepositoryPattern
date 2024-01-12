using EmployeeService.Domain.Entities;
using EmployeeService.Infrastructure.Data;

namespace EmployeeService.Infrastructure.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(AppDbContext context) : base(context) { }
    
    }
}
