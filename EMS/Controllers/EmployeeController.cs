using EMI.Services.Interfaces;
using EMS.Entity.Entities.Employee;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers;

public class EmployeeController : BaseController
{
    private readonly IEmsWriteService _writeService;
    private readonly IEmsReadService _readService;
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(IEmsWriteService writeService, ILogger<EmployeeController> logger, IEmsReadService readService)
    {
        _writeService = writeService;
        _readService = readService;
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

    [HttpGet]
    [Route("")]
    public async Task<List<Employee>> GetEmployees()
    {
        try
        {
            return await _readService.GetEmployees();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            throw;
        }
    }
}