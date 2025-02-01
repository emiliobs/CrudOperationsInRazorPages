using CrudOperationsInRazorPages.DAL;
using CrudOperationsInRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudOperationsInRazorPages.Pages.Book
{
    public class CreateModel : PageModel
    {
        private readonly MyDbContext _context;

        public CreateModel(MyDbContext context)
        {
            this._context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Books Books { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Books.Add(Books);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}