using CSI.NET.BASE.DataAccess.GenericRepository.UOM;
using EMS.Entity.Context;
using EMS.Entity.Entities.Employee;
using EMS.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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
    
    public async Task<Employee> UpdateEmployeeAsync(Guid id,Employee employee)
    {
        var employeeInstance = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
        employeeInstance!.Email = employee.Email;
        employeeInstance.Name = employee.Name;
        employeeInstance.IsCurrentlyEmployed = employee.IsCurrentlyEmployed;
        _context.Employees.Update(employeeInstance);
        await _context.SaveChangesAsync();
        return employeeInstance;
    }
}