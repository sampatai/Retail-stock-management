using LiteDB;

namespace Retail.Stock.Domain.Aggregates.Category
{
    public class Category : AuditableEntity, IAggregateRoot
    {
        protected Category()
        {

        }
        public Category(string categoryName)
        {
            Id = ObjectId.NewObjectId().Increment;
            CategoryName = Guard.Against.NullOrEmpty(categoryName);
            AddedOn = DateTime.UtcNow;
        }
        public Category(string categoryName, int id)
        {
            Id = id;
            CategoryName = Guard.Against.NullOrEmpty(categoryName);
            UpdatedOn = DateTime.UtcNow;
        }
        public string CategoryName { get; set; }

        public void SetDetails(string name)
        {
            CategoryName = Guard.Against.NullOrEmpty(name);
        }
    }
}
