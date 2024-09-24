namespace Library.Models
{
    public class LibraryService
    {
        public Book MyBook; 

        static readonly Book book1 = new Book("A Tale of Two Cities", "Charles Dickens", "Historical fiction",  "1859");
        static readonly Book book2 = new Book("The Little Prince", "Antoine de Saint-Exupéry", "Fantasy, children's fiction",  "1943");
        static readonly Book book3 = new Book("The Hobbit", "J. R. R. Tolkien", "Fantasy, children's fiction",  "1937");
        static readonly Book book4 = new Book("Harry Potter and the Philosopher's Stone", "J. K. Rowling", "Fantasy, children's fiction", "1997");
        static readonly Book book5 = new Book("Lolita", "Vladimir Nabokov", "Novel", "1955");
        static readonly Book book6 = new Book("The Ginger Man", "J. P. Donleavy", "Novel", "1955");
        static readonly Book book7 = new Book("Heidi", "Johanna Spyri", "children's fiction", "1880");

        public readonly IDictionary<string, Book> BookList = new Dictionary<string, Book>
        {
            { book1.Name, book1},
            { book2.Name, book2},
            { book3.Name, book3},
            { book4.Name, book4},
            { book5.Name, book5},
            { book6.Name, book6},
            { book7.Name, book7},
        };


        public readonly IDictionary<string, Book> SearchList = new Dictionary<string, Book>
        {
            { book1.Name, book1},
            { book2.Name, book2},
            { book3.Name, book3},
            { book4.Name, book4},
            { book5.Name, book5},
            { book6.Name, book6},
            { book7.Name, book7},
        };

        public void AddBook(string name, string author, string style, string year)
        {
            Book book = new Book
                (
                name, 
                author, 
                style,  
                year)
                ;
            BookList.Add(name, book);
            SearchBook(book.Name, book);
        }
        public void SearchBook(string name, Book book)
        {
            SearchList.Add(name, book);
        }
        public void DelBook(string name)
        {
            BookList.Remove(name);
            SearchList.Remove(name);
        }
    }
}
