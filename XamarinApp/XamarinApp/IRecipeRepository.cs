using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Model;

namespace XamarinApp
{
    public interface IRecipeRepository
    {
        Task<ICollection<Recipe>> GetRecipesAsync();

        Task<Recipe> GetRecipeByIdAsync(int id);

        Task<bool> AddRecipeAsync(Recipe review);

        Task<bool> UpdateRecipeAsync(Recipe review);

        Task<bool> RemoveRecipeAsync(int id);

        Task<IEnumerable<Recipe>> QueryRecipesAsync(Func<Recipe, bool> predicate);
    }
}
