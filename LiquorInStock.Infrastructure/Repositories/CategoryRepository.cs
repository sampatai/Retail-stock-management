using LiteDB;
using Microsoft.Extensions.Logging;
using Retail.Stock.Application.Common;
using Retail.Stock.Domain.Aggregates.Category;
using Retail.Stock.Domain.Aggregates.Product;
using Retail.Stock.Shared.SeedWork;

namespace Retail.Stock.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ILogger<CategoryRepository> _logger;
        private readonly ILiteDatabaseProvider _databaseProvider;
        public CategoryRepository(ILogger<CategoryRepository> logger, ILiteDatabaseProvider databaseProvider)
        {
            _logger = logger;
            _databaseProvider = databaseProvider;
        }

        public void Add(Category category)
        {
            try
            {

                // create a new instance of LiteDatabase
                using (var db = _databaseProvider.GetDatabase())
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

        public bool CheckProduct(int id)
        {
            using (var db = _databaseProvider.GetDatabase())
            {
                return db.GetCollection<Product>().Query().Where(x => x.CategoryId == id).Exists();
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var db = _databaseProvider.GetDatabase())
                {
                    var categoryCollection = db.GetCollection<Category>("Categories");

                    var categoryToDelete = categoryCollection.FindOne(x => x.Id == id);

                    if (categoryToDelete != null)
                    {
                        categoryCollection.Delete(categoryToDelete.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{@id}", id);

                throw;
            }

        }

        public IEnumerable<Category> GetAll()
        {
            try
            {
                // create a new instance of LiteDatabase
                using (var db = _databaseProvider.GetDatabase())
                {
                    // get a reference to the collection
                    var categories = db.GetCollection<Category>("Categories");

                    // select all categories
                    var results = categories.FindAll();


                    return results.ToList(); ;
                    // select a specific category by name

                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                throw;
            }
        }

        public Category GetById(int id)
        {
            try
            {
                using (var db = _databaseProvider.GetDatabase())
                {
                    // get a reference to the collection
                    var categories = db.GetCollection<Category>("Categories");

                    // select the category to update
                    return categories.FindOne(c => c.Id == id);
                }

            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "{@id}", id);
                throw;
            }
        }

        public void Update(Category category)
        {
            try
            {
                using (var db = _databaseProvider.GetDatabase())
                {
                    // get a reference to the collection
                    var categories = db.GetCollection<Category>("Categories");

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
