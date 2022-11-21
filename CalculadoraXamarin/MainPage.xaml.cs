using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraXamarin
{
    public partial class MainPage : ContentPage
    {
        private double Numero1;
        private double Numero2;
        private string Operador;

        public MainPage()
        {
            InitializeComponent();
        }

        private void clickReset(object sender, EventArgs e)
        {

            txtResultado.Text = "0";
            Numero1 = 0;
            Numero2 = 0;

        }



        private void clickBorrar(object sender, EventArgs e)
        {


            string resultado = txtResultado.Text.ToString();
            

            if(resultado.Length != 0)
            {
                txtResultado.Text = resultado.Substring(0, resultado.Length - 1);

            }

        }


        private void clicNumero(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = tmp.Text;
            }
            else
            {
                txtResultado.Text += tmp.Text;
            }

        }


        private void clickPorcentaje(object sender, EventArgs e)
        {
            Operador = "%";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicSuma(object sender, EventArgs e)
        {
            Operador = "+";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicResta(object sender, EventArgs e)
        {
            Operador = "-";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicMultiplicacion(object sender, EventArgs e)
        {
            Operador = "*";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicDivision(object sender, EventArgs e)
        {
            Operador = "/";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicIgual(object sender, EventArgs e)
        {

            Numero2 = Double.Parse(txtResultado.Text);

            double operacionFinal = 0;

            if (Operador == "+")
            {
                operacionFinal = Numero1 + Numero2;

            }

            else if (Operador == "-")
            {
                operacionFinal = Numero1 - Numero2;

            }

            else if (Operador == "*")
            {
                operacionFinal = Numero1 * Numero2;

            }

            else if (Operador == "/")
            {
                operacionFinal = Numero1 / Numero2;

            }

            else if (Operador == "%")
            {
                operacionFinal = (Numero1 * Numero2) / 100;

            }

            txtResultado.Text = operacionFinal.ToString();


        }
    }
}
