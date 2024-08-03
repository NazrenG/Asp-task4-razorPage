using Asp_Razor_Page.Data;
using Asp_Razor_Page.Entities;
using Asp_Razor_Page.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Asp_Razor_Page.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _service;

        public IndexModel(IProductService service)
        {
            _service = service;
        }

        public IList<Product> Products { get; set; }

        [BindProperty]
        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Products = await _service.GetProductsAsync();

            if (id.HasValue)
            {
                Product = await _service.GetProductByIdAsync(id.Value);
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Product.Id == 0)
            {
                await _service.Create(Product);
            }
            else
            {
                await _service.Update(Product);
            }

            return RedirectToPage();
        }

        public IActionResult OnPostDelete(Product product)
		{
			_service?.Delete(product);
			return RedirectToAction("Index");	
		}
	}
}
