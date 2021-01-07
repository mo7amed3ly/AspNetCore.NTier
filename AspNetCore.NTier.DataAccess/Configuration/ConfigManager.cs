using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace AspNetCore.NTier.DataAccess.Configuration
{
    public class ConfigManager
    {
        public ConfigManager()
        {
            var configBuilder = new ConfigurationBuilder();
            configBuilder.AddJsonFile("appsettings.json");
            var root = configBuilder.Build();
            DefaultConnectionString = root.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
        public string DefaultConnectionString { get; set; }

    }
}
