using EMS.Entity.Context;
using EMS.Entity.Entities.Employee;
using EMS.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EMS.Repositories.Implementations;

public class EmployeeReadRepository : IEmployeeReadRepository
{
    private readonly EmsFunctionContextRead _context;

    public EmployeeReadRepository(EmsFunctionContextRead context)
    {
        _context = context;
    }

    public async Task<List<Employee>> GetEmployeesAsync()
    {
        return await _context.Employees.ToListAsync();
    }
}