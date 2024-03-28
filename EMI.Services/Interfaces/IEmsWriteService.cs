using EMS.Entity.Entities.Employee;

namespace EMI.Services.Interfaces;

public interface IEmsWriteService
{
    Task<Employee> CreateEmployee(Employee employee);
}