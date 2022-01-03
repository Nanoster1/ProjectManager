using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ProjectManager;

public class Settings
{
    private IConfiguration _configuration;

    public Settings(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public void SetDbOptions(DbContextOptionsBuilder builder)
    {
        builder.UseNpgsql(_configuration.GetConnectionString("Default"));
    }

    public void SetIdentityOptions(IdentityOptions options)
    {
        options.Password = new PasswordOptions()
        {
            RequireDigit = false,
            RequiredLength = 8,
            RequireLowercase = false,
            RequireUppercase = false,
            RequiredUniqueChars = 2,
            RequireNonAlphanumeric = false
        };
    }
}