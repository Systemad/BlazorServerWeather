using System;
using System.Collections.Generic;
using System.Linq;
using BlazorServer.Data;
using BlazorServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlazorServer.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {

        private WeatherDbContext _dbContext;

        public WeatherController(WeatherDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        // /api/Weather/Weathers
        [HttpGet]
        [Route("Weathers")]
        public List<WeatherDay> GetAllWeather()
        {
            var list = _dbContext.Weather
                    .ToList();
                return list;
        }
        
        // /api/Weather/WeatherById/{id}
        [HttpGet]
        [Route("WeatherById/{id}")]
        public WeatherDay GetWeatherById(int id)
        {
            var weather = _dbContext.Weather
                    .FirstOrDefault(b => b.WeatherId == id);
                return weather;
        }
        
        // /api/Weather/DeleteWeatherById/{id}
        [HttpDelete]
        [Route("DeleteWeatherById/{id}")]
        public void DeleteWeatherById(int id)
        {
            var weather = _dbContext.Weather.Single(b => b.WeatherId == id);
                
                if(weather != null)
                {
                    _dbContext.Weather.Remove(weather);
                    _dbContext.SaveChangesAsync();
                }
        }
        
        // /api/Weather/AddWeather
        [HttpPost]
        [Route("api/AddWeather")]
        public void PostWeather(/*[FromForm] string weekday,*/ [FromQuery] int temp)
        {
            //db.Database.EnsureCreated();
            _dbContext.Weather.Add(new WeatherDay
            {
                Temperature = temp, 
                DateTime = DateTime.Now
                //WeekDay = weekday
            });
            _dbContext.SaveChangesAsync();
        }
    }
}