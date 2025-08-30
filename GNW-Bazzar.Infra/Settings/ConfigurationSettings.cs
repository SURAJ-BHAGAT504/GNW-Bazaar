using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using Microsoft.Extensions.Configuration;

namespace GNW_Bazzar.Infra.Settings
{
    public class ConfigurationSettings : IConfigurationSettings
    {
        public IConfiguration Configuration()
        {
            return new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
            .Build();
        }

        public JwtDto GetJwtDetails() => new()
        {
            SecurityKey = Configuration().GetValue<string>("Jwt:SecurityKey"),
            ExpiresInDays = Configuration().GetValue<string>("Jwt:ExpiresInDays")
        };
    }
}
