using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using CotizacionesPersonales.Data;
using CotizacionesPersonales.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace CotizacionesPersonales.Pages
{

    public class ViewServicioDetallePageModel : PageModel
    {

        private CotizacionesContext _context;

        public ViewServicioDetallePageModel(CotizacionesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Servicio Servicio { get; set; }

        public IEnumerable<ServicioDetalle> ServicioDetalle { get; set; }

        public void OnGet(int? id)
        {
            if (id != null)
            {
                Servicio = _context.Servicio.FirstOrDefault(x => x.ServicioID == id);
                ServicioDetalle = _context.ServicioDetalle.Where(x => x.ServicioId.ServicioID == id);
            }
        }

    }

}