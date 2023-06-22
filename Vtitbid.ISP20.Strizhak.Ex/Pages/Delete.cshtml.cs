using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vtitbid.ISP20.Strizhak.Ex.Data;
using Vtitbid.ISP20.Strizhak.Ex.Entities;

namespace Vtitbid.ISP20.Strizhak.Ex.Pages
{
    public class DeleteModel : PageModel
    {
		private readonly AppDbContext _context;
		public DeleteModel(AppDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Price DeletePrice { get; set; }


		public IActionResult OnGet(int id)
		{
			DeletePrice = _context.Prices.FirstOrDefault(e => e.Id == id);

			if (DeletePrice == null)
			{
				return NotFound();
			}

			return Page();
		}

		public async Task<IActionResult> OnPost(int id)
		{
			var price = await _context.Prices.FindAsync(id);

			if (price != null)
			{
				_context.Prices.Remove(price);
				await _context.SaveChangesAsync();
			}

			return RedirectToPage("/Price");
		}
	}
}
