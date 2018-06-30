using System.Collections.Generic;

namespace wcfExamples.DAL.Repositories
{
    public interface IBookRepository
    {
        BookData GetById(int id);
        IEnumerable<Book> GetAll();
        void Add(BookData book);
        void Update(BookData book);
        void Delete(int id);
    }
}
