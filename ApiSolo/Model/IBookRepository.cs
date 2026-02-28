namespace LibraryAPI.Model
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetAllBooks();

        public Book GetBookById(int id);
    
            public void AddBook(Book book);
    
            public void UpdateBook(Book book);
    
            public void DeleteBook(int id);
    }
}
