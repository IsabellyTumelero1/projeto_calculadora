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

        decimal value1 = 0, value2 = 0;
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
                if (txt_resultado.Text != "")
                {
                    if (valor1 >= 0)
                    {
                        double raiz = Math.Sqrt((double)valor1);
                        txt_resultado.Text = raiz.ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        MessageBox.Show("Não é possível calcular a raiz quadrada de um número negativo!", "Erro!");
                        txt_resultado.Text = "";
                    }
                }
            }
            else if (operacao == "EXPO")
            {
                txt_resultado.Text = Convert.ToString(Math.Pow(Convert.ToDouble(valor1), Convert.ToDouble(valor2)));
            }
            else if (operacao == "MOD")
            {
                txt_resultado.Text = (valor1 % valor2).ToString(CultureInfo.InvariantCulture);
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
                lbl_operacao.Text = "√";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a raiz", "AVISO!");
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
                MessageBox.Show("Informe um valor para efetuar a exponenciação", "AVISO!");
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
                MessageBox.Show("Informe um valor para efetuar o módulo", "AVISO!");
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
                MessageBox.Show("Informe um valor para efetuar a porcentagem", "AVISO!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtB_valor1_TextChanged(object sender, EventArgs e)
        {
            value1 = decimal.Parse(txtB_valor1.Text, CultureInfo.InvariantCulture);
        }

        private void txtB_valor2_TextChanged(object sender, EventArgs e)
        {
            value2 = decimal.Parse(txtB_valor2.Text, CultureInfo.InvariantCulture);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtB_result1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtB_segundoValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_calcular2_Click(object sender, EventArgs e)
        {
            decimal resultadoSoma = decimal.Parse(txtB_result1.Text, CultureInfo.InvariantCulture);
            decimal segundoValor = decimal.Parse(txtB_segundoValor.Text, CultureInfo.InvariantCulture);
            decimal resultadoSubtracao = resultadoSoma - segundoValor;
            txtB_result2.Text = Convert.ToString(resultadoSubtracao, CultureInfo.InvariantCulture);
            txtB_primeiroValor.Text = txtB_valor1.Text;
            txtB_resultDois.Text = txtB_result2.Text;
        }

        private void txtB_primeiroValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular3_Click(object sender, EventArgs e)
        {
            decimal primeiroValor = decimal.Parse(txtB_primeiroValor.Text, CultureInfo.InvariantCulture);
            decimal resultadoDois = decimal.Parse(txtB_resultDois.Text, CultureInfo.InvariantCulture);
            decimal resultadoMultiplica = primeiroValor * resultadoDois;
            txtB_result3.Text = Convert.ToString(resultadoMultiplica, CultureInfo.InvariantCulture);
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (txtB_valor1.Text != "" || txtB_valor2.Text != "")
            {
                txtB_result.Text = Convert.ToString(value1 + value2, CultureInfo.InvariantCulture);
                txtB_result1.Text = txtB_result.Text;
                txtB_segundoValor.Text = txtB_valor2.Text;
            }
            else
            {
                MessageBox.Show("Informe algum número nos campos acima!", "AVISO!");
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "8";
        }
    }
}
