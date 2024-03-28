using EMS.Entity.Entities.Employee;

namespace EMS.Repositories.Interfaces;

public interface IEmployeeWriteRepository
{
    Task<Employee> CreateEmployeeAsync(Employee employee);
    Task<Employee> UpdateEmployeeAsync(Guid id, Employee employee);
}