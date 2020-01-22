using System;
using Microsoft.Extensions.Configuration;
namespace Common
{
    public  class ConfigurationManager
    {
        public  IConfiguration configuration { get; }
        public ConfigurationManager(IConfiguration config)
        {
            this.configuration = config;
        }
       
        public  string KeyVault()
        {
            return configuration["connectionString"];
        }

      
    }
}
