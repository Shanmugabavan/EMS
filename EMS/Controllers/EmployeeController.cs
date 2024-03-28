using EMI.Services.Interfaces;
using EMS.Entity.Entities.Employee;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers;

public class EmployeeController : BaseController
{
    private readonly IEmsWriteService _writeService;
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(IEmsWriteService writeService, ILogger<EmployeeController> logger)
    {
        _writeService = writeService;
        _logger = logger;
    }
    
    [HttpPost]
    [Route("")]
    public async Task<Employee> CreateEmployee([FromBody] Employee employee)
    {
        try
        {
            return await _writeService.CreateEmployee(employee);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            throw;
        }
    }
}