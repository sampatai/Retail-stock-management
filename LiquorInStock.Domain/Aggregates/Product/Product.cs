using Ardalis.GuardClauses;
using LiteDB;
using System.Diagnostics;

namespace Retail.Stock.Domain.Aggregates.Product
{
    public class Product : AuditableEntity, IAggregateRoot
    {
        protected Product() { }

        public Product(int categoryId, string productName,int stockIn,decimal purchasedPrice, decimal retailPrice)
        {
            Id = ObjectId.NewObjectId().Increment;
            CategoryId = Guard.Against.NegativeOrZero(categoryId);
            ProductName = Guard.Against.NullOrEmpty(productName);
            AddedOn = DateTime.Today;
            StockIn = stockIn;
            PurchasedPrice = purchasedPrice;
            RetailPrice = retailPrice;

        }

        public int CategoryId { get; private set; }
        public string ProductName { get; private set; }
        public int StockIn { get; private set; }
        public decimal? PurchasedPrice { get; private set; }
        public decimal RetailPrice { get; private set; }


        public void SetProduct(
            int categoryId,
            string productName,
            int stockIn, decimal purchasedPrice, decimal retailPrice
            )
        {
            CategoryId = Guard.Against.NegativeOrZero(categoryId);
            ProductName = productName;
            UpdatedOn = DateTime.Today;
            StockIn = stockIn;
            PurchasedPrice = purchasedPrice;
            RetailPrice = retailPrice;
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
        public void SetStockOut(int quantity)
        {
            StockIn -= quantity;
        }
    }
}
