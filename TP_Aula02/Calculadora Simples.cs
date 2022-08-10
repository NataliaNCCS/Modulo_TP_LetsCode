using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Aula02
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        int PrimeiroValor = 0;
        int SegundoValor = 0;
        string Operacao = "";

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            PrimeiroValor = int.Parse(txtResultado.Text);
            Operacao = "SOMA";
            txtResultado.Text = String.Empty;

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            PrimeiroValor = int.Parse(txtResultado.Text);
            Operacao = "SUBTRACAO";
            txtResultado.Text = String.Empty;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            PrimeiroValor = int.Parse(txtResultado.Text);
            Operacao = "MULTIPLICACAO";
            txtResultado.Text = String.Empty;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            PrimeiroValor = int.Parse(txtResultado.Text);
            Operacao = "DIVISAO";
            txtResultado.Text = String.Empty;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            SegundoValor = int.Parse(txtResultado.Text);

            var result = 0;
            var erro = "";

            if (Operacao == "SOMA")
            {
                result = PrimeiroValor + SegundoValor;
            }
            else if (Operacao == "SUBTRACAO")
            {
                result = PrimeiroValor - SegundoValor;
            }
            else if (Operacao == "MULTIPLICACAO")
            {
                result = PrimeiroValor * SegundoValor;
            }
            else if (Operacao == "DIVISAO")
            {
                result = PrimeiroValor / SegundoValor;
            }
            else
            {
                erro = "ERRO";
            }

            txtResultado.Text = $"{result}{erro}";

        }


    }
}
