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
	public partial class TurkishMapRestaurants : ContentPage
	{
		public TurkishMapRestaurants ()
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


                var position1 = new Position(44.416904, 26.103956);
                var position2 = new Position(44.4202968, 26.1140701);
                var position3 = new Position(44.418603, 26.058861);
                var position4 = new Position(44.4326338, 26.0960913);
                var position5 = new Position(44.4425088, 26.1191793);
                var position6 = new Position(44.4702258, 26.1445193);

                var pin1 = new Pin
                {
                    Type = PinType.Place,
                    Position = position1,
                    Label = "Dristor Doner",
                    Address = "Bulevardul Dimitrie Cantemir 24",
                };

                var pin2 = new Pin
                {
                    Type = PinType.Place,
                    Position = position2,
                    Label = "Efes Restaurant",
                    Address = "Strada Nerva Traian 17-19",
                };

                var pin3 = new Pin
                {
                    Type = PinType.Place,
                    Position = position3,
                    Label = "Restaurant Turqoise",
                    Address = "Strada Theodor D. Speranția 96",
                };

                var pin4 = new Pin
                {
                    Type = PinType.Place,
                    Position = position4,
                    Label = "Saray Restaurant",
                    Address = "Strada Lipscani 21",
                };

                var pin5 = new Pin
                {
                    Type = PinType.Place,
                    Position = position5,
                    Label = "Les Ottomans",
                    Address = "Iancu Capitanu No. 26",
                };

                var pin6 = new Pin
                {
                    Type = PinType.Place,
                    Position = position6,
                    Label = "Restaurant Edessa",
                    Address = "Șoseaua Colentina 281",
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