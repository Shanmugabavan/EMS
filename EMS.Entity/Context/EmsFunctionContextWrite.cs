using EMS.Entity.Entities.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EMS.Entity.Context;

public class EmsFunctionContextWrite : DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<Employee> Employees { get; set; }

    public EmsFunctionContextWrite(
        DbContextOptions<EmsFunctionContextWrite> options,
        IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
