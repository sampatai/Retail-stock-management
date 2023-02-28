using Retail.Stock.Domain.Aggregates.Product;
using Retail.Stock.Shared.SeedWork;


namespace Retail.Stock.Application.Common
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetById(int id);
        IEnumerable<Product> GetAll();
         IEnumerable<Product> GetAllById(int id);
        (IEnumerable<Product> Result,int TotalPage) GetPage(int pageIndex, int pageSize,string product="",int ?category=null);
        void Add(Product entity);
        void Update(Product entity);
        void Remove(int id);
        bool CheckUsedProduct(int id);
    }

   

}
