using LiteDB;
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
    public class ProductRepository : IProductRepository
    {
        private readonly ILogger<ProductRepository> _logger;
        private readonly ILiteDatabaseProvider _databaseProvider;
        public ProductRepository(ILiteDatabaseProvider databaseProvider,
            ILogger<ProductRepository> logger)
        {
            _databaseProvider = databaseProvider;
            _logger = logger;
        }

        public Product GetById(int id)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                return db.GetCollection<Product>().FindById(id);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                return db.GetCollection<Product>().FindAll().ToList();
            }
        }
        public IEnumerable<Product> GetAllById(int id)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                return db.GetCollection<Product>().Query().Where(x => x.Id == id).ToList();
            }
        }

        public (IEnumerable<Product> Result, int TotalPage) GetPage(int pageIndex, int pageSize, string product = "", int? category = null)
        {
            using (var db = _databaseProvider.GetDatabase())
            {



                var products = db.GetCollection<Product>();
                if (!string.IsNullOrEmpty(product) && category is not null)
                {
                    var result = products
                          .Query()
                          .Where(s => s.ProductName.Contains(product)
                                     && s.CategoryId.Equals(category))
                          .OrderByDescending(x => x.Id)
                          .Skip((pageIndex - 1) * pageSize)
                          .Limit(pageSize)
                          .ToList();

                    return (result, products.Count());
                }
                else if (category is not null)
                {
                    var result = products
                         .Query()
                         .Where(s => s.CategoryId.Equals(category))
                         .OrderByDescending(x => x.Id)
                         .Skip((pageIndex - 1) * pageSize)
                         .Limit(pageSize)
                         .ToList();
                    return (result, products.Count());
                }
                else if (!string.IsNullOrEmpty(product))
                {
                    var result = products
                        .Query()
                        .Where(s => s.ProductName.Contains(product))
                        .OrderByDescending(x => x.Id)
                        .Skip((pageIndex - 1) * pageSize)
                        .Limit(pageSize)
                        .ToList();
                    return (result, products.Count());
                }
                else
                {
                    var result = products
                        .Query()
                        .OrderByDescending(x => x.Id)
                        .Skip((pageIndex - 1) * pageSize)
                        .Limit(pageSize)
                        .ToList();
                    return (result, products.Count());
                }


            }
        }

        public void Add(Product entity)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                db.GetCollection<Product>().Insert(entity);
            }
        }

        public void Update(Product entity)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                db.GetCollection<Product>().Update(entity);
            }
        }

        public void Remove(int id)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                db.GetCollection<Product>().Delete(id);
            }
        }
    }
}
