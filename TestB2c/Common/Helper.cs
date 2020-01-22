using System;
using System.Configuration;

namespace Common
{
    public static class Helper
    {
        public static string TenantId
        {

            get

            {
                var appsettingValue = Environment.GetEnvironmentVariable("b2c:Tenant");
                return !string.IsNullOrEmpty(appsettingValue) ? appsettingValue : System.Configuration.ConfigurationManager.AppSettings.Get("b2c:Tenant");
            }
        }
        public static string ClientId
        {
            get

            {
                var appsettingValue = Environment.GetEnvironmentVariable("b2c:ClientId");
                return !string.IsNullOrEmpty(appsettingValue) ? appsettingValue : System.Configuration.ConfigurationManager.AppSettings.Get("b2c:ClientId");
            }
        }
        public static string ClientSecret
        {
            get

            {
                var appsettingValue = Environment.GetEnvironmentVariable("b2c:ClientSecret");
                return !string.IsNullOrEmpty(appsettingValue) ? appsettingValue : System.Configuration.ConfigurationManager.AppSettings.Get("b2c:ClientSecret");
            }
        }
        public static string KeyVault
        {
            get

            {
                var appsettingValue = Environment.GetEnvironmentVariable("Keyvault");
                return !string.IsNullOrEmpty(appsettingValue) ? appsettingValue : System.Configuration.ConfigurationManager.AppSettings.Get("Keyvault");
            }
        }
    }
}
