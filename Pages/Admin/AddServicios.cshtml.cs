using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using CotizacionesPersonales.Data;
using CotizacionesPersonales.Models;

namespace CotizacionesPersonales.Pages
{
    public class AddServicioPageModel : PageModel
    {
        private CotizacionesContext _context;
        public AddServicioPageModel(CotizacionesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Servicio Servicio { get; set; }
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var servicio = new Servicio
            {
                NombreServicio = Servicio.NombreServicio,
                DescripcionServicio = Servicio.DescripcionServicio,
                PrecioServicio = Servicio.PrecioServicio
                
            };

            _context.Servicio.Add(servicio);
            _context.SaveChanges();

            return RedirectToPage("Index");

        }

    }

}