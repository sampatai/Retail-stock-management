using Retail.Stock.Domain.Aggregates.Product;
using Retail.Stock.Shared.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Stock.Application.Common
{
    public interface IProductSalesRepository : IRepository<ProductSales>
    {
        ProductSales GetById(int id);
        IEnumerable<ProductSales> GetAll();
        IEnumerable<ProductSales> GetPage(
            int? ProductId = null, DateTime? start = null, DateTime? end = null);
        void Add(ProductSales entity);
        void Update(ProductSales entity);
        void Remove(int id);
    }
}

