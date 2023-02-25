using Ardalis.GuardClauses;
using LiteDB;
using System.Diagnostics;

namespace Retail.Stock.Domain.Aggregates.Product
{
    public class ProductPrice : AuditableEntity, IAggregateRoot
    {
        protected ProductPrice() { }

        public ProductPrice(int productId,
            int quantity,
            decimal price,
            decimal pricePerQuantity
            )
        {
            Id = ObjectId.NewObjectId().Increment;
            ProductId = Guard.Against.NegativeOrZero(productId);
            Price = Guard.Against.NegativeOrZero(price);
            SellingPrice = Guard.Against.NegativeOrZero(pricePerQuantity);
            Quantity = Guard.Against.NegativeOrZero(quantity);
            AddedOn=DateTime.UtcNow;
        }

        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public decimal SellingPrice { get; private set; }
        private List<Product> _products;
        public IReadOnlyCollection<Product> Products => _products.AsReadOnly();
        public void SetDetail(int productId,
            int quantity,
            decimal price,
            decimal pricePerQuantity)
        {
            ProductId = Guard.Against.NegativeOrZero(productId);
            Price = Guard.Against.NegativeOrZero(price);
            SellingPrice = Guard.Against.NegativeOrZero(pricePerQuantity);
            Quantity = Guard.Against.NegativeOrZero(quantity);
            UpdatedOn= DateTime.UtcNow;
        }

    }
}
