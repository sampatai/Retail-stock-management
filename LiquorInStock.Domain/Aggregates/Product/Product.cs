using LiteDB;
using System.Diagnostics;

namespace Retail.Stock.Domain.Aggregates.Product
{
    public class Product : AuditableEntity, IAggregateRoot
    {
        protected Product() { }

        public Product(int categoryId, string name)
        {
            Id = ObjectId.NewObjectId();
            GUID = Guid.NewGuid();
            CategoryId = Guard.Against.NegativeOrZero(categoryId);
            Name = name;

        }

        public Guid GUID { get; private set; }
        public int CategoryId { get; private set; }
        public string Name { get; private set; }
        public int StockIn { get; private set; }
        public int? StockInBoxOrPacket { get; private set; }
        public decimal RetailPrice { get; private set; }
        public decimal BoxOrPacketSellingPrice { get; private set; }

        private List<ProductPrice> _ProductPrice;
        public IReadOnlyCollection<ProductPrice> ProductPrice => _ProductPrice.AsReadOnly();


        public void AddProductPrice(
            int quantity,
            decimal price,
            decimal pricePerQuantity,
            int? boxOrPacketQuantity = null,
            decimal? boxOrPacketSellingPrice = null)
        {
            ProductPrice productPrices = new(this.Id.Increment, quantity, price, pricePerQuantity);
            if (boxOrPacketQuantity is not null)
            {
                productPrices.SetBoxOrPacketQuantity(boxOrPacketQuantity.Value);
            }
            if (boxOrPacketSellingPrice is not null)
            {
                productPrices.SetBoxOrPacketSellingPrice(boxOrPacketSellingPrice.Value);
            }
            _ProductPrice.Add(productPrices);
         
        }

        public void SetProductPrice(IEnumerable<ProductPrice> productPrices)
        {
            _ProductPrice.AddRange(productPrices);
        }

        public void TotalStock()
        {
            StockIn += _ProductPrice.Sum(x => x.Quantity);
        }

           
    }
}
