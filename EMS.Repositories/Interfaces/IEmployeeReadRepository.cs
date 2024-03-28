using EMS.Entity.Entities.Employee;

namespace EMS.Repositories.Interfaces;

public interface IEmployeeReadRepository
{
    Task<List<Employee>> GetEmployeesAsync();
}