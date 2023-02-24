using Microsoft.Extensions.Logging;
using Retail.Stock.Application.Common;
using Retail.Stock.Shared.SeedWork;

namespace Retail.Stock.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ILogger<CategoryRepository> _logger;
        public CategoryRepository(ILogger<CategoryRepository> logger)
        {
            _logger = logger;
        }
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();
    }
}
