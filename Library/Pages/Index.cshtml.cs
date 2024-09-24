using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages
{
    public class IndexModel : PageModel
    {
        public LibraryService libService;
        public IndexModel(LibraryService lS)
        {
            libService = lS;
        }
        public void OnGet(){}
        public IActionResult qDelBook(string name)
        {
            libService.DelBook(name);
            return Page();
        }
        public void OnPostEditBook(string name)
        {
            libService.MyBook = libService.BookList[name];   
        }
        public IActionResult qSearchBook(string search, string select)
        {
            if (search == null)
            {
                AllSearch();
                return Page();
            } 
            libService.SearchList.Clear();
            foreach (var book in libService.BookList)
            {
                switch (select)
                {
                    case "Name": if (book.Value.Name.Contains(search)) libService.SearchBook(book.Value.Name, book.Value); break;
                    case "Author": if (book.Value.Author.Contains(search)) libService.SearchBook(book.Value.Name, book.Value); break;
                    case "Style": if (book.Value.Style.Contains(search)) libService.SearchBook(book.Value.Name, book.Value); break;
                    case "Year": if (book.Value.Year.Contains(search)) libService.SearchBook(book.Value.Name, book.Value); break;
                    default: AllSearch(); break;
                }
            }
            return Page();
        }
        public void AllSearch()
        {
            libService.SearchList.Clear();
            foreach (var book in libService.BookList)            
                libService.SearchBook(book.Value.Name, book.Value);            
        }
    }
}
