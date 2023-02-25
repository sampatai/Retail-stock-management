using Retail.Stock.Domain.Aggregates.Category;
using Retail.Stock.Shared.SeedWork;

namespace Retail.Stock.Application.Common
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(int id);
        public Category GetById(int id);
        public IEnumerable<Category> GetAll();
    }
}
