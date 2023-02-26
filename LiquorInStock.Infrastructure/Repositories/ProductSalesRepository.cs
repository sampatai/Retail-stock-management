using Microsoft.Extensions.Logging;
using Retail.Stock.Application.Common;
using Retail.Stock.Domain.Aggregates.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Stock.Infrastructure.Repositories
{
    public class ProductSalesRepository : IProductSalesRepository
    {
        private readonly ILogger<ProductSalesRepository> _logger;
        private readonly ILiteDatabaseProvider _databaseProvider;
        public ProductSalesRepository(ILiteDatabaseProvider databaseProvider,
            ILogger<ProductSalesRepository> logger)
        {
            _databaseProvider = databaseProvider;
            _logger = logger;
        }

        public ProductSales GetById(int id)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                return db.GetCollection<ProductSales>().FindById(id);
            }
        }

        public IEnumerable<ProductSales> GetAll()
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                return db.GetCollection<ProductSales>().FindAll();
            }
        }

        public IEnumerable<ProductSales> GetPage(
            int? ProductId = null, DateTime? start = null, DateTime? end = null)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                var products = db.GetCollection<ProductSales>();
                if (ProductId is not null)
                {
                    var result = products
                          //.Include(x => x.Products)
                          .Query()
                          .Where(s => s.AddedOn >= start && s.AddedOn <= end && s.ProductId.Equals(ProductId))
                          .OrderByDescending(x => x.Id)
                          .ToList();

                    return result;
                }
                else
                {

                    var result = products
                       .Include(x => x.Products)
                        .Query()
                        .Where(s => s.AddedOn >= start && s.AddedOn <= end)
                        .OrderByDescending(x => x.Id)

                        .ToList();
                    return result;
                }
            }
        }

        public void Add(ProductSales entity)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                db.GetCollection<ProductSales>().Insert(entity);
            }
        }

        public void Update(ProductSales entity)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                db.GetCollection<ProductSales>().Update(entity);
            }
        }

        public void Remove(int id)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                db.GetCollection<ProductSales>().Delete(id);
            }
        }
    }
}
