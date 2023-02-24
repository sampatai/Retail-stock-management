using Ardalis.GuardClauses;
using LiteDB;
using System.Diagnostics;

namespace Retail.Stock.Domain.Aggregates.Product
{
    public class ProductPrice : AuditableEntity
    {
        protected ProductPrice() { }

        public ProductPrice(int productId,
            int quantity,
            decimal price,
            decimal pricePerQuantity
            )
        {
            Id = ObjectId.NewObjectId();
            GUID = Guid.NewGuid();
            ProductId = Guard.Against.NegativeOrZero(productId);
            Price = Guard.Against.NegativeOrZero(price);
            PricePerQuantity = Guard.Against.NegativeOrZero(pricePerQuantity);
            Quantity = Guard.Against.NegativeOrZero(quantity);
        }

        public Guid GUID { get; private set; }
        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public int? BoxOrPacketQuantity { get; private set; }
        public decimal Price { get; private set; }
        public decimal? BoxOrPacketSellingPrice { get; private set; }
        public decimal PricePerQuantity { get; private set; }

        public int? PerBoxOrPacketQuantity { get; set; }

        public void SetDetail(int productId,
            int quantity,
            decimal price,
            decimal pricePerQuantity)
        {
            ProductId = Guard.Against.NegativeOrZero(productId);
            Price = Guard.Against.NegativeOrZero(price);
            PricePerQuantity = Guard.Against.NegativeOrZero(pricePerQuantity);
            Quantity = Guard.Against.NegativeOrZero(quantity);

        }
        public void SetBoxOrPacketQuantity(int quantity)
        {
            BoxOrPacketQuantity = Guard.Against.NegativeOrZero(quantity);
        }

        public void SetBoxOrPacketSellingPrice(decimal price)
        {
            BoxOrPacketSellingPrice = Guard.Against.NegativeOrZero(price);
        }

        public void SetPerBoxOrPacketQuantity(int quantity)
        {
            PerBoxOrPacketQuantity = Guard.Against.NegativeOrZero(quantity);
        }

        public void TotalQuantity()
        {
            Quantity = BoxOrPacketQuantity.Value * PerBoxOrPacketQuantity.Value;
        }
    }
}
