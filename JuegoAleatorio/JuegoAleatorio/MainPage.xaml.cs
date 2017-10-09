using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JuegoAleatorio
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            Title = "El juego"; 
			InitializeComponent();
		}

        void Comenzar(object sender, System.EventArgs e)
        {

            Navigation.PushModalAsync(new Aleatorio( Convert.ToInt32(Numero.SelectedItem)));

          

        }
	}
}
