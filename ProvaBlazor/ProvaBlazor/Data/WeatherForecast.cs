using System;
using System.ComponentModel.DataAnnotations;

namespace ProvaBlazor.Data
{
    public class WeatherForecast
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [Range(-40, 65)]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Required]
        public string Summary { get; set; }

        [Required]
        public int CityId { get; set; }
        public City City { get; set; }

        public WeatherForecast()
        {

        }
    }
}
