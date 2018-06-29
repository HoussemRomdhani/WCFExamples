using System.Collections.Generic;
using System.ServiceModel;

namespace wcfExamples.Contracts
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        BookData GetById(int id);

        [OperationContract]
        IEnumerable<BookData> GetAll();

        [OperationContract]
        void Add(BookData book);

        [OperationContract]
        void Update(BookData book);

        [OperationContract]
        void Delete(int id);
    }
}
