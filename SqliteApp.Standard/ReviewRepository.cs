using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp;

namespace SqliteApp.Standard
{
    class ReviewRepository : IReviewsReopsitory
    {
        private readonly DatabaseContext _databaseContext;

        public ReviewRepository(string dbPath)
        {
            _databaseContext = new DatabaseContext(dbPath);
        }

        public async Task<Review> GetReviewByIdAsync(int id)
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

        public async Task<bool> AddReviewAsync(Review review)
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

        public async Task<bool> UpdateReviewAsync(Review review)
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

        public async Task<bool> RemoveProductAsync(int id)
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

        public async Task<IEnumerable<Review>> QueryProductAsync(Func<Review, bool> predicate)
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

        public async Task<IEnumerable<Review>> GetReviewsAsync()
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
