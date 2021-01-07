using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.NTier.DataAccess.Configuration;
using AspNetCore.NTier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.NTier.DataAccess.DataContext
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configManager = new ConfigManager();
            var defaultConnectionString = configManager.DefaultConnectionString;
            optionsBuilder.UseSqlServer(defaultConnectionString);
        }
        public DbSet<User> Users { get; set; }
    }
}
