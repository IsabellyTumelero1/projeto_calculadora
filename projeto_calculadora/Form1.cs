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

namespace projeto_calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "7";
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "SOMA";
                lbl_operacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma", "ERRO!");
            }
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txt_resultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txt_resultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txt_resultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVIDE")
            {
                txt_resultado.Text = Convert.ToString(valor1 / valor2, CultureInfo.InvariantCulture);
            }
            else if (operacao == "RAIZ")
            {
                // Aqui valida se há algo no campo de texto, ou se a operação é raiz quadrada
                if (txt_resultado.Text != "")
                {
                    // Verifica se o valor1 é maior ou igual a 0
                    if (valor1 >= 0)
                    {
                        double raiz = Math.Sqrt((double)valor1);
                        txt_resultado.Text = raiz.ToString(CultureInfo.InvariantCulture); // Exibe o resultado com 2 casas decimais
                    }
                    else
                    {
                        MessageBox.Show("Não é possível calcular a raiz quadrada de um número negativo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_resultado.Text = ""; // Limpa a tela em caso de erro
                    }
                }
            }
            else if (operacao == "EXPO")
            {
                txt_resultado.Text = Convert.ToString(Math.Pow(Convert.ToDouble(valor1), Convert.ToDouble(valor2)));
            }
            else if (operacao == "MOD")
            {
                txt_resultado.Text = (valor1 % valor2).ToString("F2", CultureInfo.InvariantCulture);
            }
            else if (operacao == "PORC")
            {
                decimal resultado = valor1 * (valor2 / 100);
                txt_resultado.Text = resultado.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void btn_subtrai_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "SUB";
                lbl_operacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração", "AVISO!");
            }
        }

        private void btn_multiplica_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "MULT";
                lbl_operacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação", "AVISO!");
            }
        }

        private void btn__divide_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "DIV";
                lbl_operacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão", "AVISO!");
            }
        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_apaga_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
            lbl_operacao.Text = "";
        }

        private void btn_exclui_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lbl_operacao.Text = "";
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                operacao = "RAIZ";
                lbl_operacao.Text = "√"; // Exibe o símbolo da raiz para indicar a operação
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão", "AVISO!");
            }
        }

        private void btn_exponenciação_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "EXPO";
                lbl_operacao.Text = "^";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão", "AVISO!");
            }

        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            if (!txt_resultado.Text.Contains("."))
            {
                txt_resultado.Text += ".";
            }
        }

        private void btn_modulo_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "MOD";
                lbl_operacao.Text = "mod";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão", "AVISO!");
            }
        }

        private void btn_porcentagem_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "PORC";
                lbl_operacao.Text = "%";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão", "AVISO!");
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "8";
        }
    }
}
