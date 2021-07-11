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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(".")== false)
            {
                textBox1.Text += ".";
            }
            else if (textBox1.Text.Contains(".") && textBox1.Text.Contains("+")|| textBox1.Text.Contains("-") ||
                textBox1.Text.Contains("÷") || textBox1.Text.Contains("x")) 
            {
                textBox1.Text += ".";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonParentesis_Click(object sender, EventArgs e)
        {
         
            textBox1.Text += "(";
        }

        private void buttonEliminarTodo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonEliminarUno_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length -1);
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+ ";
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            textBox1.Text += "- ";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            textBox1.Text += "x";
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "÷";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
          

        DataTable dt = new DataTable();
        String datos = textBox1.Text.Replace("x", "* ").Replace("÷", "/ ").Replace(",", ".");
        String[] lista =datos.Split(" ");
        String resultado = "";

        try
        {
            foreach (String elementos in lista){
            
                String cadena = elementos;

                if (cadena.Contains("√"))
                {

                    cadena = cadena.Substring(0, cadena.IndexOf("√")) + Convert.ToString(Math.Sqrt(Convert.ToDouble(cadena.Substring(
                        cadena.IndexOf("√")+ 2, cadena.Length - cadena.IndexOf("√") - 3))));

                    }

                if (cadena.Contains("^"))
                {

                    cadena = Convert.ToString(Math.Pow(Convert.ToDouble(cadena.Substring(0, cadena.IndexOf("^"))), 
                    Convert.ToDouble(cadena.Substring(cadena.IndexOf("^") + 2, cadena.Length - cadena.IndexOf("^") - 3))));

                }

                resultado += cadena;
                }


            
            var resultadoFinal = Convert.ToString(dt.Compute("1.0*" + resultado.Replace(",", "."), null));

            if (resultadoFinal.Substring(resultadoFinal.Length - 2, 2) == ",0")
            {
                resultadoFinal = resultadoFinal.Substring(0, resultadoFinal.Length - 2);
                textBox1.Text = resultadoFinal;
            }
            else
            {
                textBox1.Text = resultadoFinal;
            }
            }
            
            catch (Exception)
            {
                textBox1.Text = "ERROR";
            }

        }

        private void buttonParentesisD_Click(object sender, EventArgs e)
        {
            textBox1.Text += ") ";
        }

        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            textBox1.Text += "√(";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^(";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1÷(";
        }
    }
}
           
