using WebApi.Business.src.Dto;
using WebApi.Domain.src.Entities;

namespace WebApi.Business.src.Services.Abstractions.ServiceAbractions
{
    public interface IBookService
    {
      Task<BookDto> AddBook(BookDto book);
      Task<BookDto> GetBookById(Guid id);
      Task<BookDto> UpdateBook(Guid id, Book book);
      Task<BookDto> DeleteBook(Guid id);
      Task<IEnumerable<BookDto>> GetAllBooks();
    }
}