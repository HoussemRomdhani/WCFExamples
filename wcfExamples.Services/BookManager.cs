using System.Collections.Generic;
using System.Linq;
using wcfExamples.Contracts;
using wcfExamples.DAL.Entities;
using wcfExamples.DAL.Repositories;

namespace wcfExamples.Services
{
    public class BookManager : IBookService
    {
        private readonly IBookRepository bookRepository;
        public BookManager()
        {
            bookRepository = new BookRepository();
        }

        public IEnumerable<BookData> GetAll()
        {
            var books = bookRepository.GetAll();
            return books.Select(book => new BookData {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Price = book.Price
            });
        }


        public BookData GetById(int id)
        {
            var book = bookRepository.GetById(id);
            return new BookData
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Price = book.Price
            };
        }

        public void Add(BookData bookData)
        {
            var book = new Book
            {
                Id = bookData.Id,
                Title = bookData.Title,
                Description = bookData.Description,
                Author = bookData.Author,
                Price = bookData.Price
            };

            bookRepository.Add(book);
        }

        public void Delete(int id)
        {
            bookRepository.Delete(id);
        }

        public void Update(BookData book)
        {
           // throw new System.NotImplementedException();
        }
    }
}
