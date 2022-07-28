using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj37461PrimeiroProjeto
{
    public partial class FRMCalculadora : Form
    {
        double resultado = 0.0, valor1 = 0.0, valor2 = 0.0;
        public FRMCalculadora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrimeiroValor.Text != "" && txtSegundoValor.Text != "")
                {
                    ConversaoValores();
                    resultado = valor1 / valor2;
                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Digite dois números para dividir");
                }
            }            
            catch
            {
                MessageBox.Show("Digite apenas números!");
                txtPrimeiroValor.Clear();
                txtSegundoValor.Clear();
                txtPrimeiroValor.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPrimeiroValor.Text = "";
            txtSegundoValor.Text = "";
            txtResultado.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrimeiroValor.Text != "" && txtSegundoValor.Text != "")
                {
                    ConversaoValores();
                    resultado = valor1 - valor2;
                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Digite dois números para subtrair");
                }
            }            
            catch
            {
                MessageBox.Show("Digite apenas números!");
                txtPrimeiroValor.Clear();
                txtSegundoValor.Clear();
                txtPrimeiroValor.Focus();
            }
        }

        private void ConversaoValores()
        {
            valor1 = double.Parse(txtPrimeiroValor.Text);
            valor2 = double.Parse(txtSegundoValor.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtPrimeiroValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrimeiroValor.Text != "" && txtSegundoValor.Text != "")
                {
                    ConversaoValores();
                    resultado = valor1 * valor2;
                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Digite dois números para multiplicar");
                }
            }            
            catch
            {
                MessageBox.Show("Digite apenas números!");
                txtPrimeiroValor.Clear();
                txtSegundoValor.Clear();
                txtPrimeiroValor.Focus();
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrimeiroValor.Text != "" && txtSegundoValor.Text != "")
                {
                    ConversaoValores();
                    resultado = valor1 + valor2;
                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Digite dois números para somar");
                }
            }
            catch
            {
                MessageBox.Show("Digite apenas números!");
                txtPrimeiroValor.Clear();
                txtSegundoValor.Clear();
                txtPrimeiroValor.Focus();
            }
        }
    }
}
