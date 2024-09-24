using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages
{
    public class AddBookModel : PageModel
    {
        public LibraryService libService;
        public AddBookModel(LibraryService ls) 
        {
            libService = ls;
        }
        public void OnGet(){}
        public void qAddBook(string name, string author, string style, string year)
        {
            libService.AddBook(name, author, style, year);
        }
    }
}
