using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FrenchMapRestaurants : ContentPage
	{
		public FrenchMapRestaurants ()
		{
			InitializeComponent ();
            try
            {
                var map = new Map(MapSpan.FromCenterAndRadius(
                    new Position(44.4268, 26.1025),
                    Distance.FromMiles(1.5)))
                {
                    IsShowingUser = true,
                    VerticalOptions = LayoutOptions.FillAndExpand

                };


                var position1 = new Position(44.4349359, 26.092916);
                var position2 = new Position(44.4420634, 26.0953762);
                var position3 = new Position(44.4497298, 26.0905433);
                var position4 = new Position(44.4575254, 26.0894295);
                var position5 = new Position(44.4252795, 26.1002064);
                var position6 = new Position(44.4525502, 26.0474091);

                var pin1 = new Pin
                {
                    Type = PinType.Place,
                    Position = position1,
                    Label = "Restaurant Ici Et La",
                    Address = "Bulevardul Regina Elisabeta 38",
                };

                var pin2 = new Pin
                {
                    Type = PinType.Place,
                    Position = position2,
                    Label = "Le Bistrot Francais",
                    Address = "Strada Nicolae Golescu 18",
                };

                var pin3 = new Pin
                {
                    Type = PinType.Place,
                    Position = position3,
                    Label = "La Cantine de Nicolai",
                    Address = "Strada Povernei 15-17",
                };

                var pin4 = new Pin
                {
                    Type = PinType.Place,
                    Position = position4,
                    Label = "Noblesse Restaurant",
                    Address = "Strada Paris 47A",
                };

                var pin5 = new Pin
                {
                    Type = PinType.Place,
                    Position = position5,
                    Label = "Alouette",
                    Address = "Strada Bibescu Vodă 19",
                };

                var pin6 = new Pin
                {
                    Type = PinType.Place,
                    Position = position6,
                    Label = "The Parisian",
                    Address = "Strada Munții Apuseni 29",
                };

                map.Pins.Add(pin1);
                map.Pins.Add(pin2);
                map.Pins.Add(pin3);
                map.Pins.Add(pin4);
                map.Pins.Add(pin5);
                map.Pins.Add(pin6);

                Content = map;
            }
            catch (Exception ex)
            {

            }
        }
	}
}