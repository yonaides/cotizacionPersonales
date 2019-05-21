using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CotizacionesPersonales.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        
        [Required]
        public string NombreCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string DireccionCliente { get; set; }
        [Required]
        public string EmailCliente { get; set; }
        public ICollection<Cotizacion> Cotizacion { get; set; }

    }
}