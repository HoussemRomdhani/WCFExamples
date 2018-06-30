using System.Collections.Generic;
using wcfExamples.DAL.Entities;
using System.Linq;

namespace wcfExamples.DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books;
        public BookRepository()
        {
            books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title ="Book 1",
                    Description = "Description 1",
                    Author = "Author 1",
                    Price =20
                },
                new Book
                {
                    Id = 2,
                    Title ="Book 2",
                    Description = "Description 2",
                    Author = "Author 2",
                    Price =30
                },
                new Book
                {
                    Id = 3,
                    Title ="Book 3",
                    Description = "Description 3",
                    Author = "Author 3",
                    Price =30
                }
            };
        }
        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Delete(int id)
        {
            var book = books.Where(b => b.Id == id).FirstOrDefault();
            if (book != null)
                books.Remove(book);
        }

        public IEnumerable<Book> GetAll()
        {
            return books;
        }

        public Book GetById(int id)
        {
            return books.Where(b => b.Id == id).FirstOrDefault();
        }

        public void Update(Book book)
        {
           //implement later 
        }
    }
}
