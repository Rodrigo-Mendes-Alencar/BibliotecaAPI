using ApiSolo.Model;
using LibraryAPI.Model;

namespace LibraryAPI.structure
{
    public class BookRepositery : IBookRepository
    {

       public readonly ConectionContext _context;
        public BookRepositery(ConectionContext context)
        {
            _context = context;
        }

        public void AddBook(Book book)
        {
            _context.book.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            _context.book.Remove(_context.book.Find(id));
            _context.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.book.ToList();
        }

        public Book GetBookById(int id)
        {
            var book = _context.book.Find(id);
            return book;
        }

        public void UpdateBook(int id, Book book)
        {
            var existingBook = _context.book.Find(id);
            if (existingBook == null) return; // ou lançar exceção

            existingBook.title = book.title;
            existingBook.author = book.author;
            existingBook.isborrowed = book.isborrowed;

            _context.SaveChanges();
        }
    }
}
