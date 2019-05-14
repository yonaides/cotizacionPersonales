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

    }
}