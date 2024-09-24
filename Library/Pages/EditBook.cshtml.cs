using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages
{
    public class EditBookModel : PageModel
    {
        public LibraryService LibService;
        public EditBookModel(LibraryService lS)
        {
            LibService = lS;
        }
        public IActionResult OnGet(string name)
        {
            LibService.MyBook = LibService.BookList[name];
            return Page();
        }

        public IActionResult qEditBook(string name, string author, string style, string year)
        { 
            LibService.DelBook(LibService.MyBook.Name);
            LibService.AddBook(name, author, style, year);
            LibService.MyBook = LibService.BookList[name];
            return Page();
        }
    }
}
