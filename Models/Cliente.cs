using System.Collections.Generic;

namespace CotizacionesPersonales.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string NombreCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string EmailCliente { get; set; }
        public ICollection<Cotizacion> Cotizacion { get; set; }

    }
}