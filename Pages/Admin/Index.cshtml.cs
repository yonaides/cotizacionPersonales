using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CotizacionesPersonales.Data;
using CotizacionesPersonales.Models;

namespace CotizacionesPersonales.Pages
{

public class IndexModel : PageModel{
    public IEnumerable<Cliente> Clientes {get; set;}

        private readonly CotizacionesContext _context;

        public IndexModel(CotizacionesContext context ){
            _context = context;
        }

        public void OnGet(){
            Clientes = _context.Clientes.ToList();
        }

    }
}

