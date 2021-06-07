using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAL
{
    public partial class Form1 : Form
    {
       Calculadora calculadora = new Calculadora() ;
        string Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = "";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "9";
        }

        private void ButtonPunto_Click(object sender, EventArgs e)
        {
           
            if(!tbPantalla.Text.Contains( "."))
            {

                tbPantalla.Text = tbPantalla.Text + ".";
            }
        }


        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            if(tbPantalla.Text != "")
            {
                Operador = "/";
                calculadora.Numero1 = Convert.ToDouble(tbPantalla.Text) ;
                tbPantalla.Clear();
                Operador = ButtonDiv.Text;
                
            }
        }

        private void ButtonPor_Click(object sender, EventArgs e)
        {
            if (tbPantalla.Text != "")
            {
                Operador = "*";
                calculadora.Numero1 = Convert.ToDouble(tbPantalla.Text);
                tbPantalla.Clear();
                Operador = ButtonPor.Text;

            }
        }

        private void ButtonResta_Click(object sender, EventArgs e)
        {
            if (tbPantalla.Text != "")
            {
                Operador = "-";
                calculadora.Numero1 = Convert.ToDouble(tbPantalla.Text);
                tbPantalla.Clear();
                Operador = ButtonResta.Text;

            }

        }

        private void ButtonSuma_Click(object sender, EventArgs e)
        {
            if (tbPantalla.Text != "")
            {
                Operador = "+";
                calculadora.Numero1 = Convert.ToDouble(tbPantalla.Text);
                tbPantalla.Clear();
                Operador = ButtonSuma.Text;

            }
        }

        private void ButtonIgual_Click(object sender, EventArgs e)
        {
            calculadora.Numero2 = Convert.ToDouble(tbPantalla.Text);

            if (tbPantalla.Text != "")
            {
                switch (Operador)
                {
                    case "+":
                        tbPantalla.Text = Convert.ToString(calculadora.Sumar());
                        break;
                    case "-":
                        tbPantalla.Text = Convert.ToString(calculadora.Restar());
                        break;
                    case "*":
                        tbPantalla.Text = Convert.ToString(calculadora.Multiplicar());
                        break;
                    case "/":
                        if (calculadora.Numero2 == 0)
                        {
                            tbPantalla.Text = "error";
                        }
                        else
                        {
                            tbPantalla.Text = Convert.ToString(calculadora.Dividir());
                            
                        }
                        break;

                    default:
                     break;
                }
               
            }


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    Button0.PerformClick();
                    break;
                case "1":
                    Button1.PerformClick();
                    break;
                case "2":
                    Button2.PerformClick();
                    break;
                case "3":
                    Button3.PerformClick();
                    break;
                case "4":
                    Button4.PerformClick();
                    break;
                case "5":
                    Button5.PerformClick();
                    break;
                case "6":
                    Button6.PerformClick();
                    break;
                case "7":
                    Button7.PerformClick();
                    break;
                case "8":
                    Button8.PerformClick();
                    break;
                case "9":
                    Button9.PerformClick();
                    break;
                case "+":
                    ButtonSuma.PerformClick();
                    break;
                case "-":
                    ButtonResta.PerformClick();
                    break;
                case "/":
                    ButtonDiv.PerformClick();
                    break;
                case "*":
                    ButtonPor.PerformClick();
                    break;
                case ".":
                    ButtonPunto.PerformClick();
                    break;
                case "=":
                    ButtonIgual.PerformClick();
                    break;

                default:

                break; 
            }
        }
    }
}
