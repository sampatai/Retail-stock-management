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
            AddedOn = DateTime.Today;
        }
        
        public string CategoryName { get; set; }

        public void SetDetails(string name)
        {
            CategoryName = Guard.Against.NullOrEmpty(name);
            UpdatedOn = DateTime.Today;
        }
    }
}
