using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vtitbid.ISP20.Strizhak.Ex.Data;
using Vtitbid.ISP20.Strizhak.Ex.Entities;

namespace Vtitbid.ISP20.Strizhak.Ex.Pages
{
    public class PriceModel : PageModel
    {
		private readonly AppDbContext _context;
		public PriceModel(AppDbContext context)
		{
			_context = context;
		}

		public List<Price> Prices { get; set; }

		[BindProperty]
		public Price NewPrice { get; set; }

		public void OnGet()
		{
			Prices = _context.Prices.ToList();
		}

		public IActionResult OnPost()
		{
			_context.Prices.Add(NewPrice);
			_context.SaveChanges();
			return RedirectToPage("/Price");
		}
	}
}

