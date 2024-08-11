using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double Valor1, Valor2, resultado;
        private int caso, alter=1;
        private string error;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //numero 0
            tbDisplay.Text = "";
            tbDisplay.Text += "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //numero 1
            tbDisplay.Text = "";
            tbDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //numero 2
            tbDisplay.Text = "";
            tbDisplay.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //numero 3
            tbDisplay.Text = "";
            tbDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //numero 4
            tbDisplay.Text = "";
            tbDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //numero 5
            tbDisplay.Text = "";
            tbDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //numero 6
            tbDisplay.Text = "";
            tbDisplay.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            //numero 7
            tbDisplay.Text = "";
            tbDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //numero 8
            tbDisplay.Text = "";
            tbDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero 9
            tbDisplay.Text = "";
            tbDisplay.Text += "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Suma
            caso = 1;
            Valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //Resta
            caso = 2;
            Valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            //Multi
            caso = 3;
            Valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            //Divi
            caso = 4;
            Valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //punto
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Igual
            Valor2 = Convert.ToDouble(tbDisplay.Text);

            switch (caso)
            {
                case 1:
                    resultado = Valor1 + Valor2;
                    break;
                case 2:
                    resultado = Valor1 - Valor2;
                    break;
                case 3:
                    resultado = Valor1 * Valor2;
                    break;
                case 4:
                    if (Valor2 != 0)
                        resultado = Valor1 / Valor2;
                    else
                        alter = 0;
                        error = "Qué pasa, reina?\nDivisión por 0? \nNo pasa nada,\nyo te divido igualmente";
                    break;     
            }

            if (alter == 1)
                tbDisplay.Text = resultado.ToString();
            else
                tbDisplay.Text = error;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Borrar
            tbDisplay.Text = "";
        }
    }
}
