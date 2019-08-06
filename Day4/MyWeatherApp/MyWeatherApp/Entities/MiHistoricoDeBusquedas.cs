using System;
using SQLite;

namespace MyWeatherApp.Entities
{
    public class MiHistoricoDeBusquedas
    {
        public string TextoBusqueda { get; set; }
        public DateTime FechaDeBusqueda { get; set; }
    }
}
