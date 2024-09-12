namespace BookPathfinder.API.Services.Interface
{
    using BookPathfinder.API.Models;
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<Book> GetBookIdAsync(int id);
        Task CreateBookAsync(Book book);
        Task<bool> UpdateBookAsync(int id, Book book);
        Task<bool> DeleteBookAsync(int id);
    }
}
