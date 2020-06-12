using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProvaBlazor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<WeatherForecast> Previsioni { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Metereologo> Metereologi { get; set; }
        public DbSet<Presentatore> Presentatori { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<City>().HasData(
                new City(1,"Cesena"),
                new City(2, "Bologna")
                );

            var meteorologo = new Metereologo { Id = 1, Name = "Carlo", Surname = "Nuvolari", Competenza="Venti" };
            var presentatore = new Presentatore { Id = 2, Name = "Simone", Surname = "Mastri", Lingua="Italiano" };

            builder.Entity<Metereologo>().HasData(meteorologo);
            builder.Entity<Presentatore>().HasData(presentatore);

            builder.Entity<WeatherForecast>().HasData(
                new WeatherForecast
                {
                    Id = 1,
                    Date = DateTime.Now.AddDays(-4),
                    TemperatureC = 24,
                    Summary = "Sunny",
                    CityId=1,
                    MeteorologoId = meteorologo.Id,
                    PresentatoreId = presentatore.Id
                },
                new WeatherForecast
                {
                    Id = 2,
                    Date = DateTime.Now.AddDays(-8),
                    TemperatureC = 14,
                    Summary = "Cloudly",
                    CityId = 1,
                    MeteorologoId = meteorologo.Id,
                    PresentatoreId = presentatore.Id
                },
                new WeatherForecast
                {
                    Id = 3,
                    Date = DateTime.Now.AddDays(-2),
                    TemperatureC = 32,
                    Summary = "Sunny",
                    CityId = 1,
                    MeteorologoId = meteorologo.Id,
                    PresentatoreId = presentatore.Id
                },
                new WeatherForecast
                {
                    Id = 4,
                    Date = DateTime.Now,
                    TemperatureC = 22,
                    Summary = "Partialy cloud",
                    CityId = 1,
                    MeteorologoId = meteorologo.Id,
                    PresentatoreId = presentatore.Id
                },
                new WeatherForecast
                {
                    Id = 5,
                    Date = DateTime.Now.AddDays(-10),
                    TemperatureC = 19,
                    Summary = "Sunny",
                    CityId = 2,
                    MeteorologoId = meteorologo.Id,
                    PresentatoreId = presentatore.Id
                }
                );
            
        }
    }
}
