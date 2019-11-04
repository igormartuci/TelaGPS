using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Maps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelaGPS.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Gps : ContentPage
	{
        public Gps()
        {
            InitializeComponent();

            //  xamarin.forms.maps


            // xamarin.forms.googlemaps
            Xamarin.Forms.GoogleMaps.Map map = new Xamarin.Forms.GoogleMaps.Map();
            map.MyLocationEnabled = true;
            map.UiSettings.MyLocationButtonEnabled = true;
        }
    }
}