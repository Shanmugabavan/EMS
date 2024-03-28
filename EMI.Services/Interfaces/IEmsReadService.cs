using EMS.Entity.Entities.Employee;

namespace EMI.Services.Interfaces;

public interface IEmsReadService
{
    Task<List<Employee>> GetEmployees(); 
}