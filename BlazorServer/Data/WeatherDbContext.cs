using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BlazorServer.Models;

namespace BlazorServer.Data
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<WeatherDay> Weather { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherDay>().HasData(GetWeathers());
            base.OnModelCreating(modelBuilder);
        }


        private List<WeatherDay> GetWeathers()
        {
            return new List<WeatherDay>
            {
                new WeatherDay { WeatherId = 1, WeekDay = "Monday", Temperature = 20, DateTime = DateTime.Now},
                new WeatherDay { WeatherId = 2, WeekDay = "Monday", Temperature = 20, DateTime = DateTime.Now},
                new WeatherDay { WeatherId = 3, WeekDay = "Monday", Temperature = 20, DateTime = DateTime.Now},
                new WeatherDay { WeatherId = 4, WeekDay = "Monday", Temperature = 20, DateTime = DateTime.Now}
            };
        }
    }
}
