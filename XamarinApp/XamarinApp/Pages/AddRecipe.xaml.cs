using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddRecipe : ContentPage
    {
        IRecipeRepository recipeRepository;

        public AddRecipe(IRecipeRepository recipeRepository)
		{
            this.recipeRepository = recipeRepository;
			InitializeComponent ();
            BindingContext = new RecipeViewModel(recipeRepository);
        }

        async void Handle_BackAsync(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Page2(recipeRepository));
            Navigation.RemovePage(this);
        }
    }
}