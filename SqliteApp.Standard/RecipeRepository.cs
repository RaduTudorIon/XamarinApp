using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Model;
using XamarinApp;

namespace SqliteApp.Standard 
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly DatabaseContext _databaseContext;

        public RecipeRepository(string dbPath)
        {
            _databaseContext = new DatabaseContext(dbPath);
        }

        public async Task<Recipe> GetRecipeByIdAsync(int id)
        {
            try
            {
                var product = await _databaseContext.Reviews.FindAsync(id);

                return product;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> AddRecipeAsync(Recipe review)
        {
            try
            {
                var tracking = await _databaseContext.Reviews.AddAsync(review);

                await _databaseContext.SaveChangesAsync();

                var isAdded = tracking.State == Microsoft.EntityFrameworkCore.EntityState.Added;

                return isAdded;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateRecipeAsync(Recipe review)
        {
            try
            {
                var tracking = _databaseContext.Update(review);

                await _databaseContext.SaveChangesAsync();

                var isModified = tracking.State == EntityState.Modified;

                return isModified;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> RemoveRecipeAsync(int id)
        {
            try
            {
                var product = await _databaseContext.Reviews.FindAsync(id);

                var tracking = _databaseContext.Remove(product);

                await _databaseContext.SaveChangesAsync();

                var isDeleted = tracking.State == EntityState.Deleted;

                return isDeleted;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Recipe>> QueryRecipesAsync(Func<Recipe, bool> predicate)
        {
            try
            {
                var reviews = _databaseContext.Reviews.Where(predicate);

                return reviews.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<ICollection<Recipe>> GetRecipesAsync()
        {
            try
            {
                var reviews = await _databaseContext.Reviews.ToListAsync();
                return reviews;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
