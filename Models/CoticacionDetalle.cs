using System.Collections.Generic;
using System;

namespace CotizacionesPersonales.Models
{
    public class CotizacionDetalle
    {
        public int CotizacionDetalleID { get; set; }

        public Cliente IdCliente { get; set; }

        public Servicio IdServicio { get; set; }

        public DateTime FechaCotizacion { get; set; }
        public decimal precioServicio { get; set; }

    }
}