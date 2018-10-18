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
			//InitializeComponent ();
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
                var position2 = new Position(44.4168926, 26.1146395);
                var position3 = new Position(44.437958, 26.123317);
                var position4 = new Position(44.4710441, 26.0907489);
                var position5 = new Position(44.4317669, 26.1181039);
                var position6 = new Position(44.4305753, 26.1028397);

                var pin1 = new Pin
                {
                    Type = PinType.Place,
                    Position = position1,
                    Label = "Dristor Doner",
                    Address = "Bulevard. X strada Y",
                };

                var pin2 = new Pin
                {
                    Type = PinType.Place,
                    Position = position2,
                    Label = "Taverna Racilor",
                    Address = "Strada Nerva Traian 4",
                };

                var pin3 = new Pin
                {
                    Type = PinType.Place,
                    Position = position3,
                    Label = "Taverna La Zavat",
                    Address = "Strada Popa Nan 16",
                };

                var pin4 = new Pin
                {
                    Type = PinType.Place,
                    Position = position4,
                    Label = "Restaurant Pescarus",
                    Address = "Address: Aviatorilor Bld., No. 1",
                };

                var pin5 = new Pin
                {
                    Type = PinType.Place,
                    Position = position5,
                    Label = "Trattoria Buongiorno",
                    Address = "Strada C. A. Rosetti 13",
                };

                var pin6 = new Pin
                {
                    Type = PinType.Place,
                    Position = position6,
                    Label = "Lacrimi si sfinti",
                    Address = "Strada C. A. Rosetti 13",
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