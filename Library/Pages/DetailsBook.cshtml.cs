using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages
{
    public class DetailsBookModel : PageModel
    {
        public LibraryService libService;
        public DetailsBookModel(LibraryService lS)
        {
            libService = lS;
        }       
        public IActionResult OnGet(string name)
        {
            libService.MyBook = libService.BookList[name];
            return Page();
        }        
    }
}
