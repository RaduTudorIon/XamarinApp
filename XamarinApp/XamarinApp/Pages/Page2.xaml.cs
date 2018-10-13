using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
    {
        IRecipeRepository recipeRepository;
        public Page2 (IRecipeRepository recipeRepository)
		{
            InitializeComponent ();
            this.recipeRepository = recipeRepository;
            BindingContext = new RecipeViewModel(recipeRepository);
        }

        async void Handle_Add_RecipeAsync(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddRecipe(recipeRepository));
            Navigation.RemovePage(this);
        }   
    }
}