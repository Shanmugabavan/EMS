using EMI.DTO.ConfigRepo;

namespace EMS.Infrastructure.General;

public class ConfigRepository
{
    private readonly IConfiguration _configuration;

    public ConfigRepository(IConfiguration configuration)
    {
        _configuration = configuration;

    }

    public void SetRepository()
    {
        ConfigRepo.ReadConection = GetConnectionString();
        ConfigRepo.WriteConnection = GetConnectionString();
    }
    

    public string GetConnectionString()
    {
        return _configuration.GetConnectionString("DefaultConnection");
    }
}

