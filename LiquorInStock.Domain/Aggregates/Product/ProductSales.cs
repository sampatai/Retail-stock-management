using LiteDB;

namespace Retail.Stock.Domain.Aggregates.Product
{
    public class ProductSales : AuditableEntity, IAggregateRoot
    {
        protected ProductSales() { }

        public ProductSales(int productId,
            int quantity,
            decimal price        
            )
        {
            Id = ObjectId.NewObjectId().Increment;
            ProductId = Guard.Against.NegativeOrZero(productId);
            Price = Guard.Against.NegativeOrZero(price);
            Quantity = Guard.Against.NegativeOrZero(quantity);
            AddedOn = DateTime.Today;
        }

        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        private readonly List<Product> _products = new List<Product>();

        public IReadOnlyCollection<Product> Products => _products;

        public void SetDetail(int productId,
            int quantity,
            decimal price)
        {
            ProductId = Guard.Against.NegativeOrZero(productId);
            Price = Guard.Against.NegativeOrZero(price);
            Quantity = Guard.Against.NegativeOrZero(quantity);
            UpdatedOn = DateTime.Today;
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

    }
}
