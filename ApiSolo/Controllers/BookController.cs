using ApiSolo.Model;
using LibraryAPI.Model;
using LibraryAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/v1/books")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpPost]
        public IActionResult add(ViewModelBook bookView)
        {
            var book = new Book(bookView.title, bookView.author, bookView.isborrowed);
            _bookRepository.AddBook(book);
            return Ok();
        }
        [HttpGet()]
        public IActionResult getAll()
        {
            var books = _bookRepository.GetAllBooks();
            return Ok(books);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _bookRepository.GetBookById(id);
            return Ok(book);
        }
        [HttpPut("{id}")]
        public IActionResult PutInBook(int id, [FromBody] Book book)
        {
            _bookRepository.UpdateBook(id,book);
            return Ok();
        }
    }
}
