using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();

            GetRestaurants();
        }

        private async void GetRestaurants()
        {
            try
            {
                HttpClient client = new HttpClient();

                var response = await client.GetStringAsync("https://api.myjson.com/bins/vf3s0");

                var restaurants = JsonConvert.DeserializeObject<List<Restaurants>>(response);

                ProductsListView.ItemsSource = restaurants;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}