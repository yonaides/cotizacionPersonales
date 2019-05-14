using CotizacionesPersonales.Models;
using Microsoft.EntityFrameworkCore;

namespace CotizacionesPersonales.Data
{
    public class CotizacionesContext : DbContext
    {
        public CotizacionesContext(DbContextOptions<CotizacionesContext> options) : base(options)
        {
        }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Cotizacion> cotizacion { get; set; }

public DbSet<CotizacionDetalle> cotizacionDetalle { get; set; }

public DbSet<Servicio> servicio { get; set; }
public DbSet<ServicioDetalle> servicioDetalle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<Cliente>().HasData(
                    new Cliente{
                        ClienteID = 1,
                        NombreCliente = "Yonaides Tavares",
                        TelefonoCliente = "829-883-6835",
                        DireccionCliente = "Santiago de los Caballeros",
                        EmailCliente = "yonaides@gmail.com"
                    }
                );

        }
    }
}