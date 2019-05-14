using Microsoft.EntityFrameworkCore;

public class CotizacionesContext : DbContext{

    public CotizacionesContext(DbContextOptions<CotizacionesContext> options) : base(options) {


    }
}