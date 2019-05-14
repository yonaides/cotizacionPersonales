using System.Collections.Generic;

namespace CotizacionesPersonales.Models{

public class ServicioDetalle
    {
        public int ServicioDetalleID { get; set; }
        public Servicio ServicioId { get; set; }
        public string DescripcionDetalleServicio { get; set; }
        
    }

}