using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using CotizacionesPersonales.Data;
using CotizacionesPersonales.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace CotizacionesPersonales.Pages
{
    public class AddServicioDetallePageModel : PageModel
    {
        private CotizacionesContext _context;

        public AddServicioDetallePageModel(CotizacionesContext context)
        {
            _context = context;
        }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                ServicioDetalle = _context.ServicioDetalle.Include(a => a.ServicioId).FirstOrDefault(x => x.ServicioDetalleID == id);
                servicioID = ServicioDetalle.ServicioId.ServicioID.ToString();
                Servicios = _context.Servicio.Where(x => x.ServicioID == ServicioDetalle.ServicioId.ServicioID).
                                                Select(a =>
                                                  new SelectListItem
                                                  {
                                                      Value = a.ServicioID.ToString(),
                                                      Text = a.NombreServicio
                                                  })
                                                  .ToList();

            }
            else
            {
                Servicios = _context.Servicio.Select(a =>
                                                  new SelectListItem
                                                  {
                                                      Value = a.ServicioID.ToString(),
                                                      Text = a.NombreServicio
                                                  }).ToList();

            }

        }

        public List<SelectListItem> Servicios { get; set; }

        [BindProperty]
        public string servicioID { get; set; }
        [BindProperty]
        public ServicioDetalle ServicioDetalle { get; set; }

        public IActionResult OnPost(int? id)
        {
            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    var servicioDetalleDb = _context.ServicioDetalle.Include(a => a.ServicioId).FirstOrDefault(x => x.ServicioDetalleID == id);
                    servicioDetalleDb.DescripcionDetalleServicio = ServicioDetalle.DescripcionDetalleServicio;
                    _context.SaveChanges();
                }
                else
                {
                    var servicioDetalle = new ServicioDetalle
                    {

                        ServicioId = _context.Servicio.FirstOrDefault(x => x.ServicioID == Convert.ToInt32(servicioID)),
                        DescripcionDetalleServicio = ServicioDetalle.DescripcionDetalleServicio

                    };
                    _context.ServicioDetalle.Add(servicioDetalle);
                    _context.SaveChanges();
                }
            }

            return RedirectToPage("Index");

        }
    }
}