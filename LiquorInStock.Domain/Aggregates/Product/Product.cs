using Ardalis.GuardClauses;
using LiteDB;
using System.Diagnostics;

namespace Retail.Stock.Domain.Aggregates.Product
{
    public class Product : AuditableEntity, IAggregateRoot
    {
        protected Product() { }

        public Product(int categoryId, string productName)
        {
            Id = ObjectId.NewObjectId().Increment;
            CategoryId = Guard.Against.NegativeOrZero(categoryId);
            ProductName = Guard.Against.NullOrEmpty(productName);
            AddedOn = DateTime.Today;

        }

        public int CategoryId { get; private set; }
        public string ProductName { get; private set; }
        public int StockIn { get; private set; }
        public decimal? PurchasedPrice { get; private set; }
        public decimal RetailPrice { get; private set; }


        public void SetProduct(
            int categoryId,
            string productName
            )
        {
            CategoryId = Guard.Against.NegativeOrZero(categoryId);
            ProductName = productName;
            UpdatedOn = DateTime.Today;
        }

        public void SetPurchasedPrice(decimal price)
        {
            PurchasedPrice = price;
        }
        public void SetRetailPrice(decimal price)
        {
            RetailPrice = price;
        }
        public void SetStockIn(int quantity)
        {
            StockIn += quantity;
        }
        public void SetRemainingQuantity(int quantity)
        {
            StockIn = quantity;
        }
    }
}
