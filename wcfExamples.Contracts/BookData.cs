using System.Runtime.Serialization;

namespace wcfExamples.Contracts
{
    [DataContract]
    public class BookData
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Author { get; set; }

        [DataMember]
        public decimal Pricec { get; set; }
    }
}
