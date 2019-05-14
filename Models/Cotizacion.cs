using System.Collections.Generic;
using System;
namespace CotizacionesPersonales.Models
{
    public class Cotizacion
    {
        public int CotizacionID { get; set; }
        public Cliente ClienteId { get; set; }
        public DateTime FechaCotizacion { get; set; }
        public decimal MontoTotal { get; set; }
        public ICollection<CotizacionDetalle> CotizacionDetalle { get; set; }

    }
}