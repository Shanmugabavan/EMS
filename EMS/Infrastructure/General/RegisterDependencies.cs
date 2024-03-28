using EMI.Services.Implementations;
using EMI.Services.Interfaces;
using EMS.Repositories.Implementations;
using EMS.Repositories.Interfaces;

namespace EMS.Infrastructure.General;

public static class RegisterDependencies
{
    public static void AddAppDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IEmsWriteService, EmsWriteService>();
        services.AddScoped<IEmsReadService, EmsReadService>();
        
        services.AddSingleton(configuration);
        
        services.AddScoped<IEmployeeWriteRepository, EmployeeWriteRepository>();
        services.AddScoped<IEmployeeReadRepository, EmployeeReadRepository>();
    }
}

