﻿using HandlingDb.Models;
using Microsoft.EntityFrameworkCore;

namespace HandlingDb.Contexts
{
    public class TeamDbContext : DbContext
    {
        public DbSet<CricketerDetails> CricketerDeatils { get; set; }
        public TeamDbContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configurationInstance = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName ?? ".")
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile("appsettings.local.json", optional: true)
                .Build();

            string dbConnString = configurationInstance["ConnectionStrings:DbTeam"] ?? "";
            optionsBuilder.UseNpgsql(dbConnString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
