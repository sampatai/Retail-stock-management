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
            Name = Guard.Against.NullOrEmpty(name);
        }
       
        public string Name { get; set; }

        public void SetDetails(string name)
        {
            Name = Guard.Against.NullOrEmpty(name);
        }
    }
}
