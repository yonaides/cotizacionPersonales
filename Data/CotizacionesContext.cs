using CotizacionesPersonales.Models;
using Microsoft.EntityFrameworkCore;

namespace CotizacionesPersonales.Data
{
    public class CotizacionesContext : DbContext
    {
        public CotizacionesContext(DbContextOptions<CotizacionesContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cotizacion> Cotizacion { get; set; }

        public DbSet<CotizacionDetalle> CotizacionDetalle { get; set; }

        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<ServicioDetalle> ServicioDetalle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
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