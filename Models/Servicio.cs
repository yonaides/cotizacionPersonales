using System.Collections.Generic;

namespace CotizacionesPersonales.Models{

public class Servicio
    {
        public int ServicioID { get; set; }
        public string NombreServicio { get; set; }
        public string DescripcionServicio { get; set; }
        public decimal PrecioServicio { get; set; }
        public ICollection<ServicioDetalle> ServicioDetalle { get; set; }
    }


}