using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BlazorServer.Models;

namespace BlazorServer.Data
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext()
        {
        }
        
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
                new WeatherDay { WeatherId = 1, /* WeekDay = "Monday",*/ Temperature = 19, DateTime = DateTime.Now},
                new WeatherDay { WeatherId = 2, /* WeekDay = "Tuesday", */ Temperature = 20, DateTime = DateTime.Now},
                new WeatherDay { WeatherId = 3, /* WeekDay = "Wednesday", */ Temperature = 18, DateTime = DateTime.Now},
                new WeatherDay { WeatherId = 4, /* WeekDay = "Thursday", */ Temperature = 21, DateTime = DateTime.Now},
                new WeatherDay { WeatherId = 5, /* WeekDay = "Friday", */ Temperature = 17, DateTime = DateTime.Now}
            };
        }
    }
}
