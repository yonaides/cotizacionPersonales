using System.Collections.Generic;

namespace CotizacionesPersonales.Models{

public class ServicioDetalle
    {
        public int IdServicioDetalle { get; set; }
        public Servicio IdServicio { get; set; }
        public string DescripcionDetalleServicio { get; set; }
        
    }

}