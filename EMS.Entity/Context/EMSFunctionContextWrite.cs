using EMS.Entity.Entities.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entity.Context;

public class EMSFunctionContextWrite : DbContext
{
    private readonly ILogger<EMSFunctionContextWrite> logger;

    private readonly IConfiguration _configuration;

    public DbSet<Employee> Employees { get; set; }

    public EMSFunctionContextWrite(
        DbContextOptions<EMSFunctionContextWrite> options,
        ILogger<EMSFunctionContextWrite> logger, IConfiguration configuration) : base(options)
    {
        this.logger = logger;
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
