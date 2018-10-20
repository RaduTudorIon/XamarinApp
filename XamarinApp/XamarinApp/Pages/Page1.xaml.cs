using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Model;

namespace XamarinApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {

        public ObservableCollection<Recipe1> RecipeList { get; set; }

        private Recipe1 _selectedRecipe { get; set; }
        public Recipe1 SelectedRecipe
        {
            get { return _selectedRecipe; }
            set
            {
                if (_selectedRecipe != value)
                {
                    _selectedRecipe = value;
                    HandleSelectedItem();
                    //OnPropertyChanged("SelectedRecipe");
                }
            }
        }

        private void HandleSelectedItem()
        {
            Page page = new Page();
            page.DisplayAlert("Selected recipe", "Title" + SelectedRecipe.RecipeTitle + "Cooking time" + SelectedRecipe.RecipeCookingTime
               + "Recipe text" + SelectedRecipe.RecipeText, "Back to recipes");
        }
        public Page1()
        {
            InitializeComponent();
            RecipeList = new ObservableCollection<Recipe1>
            {
                new Recipe1(){ RecipeTitle="Reteta bunicii", RecipeCookingTime="22", RecipeText="asdsadadsada"},
                new Recipe1(){ RecipeTitle="Reteta bunicii2", RecipeCookingTime="22", RecipeText="asdsadadsada"},
                new Recipe1(){ RecipeTitle="Reteta bunicii3", RecipeCookingTime="22", RecipeText="asdsadadsada"},
            };
            listViewRecommendedRecipes.ItemsSource = RecipeList;
            BindingContext = listViewRecommendedRecipes;
            //SelectedRecipe = RecipeList[2];
            //listViewRecommendedRecipes.BindingContext = SelectedRecipe;
            //listViewRecommendedRecipes.BindingContextChanged += HandleSelectedItem();
        }

        public class Recipe1
        {
            public string RecipeTitle { get; set; }
            public string RecipeCookingTime { get; set; }
            public string RecipeText { get; set; }
        }
    }
}