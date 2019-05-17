using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using CotizacionesPersonales.Data;
using CotizacionesPersonales.Models;

namespace CotizacionesPersonales.Pages
{
    public class AddPageModel : PageModel
    {
        private CotizacionesContext _context;
        public AddPageModel(CotizacionesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AddItemModel AIM { get; set; }
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var cliente = new Cliente
            {
                NombreCliente = AIM.NombreCliente,
                DireccionCliente = AIM.DireccionCliente,
                TelefonoCliente = AIM.TelefonoCliente,
                EmailCliente = AIM.EmailCliente
            };

            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return RedirectToPage("Index");

        }

    }

}