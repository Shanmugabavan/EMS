using EMI.Services.Interfaces;
using EMS.Entity.Entities.Employee;
using EMS.Repositories.Interfaces;

namespace EMI.Services.Implementations;

public class EmsReadService : IEmsReadService
{
    private readonly IEmployeeReadRepository _employeeReadRepository;

    public EmsReadService(IEmployeeReadRepository employeeReadRepository)
    {
        _employeeReadRepository = employeeReadRepository;
    }

    public async Task<List<Employee>> GetEmployees()
    {
        return await _employeeReadRepository.GetEmployeesAsync();
    }
}