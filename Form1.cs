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

            // Captura todos os eventos de teclas antes dos componetes filhos.
            this.KeyPreview = true;
        }

        decimal valor1;
        decimal valor2;
        string operacao;
        decimal resultadoOperacao;
        bool precisaLimparTela = false;

        private void adcionarNumero(int numero)
        {

            decimal valor = decimal.Parse(txtResultado.Text);

            if (valor == 0 || precisaLimparTela)
            {
                precisaLimparTela = false;
                txtResultado.Clear();

            }

            txtResultado.Text = (txtResultado.Text + numero);
        }

        private void cliqueOperacao(string calculo)
        {
            valor1 = decimal.Parse(txtResultado.Text);
            precisaLimparTela = true;
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
            // Atribui o segundo valor que está na tela na variável valor2
            valor2 = decimal.Parse(txtResultado.Text);

            if (operacao == "+")
            {
                resultadoOperacao = (valor1 + valor2);
            }
            else if (operacao == "-")
            {
                resultadoOperacao = (valor1 - valor2);
            }
            else if (operacao == "*")
            {
                resultadoOperacao = (valor1 * valor2);
            }
            else if (operacao == "/")
            {
                if (valor2 == 0)
                {
                    // Se o segundo número for zero, para de executar o programa e aguarda usuário digitar novo valor.
                    return;
                }
                resultadoOperacao = (valor1 / valor2);
            }

            // Mostra o resultado da operação no txtResultado
            txtResultado.Text = resultadoOperacao.ToString();

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text == "0")
                txtResultado.Text = ("0,");

            else
                txtResultado.Text = (txtResultado.Text + ",");
        }

        // Executa quando o usuário digita uma tecla
        private void FormularioCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se o usuário apertar o número no teclado
            if (e.KeyChar == '0')
                adcionarNumero(0);
            else if (e.KeyChar == '1')
                adcionarNumero(1);
            else if (e.KeyChar == '2')
                adcionarNumero(2);
            else if (e.KeyChar == '3')
                adcionarNumero(3);
            else if (e.KeyChar == '4')
                adcionarNumero(4);
            else if (e.KeyChar == '5')
                adcionarNumero(5);
            else if (e.KeyChar == '6')
                adcionarNumero(6);
            else if (e.KeyChar == '7')
                adcionarNumero(7);
            else if (e.KeyChar == '8')
                adcionarNumero(8);
            else if (e.KeyChar == '9')
                adcionarNumero(9);
            else if (e.KeyChar == '+')
                cliqueOperacao("+");
            else if (e.KeyChar == '-')
                cliqueOperacao("-");
            else if (e.KeyChar == '*')
                cliqueOperacao("*");
            else if (e.KeyChar == '/')
                cliqueOperacao("/");

        }
    }
}
