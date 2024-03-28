using CSI.NET.BASE.DataAccess.GenericRepository.UOM;
using EMS.Entity.Context;
using EMS.Entity.Entities.Employee;
using EMS.Repositories.Interfaces;

namespace EMS.Repositories.Implementations;

public class EmployeeWriteRepository : IEmployeeWriteRepository
{
    private readonly EmsFunctionContextWrite _context;

    public EmployeeWriteRepository(EmsFunctionContextWrite context)
    {
        _context = context;
    }

    public async Task<Employee> CreateEmployeeAsync(Employee employee)
    {
        var entityEntry = await _context.Employees.AddAsync(employee);
        await _context.SaveChangesAsync();
        return entityEntry is not null ? employee : null;
    }
}