using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace CotizacionesPersonales.Models
{
    public class CotizacionDetalle
    {
        public int CotizacionDetalleID { get; set; }

        [Required]
        public Cotizacion CotizacionId { get; set; }

        [Required]
        public Servicio ServicioId { get; set; }

        [Required]
        public DateTime FechaCotizacion { get; set; }

        [Required]
        public decimal precioServicio { get; set; }

    }
}