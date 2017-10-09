using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JuegoAleatorio
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Aleatorio : ContentPage
	{
        public int i=1;
        public int n;
        public int correctas=0; 

		public Aleatorio (int numero)
		{

            InitializeComponent();
            this.n = numero;
            Intentos.Text = "Intento " + this.i + " de " + this.n;
            PrimerNumero.Text = RandomNumber(0,9) + "";
            Operacion.Text = RandomOperation();
            SegundoNumero.Text = RandomNumber(0, 9) + ""; 

		}

        void EnviarResultado(object sender, System.EventArgs e)
        {
            i = i + 1;
            if (Operacion.Text == "+")
            {
                if (Convert.ToInt32(PrimerNumero.Text) + Convert.ToInt32(SegundoNumero.Text) == Convert.ToInt32(Resultado.Text))
                {
                    correctas++; 
                }

            } else
            {

                if (Convert.ToInt32(PrimerNumero.Text) - Convert.ToInt32(SegundoNumero.Text) == Convert.ToInt32(Resultado.Text))
                {
                    correctas++;
                }

            }

            Resultado.Text = ""; 
            if (i <= n)
            {
                
                Intentos.Text = "Intento " + this.i + " de " + this.n;
                PrimerNumero.Text = RandomNumber(0, 9) + "";
                Operacion.Text = RandomOperation();
                SegundoNumero.Text = RandomNumber(0, 9) + "";

            } else
            {
                DisplayAlert("Hola", "Tu resultado fue " + correctas + " de " + this.n, "ok");
                Navigation.PushModalAsync(new MainPage());
               
            }


        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private string RandomOperation()
        {


            Random random = new Random();
            int r = random.Next(0, 2); 
            if (r==0)
            {
                return "+";
            } else if (r==1)
            {
                return "-"; 
            }
            else
            {
                return "+"; 
            }
        }
    }
}