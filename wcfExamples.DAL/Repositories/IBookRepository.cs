using System.Collections.Generic;
using wcfExamples.DAL.Entities;

namespace wcfExamples.DAL.Repositories
{
    public interface IBookRepository
    {
        Book GetById(int id);
        IEnumerable<Book> GetAll();
        void Add(Book book);
        void Update(Book book);
        void Delete(int id);
    }
}
