using LiteDB;
using Microsoft.Extensions.Logging;
using Retail.Stock.Application.Common;
using Retail.Stock.Domain.Aggregates.Category;
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

        public void Add(Category category)
        {
            try
            {

                // create a new instance of LiteDatabase
                using (var db = new LiteDatabase("Stock.db"))
                {
                    // get a reference to the collection
                    var categories = db.GetCollection<Category>("Categories");

                    // insert the new category
                    categories.Insert(category);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{@category}", category);
                throw;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            // create a new instance of LiteDatabase
            using (var db = new LiteDatabase("Stock.db"))
            {
                // get a reference to the collection
                var categories = db.GetCollection<Category>("Categories");

                // select all categories
                var results = categories.FindAll().ToList();
                
      
                return results;
                // select a specific category by name

            }
        }

        public void Update(Category category)
        {
            try
            {
                using (var db = new LiteDatabase("Stock.db"))
                {
                    // get a reference to the collection
                    var categories = db.GetCollection<Category>("Categories");

                    // select the category to update
                    var entity = categories.FindOne(c => c.Id.Increment == category.Id.Increment);

                    // update the category's name
                    category.SetDetails(category.Name);

                    // update the category in the collection
                    categories.Update(category);
                }

            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "{@category}", category);
                throw;
            }
        }
    }
}
