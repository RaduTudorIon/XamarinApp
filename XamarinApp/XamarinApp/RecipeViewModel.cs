using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.ComponentModel;
using XamarinApp.Model;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace XamarinApp
{
    class RecipeViewModel : INotifyPropertyChanged
    {
        private readonly IRecipeRepository _recipeRepository;
        private ICollection<Recipe> _recipes;

        public ICollection<Recipe> Recipes
        {
            get
            {
                return _recipes;
            }
            set
            {
                _recipes = value;
                Console.WriteLine("sandokan");
                Console.WriteLine(_recipes.ToString());
                OnPropertyChanged(); 
            }
        }

        public double RecipeCalories { get; set; }
        public int RecipeCookingTime { get; set; }
        public string Recipeingredients { get; set; }
        public string RecipeTitle { get; set; }
        public string RecipeText { get; set; }
        public int ID { get; set; }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    Recipes = await _recipeRepository.GetRecipesAsync();
                });
            }
        }

        public ICommand AddCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var recipe = new Recipe
                    {
                        Id = ID,
                        RecipeCalories = RecipeCalories,
                        RecipeCookingTime = RecipeCookingTime,
                        Recipeingredients = Recipeingredients,
                        RecipeText = RecipeText,
                        RecipeTitle = RecipeTitle
                    };
                    await _recipeRepository.AddRecipeAsync(recipe);
                });
            }
        }

        public RecipeViewModel(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
