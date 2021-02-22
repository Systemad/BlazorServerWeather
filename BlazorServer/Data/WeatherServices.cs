using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServer.Models;

namespace BlazorServer.Data
{
    public class WeatherServices
    {
        private WeatherDbContext dbContext;

        public WeatherServices(WeatherDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// This method returns the list of product
        /// </summary>
        /// <returns></returns>
        public async Task<List<WeatherDay>> GetWeatherAsync()
        {
            return await dbContext.Weather.ToListAsync();
        }

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="weatherDay"></param>
        /// <returns></returns>
        public async Task<WeatherDay> AddWeatherAsync(WeatherDay weatherDay)
        {
            try
            {
                dbContext.Weather.Add(weatherDay);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return weatherDay;
        }

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="weatherDay"></param>
        /// <returns></returns>
        public async Task UpdateWeatherAsync(WeatherDay weatherDay)
        {
            try
            {
                var weatherExist = dbContext.Weather.FirstOrDefault(p => p.WeatherId == weatherDay.WeatherId);
                if (weatherExist != null)
                {
                    dbContext.Update(weatherDay);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="weatherDay"></param>
        /// <returns></returns>
        public async Task DeleteWeatherAsync(WeatherDay weatherDay)
        {
            try
            {
                dbContext.Weather.Remove(weatherDay);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
