using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using CotizacionesPersonales.Data;
using CotizacionesPersonales.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace CotizacionesPersonales.Pages{

   public class AddServicioDetallePageModel : PageModel
    {
        private CotizacionesContext _context;
        public AddServicioDetallePageModel(CotizacionesContext context)
        {
            _context = context;
            servicios = _context.Servicio.Select(a => 
                                  new SelectListItem 
                                  {
                                      Value = a.ServicioID.ToString(),
                                      Text =  a.NombreServicio
                                  }).ToList();

        }

        public List<SelectListItem> servicios { get; set; }

        [BindProperty]
        public string servicioID {get; set;}

        [BindProperty]
        public ServicioDetalle ServicioDetalle { get; set; }
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var servicioDetalle = new ServicioDetalle
            {

                ServicioId = _context.Servicio.FirstOrDefault(x => x.ServicioID == Convert.ToInt32(servicioID) ),
                DescripcionDetalleServicio =  ServicioDetalle.DescripcionDetalleServicio
        
            };

            _context.ServicioDetalle.Add(servicioDetalle);
            _context.SaveChanges();

            return RedirectToPage("Index");

        }

    }


}