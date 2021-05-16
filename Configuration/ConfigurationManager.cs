using Microsoft.Extensions.Configuration;

namespace Configuration
{
    public static class ConfigurationManager
    {
        public static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json");
            var configuration = builder.Build();

            return configuration["ConnectionStrings:DefaultConnection"];
        }
    }
}
