using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using BlazorServer.Models;
using Bogus;

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

        public DbSet<WeatherDay> WeatherDays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<WeatherDay>()
            //    .Property(e => e.WeatherId)
            //    .ValueGeneratedOnAdd();
            
            base.OnModelCreating(modelBuilder);
            //FakeData.GenerateWeather(200);
            modelBuilder.Entity<WeatherDay>().HasData(FakeData.WeatherDays);
        }

        public static class FakeData
        {
            public static List<WeatherDay> WeatherDays = new List<WeatherDay>();
            public static void GenerateWeather(int weathercount)
            {
                var weatherId = 1;
                for( var i = 0; i < weathercount; i++, weatherId++)
                {
                    int temperature = new Random().Next(15, 25);
                    
                    DateTime start = new DateTime(2020, 1, 1); 
                    Random gen = new Random(); 
                    int range = (DateTime.Today - start).Days;
                    var dayofweek = start.AddDays(gen.Next(range));
                    
                    var weather = new WeatherDay
                    {
                        WeatherId = weatherId,
                        Temperature = temperature,
                        WeekDay = dayofweek.DayOfWeek.ToString(),
                        DateTime = dayofweek
                    };
                    WeatherDays.Add(weather);
                }
            }
        }
    }
}
