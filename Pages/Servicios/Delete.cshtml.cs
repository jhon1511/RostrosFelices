using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.Servicios
{
    public class DeleteModel : PageModel
    {
		private readonly RostrosFelicesContext _context;

		public DeleteModel(RostrosFelicesContext context)
		{
			_context = context;
		}

		[BindProperty]

		public Servicio Servicio { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Servicios == null)
			{
				return NotFound();
			}

			var servicio = await _context.Servicios.FirstOrDefaultAsync(m => m.Id == id);

			if (servicio != null)
			{
				Servicio = servicio;
				_context.Servicios.Remove(servicio);
				await _context.SaveChangesAsync();
			}
			else
			{
				Servicio = servicio;
			}
			return RedirectToPage("./Index");
		}
	}
}
