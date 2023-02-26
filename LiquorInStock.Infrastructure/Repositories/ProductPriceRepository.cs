using Microsoft.Extensions.Logging;
using Retail.Stock.Application.Common;
using Retail.Stock.Domain.Aggregates.Product;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Stock.Infrastructure.Repositories
{

    public class ProductPriceRepository : IProductPriceRepository
    {
        private readonly ILogger<ProductRepository> _logger;
        private readonly ILiteDatabaseProvider _databaseProvider;
        public ProductPriceRepository(ILiteDatabaseProvider databaseProvider,
            ILogger<ProductRepository> logger)
        {
            _databaseProvider = databaseProvider;
            _logger = logger;
        }

        public ProductPrice GetById(int id)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                return db.GetCollection<ProductPrice>().FindById(id);
            }
        }

        public IEnumerable<ProductPrice> GetAll()
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                return db.GetCollection<ProductPrice>().FindAll();
            }
        }

        public (IEnumerable<ProductPrice> Result, int TotalPage) GetPage(int pageIndex, int pageSize,
            int? ProductId = null, DateTime? start = null, DateTime? end = null)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                var products = db.GetCollection<ProductPrice>();
                if (ProductId is not null)
                {
                    var result = products                   
                          //.Include(x => x.Products)
                          .Query()
                          .Where(s => s.AddedOn >= start && s.AddedOn <= end && s.ProductId.Equals(ProductId))
                          .OrderByDescending(x => x.Id)
                          .Skip((pageIndex - 1) * pageSize)
                          .Limit(pageSize)
                          .ToList();

                    return (result, products.Count());
                }
                else
                {

                    var result = products                       
                       .Include(x => x.Products)
                        .Query()
                        .Where(s => s.AddedOn >= start && s.AddedOn <= end)
                        .OrderByDescending(x => x.Id)
                        .Skip((pageIndex - 1) * pageSize)
                        .Limit(pageSize)
                        .ToList();
                    return (result, products.Count());
                }
            }
        }

        public void Add(ProductPrice entity)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                db.GetCollection<ProductPrice>().Insert(entity);
            }
        }

        public void Update(ProductPrice entity)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                db.GetCollection<ProductPrice>().Update(entity);
            }
        }

        public void Remove(int id)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                db.GetCollection<ProductPrice>().Delete(id);
            }
        }
    }
}
