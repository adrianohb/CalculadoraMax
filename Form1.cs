using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormularioCalculadora : Form
    {
        public FormularioCalculadora()
        {
            InitializeComponent();
        }

        decimal valor1;
        decimal valor2;
        string operacao;
        decimal resultadoOperacao;

        private void adcionarNumero(int numero)
        {                     

            decimal valor = decimal.Parse(txtResultado.Text);

            if (valor == 0)
            {
                txtResultado.Clear();
                txtResultado.Text = (txtResultado.Text + numero);
            }
            else
                txtResultado.Text = (txtResultado.Text + numero);
        }

        private void cliqueOperacao(string calculo)
        {
            valor1 = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
            txtResultado.Text = ("0");
            operacao = calculo;
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == ("0,"))
                txtResultado.Text = ("0,1");
            else
            adcionarNumero(1);
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == ("0,"))
                txtResultado.Text = ("0,2");
            else
                adcionarNumero(2);
           
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == ("0,"))
                txtResultado.Text = ("0,3");
            else
                adcionarNumero(3);
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == ("0,"))
                txtResultado.Text = ("0,4");
            else
                adcionarNumero(4);
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == ("0,"))
                txtResultado.Text = ("0,5");
            else
                adcionarNumero(5);
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == ("0,"))
                txtResultado.Text = ("0,6");
            else
                adcionarNumero(6);
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == ("0,"))
                txtResultado.Text = ("0,7");
            else
                adcionarNumero(7);
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == ("0,"))
                txtResultado.Text = ("0,8");
            else
                adcionarNumero(8);
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == ("0,"))
                txtResultado.Text = ("0,9");
            else
                adcionarNumero(9);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == ("0,"))
                txtResultado.Text = ("0,0");
            else
                adcionarNumero(0);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            operacao = "";
            valor1 = 0;
            valor2 = 0;

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            cliqueOperacao("+");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            cliqueOperacao("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            cliqueOperacao("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            cliqueOperacao("/");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                valor2 = decimal.Parse(txtResultado.Text);
                resultadoOperacao = (valor1 + valor2);
                txtResultado.Text = resultadoOperacao.ToString();
            }
            if (operacao == "-")
            {
                valor2 = decimal.Parse(txtResultado.Text);
                resultadoOperacao = (valor1 - valor2);
                txtResultado.Text = resultadoOperacao.ToString();
            }
            if (operacao == "*")
            {
                valor2 = decimal.Parse(txtResultado.Text);
                resultadoOperacao = (valor1 * valor2);
                txtResultado.Text = resultadoOperacao.ToString();
            }
            if (operacao == "/")
            { 
                valor2 = decimal.Parse(txtResultado.Text);
                resultadoOperacao = (valor1/ valor2);
                txtResultado.Text = resultadoOperacao.ToString() ;
            }    

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text == "0")
                txtResultado.Text = ("0,");
                 
            else
               txtResultado.Text = (txtResultado.Text + ",");
        }
    }
}
