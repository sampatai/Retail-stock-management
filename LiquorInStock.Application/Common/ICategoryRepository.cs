using Retail.Stock.Domain.Aggregates.Category;
using Retail.Stock.Shared.SeedWork;

namespace Retail.Stock.Application.Common
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
