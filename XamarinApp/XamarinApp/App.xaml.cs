using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Pages;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinApp
{
    public partial class App : Application
    {
        public App(IRecipeRepository recipeRepository)
        {
            InitializeComponent();

            MainPage = new MainPage(recipeRepository);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
