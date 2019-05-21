using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CotizacionesPersonales.Models{

public class ServicioDetalle
    {
        public int ServicioDetalleID { get; set; }
        [Required]
        public Servicio ServicioId { get; set; }
        [Required]
        public string DescripcionDetalleServicio { get; set; }
        
    }

}