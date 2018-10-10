using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp
{
    public interface IReviewsReopsitory
    {
        Task<IEnumerable<Review>> GetReviewsAsync();

        Task<Review> GetReviewByIdAsync(int id);

        Task<bool> AddReviewAsync(Review review);

        Task<bool> UpdateReviewAsync(Review review);

        Task<bool> RemoveProductAsync(int id);

        Task<IEnumerable<Review>> QueryProductAsync(Func<Review, bool> predicate);
    }
}
