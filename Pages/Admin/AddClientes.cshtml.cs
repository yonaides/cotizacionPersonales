using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using CotizacionesPersonales.Data;
using CotizacionesPersonales.Models;
using System.Linq;

namespace CotizacionesPersonales.Pages
{
    public class AddClientePageModel : PageModel
    {
        private CotizacionesContext _context;
        public AddClientePageModel(CotizacionesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cliente Cliente { get; set; }

        public void OnGet(int? id)
        {
            if (id != null)
            {
                Cliente = _context.Clientes.FirstOrDefault(x => x.ClienteID == id);
            }
        }

        public IActionResult OnPost(int? id)
        {

            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    var clienteInDBA = _context.Clientes.FirstOrDefault(x => x.ClienteID == id);
                    clienteInDBA.NombreCliente = Cliente.NombreCliente;
                    clienteInDBA.DireccionCliente = Cliente.DireccionCliente;
                    clienteInDBA.TelefonoCliente = Cliente.TelefonoCliente;
                    clienteInDBA.EmailCliente = Cliente.EmailCliente;
                    _context.SaveChanges();


                }
                else
                {
                    var cliente = new Cliente
                    {
                        NombreCliente = Cliente.NombreCliente,
                        TelefonoCliente = Cliente.TelefonoCliente,
                        DireccionCliente = Cliente.DireccionCliente,
                        EmailCliente = Cliente.EmailCliente

                    };

                    _context.Clientes.Add(cliente);
                    _context.SaveChanges();

                }
            }

            return RedirectToPage("Index");

        }

    }

}