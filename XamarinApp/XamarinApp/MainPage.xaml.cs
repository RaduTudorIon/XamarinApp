using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Pages;

namespace XamarinApp
{
    public partial class MainPage : MasterDetailPage
    {
        IRecipeRepository recipeRepository;
        public MainPage(IRecipeRepository recipeRepository)
        {
            InitializeComponent();
            this.recipeRepository = recipeRepository;
            Detail = new NavigationPage(new Page1());

            IsPresented = false;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Page1());
            IsPresented = false;

        }

        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Page2(recipeRepository));
            IsPresented = false;
        }

        void Handle_Clicked3(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Page3());
            IsPresented = false;
        }

        void Handle_Clicked4(object sender, System.EventArgs e)
        {
            Detail = new TabbedPage{
               Children ={
                    new Page4(), new TurkishMapRestaurants(), new FrenchMapRestaurants(), new RomanianMapRestaurants()
                    }
            };
            IsPresented = false;
        }

        void Handle_Clicked5(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Page5());
            IsPresented = false;
        }

        void Handle_Clicked6(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Page6());
            IsPresented = false;
        }
    }
}
