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
                new Recipe1(){ RecipeTitle="Lasagna", RecipeCookingTime="4h 20m", RecipeText="First infuse the milk to make the béchamel sauce. Put the 1 ½ litres milk, 1 thickly sliced onion, 3 bay leaves and 3 cloves into a large saucepan and bring very gently just up to the boil. Turn off the heat and set aside for 1 hr to infuse."},
                new Recipe1(){ RecipeTitle="Homemade Spaghetti Sauce", RecipeCookingTime="40m", RecipeText="First brown the beef and onion. Chop the ground beef finely as you go. After it’s browned I often like to add it to my food processor to pulse it once or twice so that it’s finely crumbled. It makes the sauce extra smooth (although some people like their spaghettie sauce with larger peices of meat in it,)"},
                new Recipe1(){ RecipeTitle="Penne with Chicken and Pesto ", RecipeCookingTime="30m", RecipeText="Bring a large pot of lightly salted water to a boil. Add pasta and cook for 8 to 10 minutes or until al dente; drain."},
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