using LiteDB;

namespace Retail.Stock.Domain.Aggregates.Category
{
    public class Category : AuditableEntity, IAggregateRoot
    {
        protected Category()
        {

        }
        public Category(string name)
        {
            Id = ObjectId.NewObjectId();
            GUID = Guid.NewGuid();
            Name = Guard.Against.NullOrEmpty(name);
        }
        public Guid GUID { get; set; }
        public string Name { get; set; }

        public void SetDetails(string name)
        {
            Name = Guard.Against.NullOrEmpty(name);
        }
    }
}
