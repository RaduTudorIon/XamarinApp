using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Model;

namespace XamarinApp.Pages
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    //public partial class ListViewModel : ContentPage
    public partial class ListViewModel
    {
        public ObservableCollection<Recipe1> RecipeList { get; set; }

        public Recipe1 _selectedRecipe { get; set; }
        public Recipe1 SelectedRecipe
        {
            get { return _selectedRecipe; }
            set
            {
                if (_selectedRecipe != value)
                {
                    _selectedRecipe = value;
                    HandleSelectedItem();
                }
            }
        }
        private void HandleSelectedItem()
        {
            Page page = new Page();
             page.DisplayAlert("Selected recipe" , "Title" + SelectedRecipe.RecipeTitle + "Cooking time" + SelectedRecipe.RecipeCookingTime
                + "Recipe text" + SelectedRecipe.RecipeText, "Back to recipes");
        }
        public ListViewModel()
        {
            RecipeList = new ObservableCollection<Recipe1>
            {
                new Recipe1(){ RecipeTitle="Reteta bunicii", RecipeCookingTime="22", RecipeText="To make the dressing, place the water, sugar and chilli flakes in a small saucepan over a low heat and warm gently until the sugar is dissolved. Bring to the boil and cook for 30 seconds, stirring. Take off the heat and stir in the soy sauce and sesame oil. Leave to cool. Half-fill a saucepan with water and bring to the boil. Add the noodles and cook for 3–4 minutes, or according to the packet instructions, until tender.Stir occasionally to separate the strands.Add the soya beans or peas to the noodles, stir well and then immediately drain in a colander.Rinse the noodles and beans under cold running water until the mixture is completely cool. Tip into a large mixing bowl."},
                new Recipe1(){ RecipeTitle="Reteta bunicii2", RecipeCookingTime="22", RecipeText="asdsadadsada"},
                new Recipe1(){ RecipeTitle="Reteta bunicii3", RecipeCookingTime="22", RecipeText="asdsadadsada"},
            };
        }

        public class Recipe1
        {
            public string RecipeTitle { get; set; }
            public string RecipeCookingTime { get; set; }
            public string RecipeText { get; set; }
        }
	}
}