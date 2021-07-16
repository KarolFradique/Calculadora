using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
   
    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            TxtRstd.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TxtRstd.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxtRstd.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TxtRstd.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TxtRstd.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtRstd.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtRstd.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtRstd.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtRstd.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtRstd.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TxtRstd.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(TxtRstd.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                TxtRstd.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                TxtRstd.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                TxtRstd.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                TxtRstd.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TxtRstd.Text != "")
            {
                valor1 = decimal.Parse(TxtRstd.Text, CultureInfo.InvariantCulture);
                TxtRstd.Text = "";
                operacao = "SUB";
                LbOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para continuar");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (TxtRstd.Text != "")
            {
                valor1 = decimal.Parse(TxtRstd.Text, CultureInfo.InvariantCulture);
                TxtRstd.Text = "";
                operacao = "MULT";
                LbOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para continuar");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (TxtRstd.Text != "")
            {
                valor1 = decimal.Parse(TxtRstd.Text, CultureInfo.InvariantCulture);
                TxtRstd.Text = "";
                operacao = "DIV";
                LbOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para continuar");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtRstd.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            TxtRstd.Text = "";
            valor1 = 0;
            valor2 = 0;
            LbOperacao.Text = "";
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TxtRstd.Text != "")
            {
                valor1 = decimal.Parse(TxtRstd.Text, CultureInfo.InvariantCulture);
                TxtRstd.Text = "";
                operacao = "SOMA";
                LbOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para continuar");
            }
           
        }
    }
}
