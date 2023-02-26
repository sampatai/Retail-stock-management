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
            decimal sellingPrice,
            decimal totalPrice
            )
        {
            Id = ObjectId.NewObjectId().Increment;
            ProductId = Guard.Against.NegativeOrZero(productId);
            Price = Guard.Against.NegativeOrZero(price);
            SellingPrice = Guard.Against.NegativeOrZero(sellingPrice);
            Quantity = Guard.Against.NegativeOrZero(quantity);
            AddedOn = DateTime.Today;
            TotalPrice = Guard.Against.NegativeOrZero(totalPrice);
        }

        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public decimal TotalPrice { get; set; }
        public decimal SellingPrice { get; private set; }
        private readonly List<Product> _products = new List<Product>();

        public IReadOnlyCollection<Product> Products => _products;

        public void SetDetail(int productId,
            int quantity,
            decimal price,
            decimal pricePerQuantity,
           decimal totalPrice)
        {
            ProductId = Guard.Against.NegativeOrZero(productId);
            Price = Guard.Against.NegativeOrZero(price);
            SellingPrice = Guard.Against.NegativeOrZero(pricePerQuantity);
            Quantity = Guard.Against.NegativeOrZero(quantity);
            UpdatedOn = DateTime.Today;
            TotalPrice = Guard.Against.NegativeOrZero(totalPrice);
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

    }
}
