using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaBlazor.Data
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<WeatherForecast> Previsioni { get; set; }

        public City()
        {

        }

        public City(int id, string name, string descr)
        {
            Id = id;
            Name = name;
            Description = descr;
        }
    }
}
