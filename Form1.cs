using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checksomar.Checked = true)
            {
                checkmultiplicar.Enabled = false;
                checkdividir.Enabled = false;
                checksubtrair.Enabled = false;
            }
        }

        private void checksubtrair_CheckedChanged(object sender, EventArgs e)
        {
            if (checksubtrair.Checked = true)
                {
                checkmultiplicar.Enabled = false;
                checksomar.Enabled = false;
                checkdividir.Enabled = false;
                }
        }

        private void checkmultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmultiplicar.Checked = true)
            {
                checksomar.Enabled = false;
                checksubtrair.Enabled = false;
                checkdividir.Enabled = false;
            }
        }

        private void checkdividir_CheckedChanged(object sender, EventArgs e)
        {
            if (checkdividir.Checked= true)
                {
                   checkmultiplicar.Enabled = false;
                   checksubtrair.Enabled = false;
                   checksomar.Enabled = false;
                }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            checksomar.Enabled = true;
            checksomar.Checked = false;

            checksubtrair.Enabled = true;
            checksubtrair.Checked = false;

            checkdividir.Enabled = true;
            checkdividir.Checked = false;

            checkmultiplicar.Enabled = true;
            checkmultiplicar.Checked = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
