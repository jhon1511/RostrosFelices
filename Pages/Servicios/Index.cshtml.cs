using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.Servicios
{
    public class IndexModel : PageModel
    {
		private readonly RostrosFelicesContext _context;

		public IndexModel(RostrosFelicesContext context)
		{
			_context = context;
		}

		public IList<Servicio> Servicios { get; set; } = default!;

		public async Task OnGetAsync()
		{
			if (_context.Clientes != null)
			{
				Servicios = await _context.Servicios.ToListAsync();
			}
		}
	}
}