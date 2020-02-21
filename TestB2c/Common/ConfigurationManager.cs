using System;
using Microsoft.Extensions.Configuration;
namespace Common
{
    public class ConfigurationManager
    {
        public IConfiguration configuration { get; }
        public ConfigurationManager(IConfiguration config)
        {
            this.configuration = config;
        }

        public string KeyVault()
        {
            return configuration["connectionString"];
        }

        public string ClientId()
        {
            return configuration["b2c:ClientId"];
        }
        public string ClientSecret()
        {
            return configuration["b2c:ClientSecret"];
        }
        public string TenantId()
        {
            return configuration["b2c:Tenant"];
        }
    }
}
