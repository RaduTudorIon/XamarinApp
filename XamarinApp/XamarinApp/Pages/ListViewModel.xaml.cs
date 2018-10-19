using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Model;

namespace XamarinApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewModel : ContentPage
	{
        public ObservableCollection<Recipe> RecipeList { get; set; }

        public Recipe _selectedRecipe { get; set; }
        public Recipe selectedRecipe
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

        }
        public ListViewModel()
        {
            RecipeList = new ObservableCollection<Recipe>
            {
                new Recipe(){ RecipeTitle="Reteta bunicii", RecipeCookingTime=22, RecipeText="asdsadadsada"},
                new Recipe(){ RecipeTitle="Reteta bunicii2", RecipeCookingTime=22, RecipeText="asdsadadsada"},
                new Recipe(){ RecipeTitle="Reteta bunicii3", RecipeCookingTime=22, RecipeText="asdsadadsada"},
            };
		}
	}
}