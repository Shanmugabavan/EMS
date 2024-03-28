using EMS.Entity.Entities.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EMS.Entity.Context;

public class EmsFunctionContextRead : DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<Employee> Employees { get; set; }

    public EmsFunctionContextRead(
        DbContextOptions<EmsFunctionContextRead> options,
        IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}

