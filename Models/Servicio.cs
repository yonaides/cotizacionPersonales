using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CotizacionesPersonales.Models{

public class Servicio
    {
        public int ServicioID { get; set; }
        [Required]
        public string NombreServicio { get; set; }
        public string DescripcionServicio { get; set; }
        [Required]
        public decimal PrecioServicio { get; set; }
        public ICollection<ServicioDetalle> ServicioDetalle { get; set; }
    }


}