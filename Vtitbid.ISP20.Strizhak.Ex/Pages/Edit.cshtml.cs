using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vtitbid.ISP20.Strizhak.Ex.Data;
using Vtitbid.ISP20.Strizhak.Ex.Entities;

namespace Vtitbid.ISP20.Strizhak.Ex.Pages
{
    public class EditModel : PageModel
    {
		private readonly AppDbContext _context;
		public EditModel(AppDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Price NewPrice { get; set; }

		public void OnGet(int id)
		{
			NewPrice = _context.Prices.FirstOrDefault(e => e.Id == id);
		}

		public ActionResult OnPost()
		{

			_context.Prices.Update(NewPrice);
			_context.SaveChanges();
			return RedirectToPage("/Price");
		}
	}
}
