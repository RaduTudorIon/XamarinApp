using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : ContentPage
	{
		public Page4 ()
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


                var position1 = new Position(44.4525833, 26.0320882);
                var position2 = new Position(44.4407898, 26.1262733);
                var position3 = new Position(44.4114663, 26.1122915);
                var position4 = new Position(44.4295088, 26.1012303);
                var position5 = new Position(44.4218465, 26.128342);
                var position6 = new Position(44.4197807, 26.1136091);

                var pin1 = new Pin
                {
                    Type = PinType.Place,
                    Position = position1,
                    Label = "Trattoria Buongiorno",
                    Address = "Bulevardul Lascar Catargiu 56",
                };

                var pin2 = new Pin
                {
                    Type = PinType.Place,
                    Position = position2,
                    Label = "Belli Siciliani",
                    Address = "Strada Matasari 47",
                };

                var pin3 = new Pin
                {
                    Type = PinType.Place,
                    Position = position3,
                    Label = "Cucina di casa",
                    Address = "Calea Vacaresti 230",
                };

                var pin4 = new Pin
                {
                    Type = PinType.Place,
                    Position = position4,
                    Label = "Borsalino",
                    Address = "Bulevardul Ion C. Bratianu 44",
                };

                var pin5 = new Pin
                {
                    Type = PinType.Place,
                    Position = position5,
                    Label = "Ristorante DaGiulio",
                    Address = "Strada Popa Stoica Farcas",
                };

                var pin6 = new Pin
                {
                    Type = PinType.Place,
                    Position = position6,
                    Label = "Trattoria Pane e Vino",
                    Address = "Strada Nerva Traian",
                };

                map.Pins.Add(pin1);
                map.Pins.Add(pin2);
                map.Pins.Add(pin3);
                map.Pins.Add(pin4);
                map.Pins.Add(pin5);
                map.Pins.Add(pin6);

                Content = map;
            }
            catch(Exception ex)
            {

            }
        }

    }
}