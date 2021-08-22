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

namespace Calculatorwinform
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtresult.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtresult.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtresult.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtresult.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtresult.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtresult.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtresult.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtresult.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresult.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtresult.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtresult.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtresult.Text != "")
            {
                valor1 = decimal.Parse(txtresult.Text, CultureInfo.InvariantCulture);
                txtresult.Text = "";
                operacao = "SOMA";
                lbloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Insira um valor antes de aplicar a operação");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtresult.Text != "")
            {
                valor1 = decimal.Parse(txtresult.Text, CultureInfo.InvariantCulture);
                txtresult.Text = "";
                operacao = "SUB";
                lbloperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Insira um valor antes de aplicar a operação");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtresult.Text != "")
            {
                valor1 = decimal.Parse(txtresult.Text, CultureInfo.InvariantCulture);
                txtresult.Text = "";
                operacao = "MULT";
                lbloperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Insira um valor antes de aplicar a operação");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtresult.Text != "")
            {
                valor1 = decimal.Parse(txtresult.Text, CultureInfo.InvariantCulture);
                txtresult.Text = "";
                operacao = "DIV";
                lbloperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Insira um valor antes de aplicar a operação");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtresult.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                txtresult.Text = Convert.ToString(valor1 + valor2);
            }
            else if(operacao == "SUB"){
                txtresult.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtresult.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                txtresult.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtresult.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtresult.Text = "";
            valor1 = 0;
            valor2 = 0;
            lbloperacao.Text = "";
        }
    }
}
