using System.Collections.Generic;
using System;
namespace CotizacionesPersonales.Models
{
    public class Cotizacion
    {
        public int IdCotizacion { get; set; }
        public Cliente IdCliente { get; set; }
        public DateTime FechaCotizacion { get; set; }
        public decimal MontoTotal { get; set; }
        public ICollection<CotizacionDetalle> CotizacionDetalle { get; set; }

    }
}