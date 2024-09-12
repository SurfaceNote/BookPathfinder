namespace BookPathfinder.API.Services
{
    using BookPathfinder.API.Models;
    using BookPathfinder.API.Repositories.Interfaces;
    using BookPathfinder.API.Services.Interface;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task CreateBookAsync(Book book)
        {
            await _bookRepository.CreateBookAsync(book);
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if (book == null)
            {
                return false;
            }

            await _bookRepository.DeleteBookAsync(book);
            return true;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _bookRepository.GetAllBooksAsync();
        }

        public async Task<Book> GetBookIdAsync(int id)
        {
            return await _bookRepository.GetBookByIdAsync(id);
        }

        public async Task<bool> UpdateBookAsync(int id, Book book)
        {
            var existingBook = await _bookRepository.GetBookByIdAsync(id);
            if (existingBook == null)
            {
                return false;
            }

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Genre = book.Genre;
            existingBook.Status = book.Status;

            await _bookRepository.UpdateBookAsync(existingBook);
            return true;
        }
    }
}
