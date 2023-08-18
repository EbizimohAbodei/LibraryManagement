using WebApi.Domain.src.Entities;

namespace WebApi.Business.src.Services.Abstractions.RepoAbstractions
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(Guid Id);
        Task<Book> UpdateBook(Guid Id, Book book);
        Task<Book> DeleteBook(Guid Id);
        Task<Book> AddBook(Book book);
        Task<Book> LoanBook(Guid UserId, List<Guid> BooksId);
        Task<Book> ReturnLoanedBooks(Guid UserId, Guid LoanId);
        Task<Book> AddReview(Review review);
    }
}