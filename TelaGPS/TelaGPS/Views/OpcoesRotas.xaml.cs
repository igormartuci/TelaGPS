using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaGPS.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelaGPS.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OpcoesRotas : ContentPage
	{
		public OpcoesRotas ()
		{
			InitializeComponent ();

		}

        public void onCalcularRota ()
        {
            if (txtOrigem.Text != null && txtDestino != null)
            {
                App.Current.MainPage = new Gps();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}