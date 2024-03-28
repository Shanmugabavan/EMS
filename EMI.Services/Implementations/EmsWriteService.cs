using EMI.Services.Interfaces;
using EMS.Entity.Entities.Employee;
using EMS.Repositories.Interfaces;

namespace EMI.Services.Implementations;

public class EmsWriteService : IEmsWriteService
{
    private readonly IEmployeeWriteRepository _employeeWriteRepository;

    public EmsWriteService(IEmployeeWriteRepository employeeWriteRepository)
    {
        _employeeWriteRepository = employeeWriteRepository;
    }

    public async Task<Employee> CreateEmployee(Employee employee)
    {
        var employeeInstance = await _employeeWriteRepository.CreateEmployeeAsync(employee);
        return employeeInstance;
    }
    
    public async Task<Employee> UpdateEmployee(Guid id, Employee employee)
    {
        var employeeInstance = await _employeeWriteRepository.UpdateEmployeeAsync(id, employee);
        return employeeInstance;
    }
}