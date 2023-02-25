using Retail.Stock.Domain.Aggregates.Product;

using Retail.Stock.Shared.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Stock.Application.Common
{
    public interface IProductPriceRepository
    : IRepository<ProductPrice>
    {
        ProductPrice GetById(int id);
        IEnumerable<ProductPrice> GetAll();
        (IEnumerable<ProductPrice> Result, int TotalPage) GetPage(int pageIndex, int pageSize,
            int? ProductId = null, DateTime? start=null,DateTime? end = null);
        void Add(ProductPrice entity);
        void Update(ProductPrice entity);
        void Remove(int id);
    }
}
