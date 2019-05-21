using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using CotizacionesPersonales.Data;
using CotizacionesPersonales.Models;
using System.Linq;

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

        public void OnGet(int? id)
        {
            if (id != null)
            {
                Servicio = _context.Servicio.FirstOrDefault(x => x.ServicioID == id);
            }
        }

        public IActionResult OnPost(int? id)
        {
            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    var servicioInDbo = _context.Servicio.FirstOrDefault(x => x.ServicioID == id);
                    servicioInDbo.NombreServicio = Servicio.NombreServicio;
                    servicioInDbo.PrecioServicio = Servicio.PrecioServicio;
                    servicioInDbo.DescripcionServicio = Servicio.DescripcionServicio;

                    _context.SaveChanges();
                }
                else
                {
                    var servicio = new Servicio
                    {
                        NombreServicio = Servicio.NombreServicio,
                        DescripcionServicio = Servicio.DescripcionServicio,
                        PrecioServicio = Servicio.PrecioServicio

                    };
                    _context.Servicio.Add(servicio);
                    _context.SaveChanges();
                }
            }


            return RedirectToPage("Index");

        }
    }
}