using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.Servicios
{
    public class CreateModel : PageModel
    {
        private readonly RostrosFelicesContext _context;
        public CreateModel(RostrosFelicesContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            listClient();
            return Page();
        }
        [BindProperty]

        public Servicio Servicio { get; set; } = default!;

        public SelectList Clientes { get; set; }

        private void listClient()
        {
			var clientes = _context.Clientes.ToList();
			Clientes = new SelectList(clientes, "Id", "Name");
		}
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Servicios == null || Servicio == null)
            {
                listClient();
                return Page();
            }
            _context.Servicios.Add(Servicio);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

