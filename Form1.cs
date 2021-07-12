using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Calculadora
{
    public partial class Form1 : Form
    {
        string operador;
        double val1, val2, resultado;
        Boolean ban_btn = true, ban_num = true, ban_ope = true;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn0_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                txtPantalla.Clear();
                txtPantalla.Text = "0";
                ban_num = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "0";
            }
            ban_btn = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                txtPantalla.Clear();
                txtPantalla.Text = "1";
                ban_num = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }
            ban_btn = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                txtPantalla.Clear();
                txtPantalla.Text = "2";
                ban_num = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
            ban_btn = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                txtPantalla.Clear();
                txtPantalla.Text = "3";
                ban_num = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "3";
            }
            ban_btn = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                txtPantalla.Clear();
                txtPantalla.Text = "4";
                ban_num = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "4";
            }
            ban_btn = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                txtPantalla.Clear();
                txtPantalla.Text = "5";
                ban_num = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
            ban_btn = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                txtPantalla.Clear();
                txtPantalla.Text = "6";
                ban_num = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
            ban_btn = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                txtPantalla.Clear();
                txtPantalla.Text = "7";
                ban_num = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
            ban_btn = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                txtPantalla.Clear();
                txtPantalla.Text = "8";
                ban_num = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "8";
            }
            ban_btn = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                txtPantalla.Clear();
                txtPantalla.Text = "9";
                ban_num = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }
            ban_btn = false;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ".";
            operador = operador + ".";
            btnPunto.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            ban_num = true;
            ban_ope = true;
            ban_btn = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(ban_btn == false)
            {
                if(ban_ope == false)
                {
                    val2 = Convert.ToDouble(txtPantalla.Text);
                    operaciones(operador);
                    ban_num = true;
                    ban_btn = true;
                    ban_ope = true;
                }
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            ban_num = true;
            if (ban_ope)
            {
                val1 = Convert.ToDouble(txtPantalla.Text);
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    val2 = Convert.ToDouble(txtPantalla.Text);
                    operaciones(operador);
                    val1 = Convert.ToDouble(txtPantalla.Text);
                    ban_num = true;
                    ban_btn = true;
                }
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "x";
            ban_num = true;
            if (ban_ope)
            {
                val1 = Convert.ToDouble(txtPantalla.Text);
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    val2 = Convert.ToDouble(txtPantalla.Text);
                    operaciones(operador);
                    val1 = Convert.ToDouble(txtPantalla.Text);
                    ban_num = true;
                    ban_btn = true;
                }
            }
        }

        private void btnPositivoNegativo_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(txtPantalla.Text);
            n = ((n) * (-1));
            txtPantalla.Text = n.ToString();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(txtPantalla.Text);
            val1 = (val1 * val1);
            txtPantalla.Text = val1.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(txtPantalla.Text);
            val1 = Math.Sqrt(val1);
            txtPantalla.Text = val1.ToString();
        }

        private void btn1sobreX_Click(object sender, EventArgs e)
        {
            decimal val1 = Convert.ToDecimal(txtPantalla.Text);
            val1 = (1 / val1);
            txtPantalla.Text = val1.ToString();
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            decimal val1 = Convert.ToDecimal(txtPantalla.Text);
            val1 = val1 * val1 / 100;
            txtPantalla.Text = val1.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            ban_num = true;
            if (ban_ope)
            {
                val1 = Convert.ToDouble(txtPantalla.Text);
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    val2 = Convert.ToDouble(txtPantalla.Text);
                    operaciones(operador);
                    val1 = Convert.ToDouble(txtPantalla.Text);
                    ban_num = true;
                    ban_btn = true;
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtPantalla.TextLength >0)
            {
                txtPantalla.Text = txtPantalla.Text.Remove(txtPantalla.Text.Length - 1);
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            ban_num = true;
            if (ban_ope)
            {
                val1 = Convert.ToDouble(txtPantalla.Text);
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    val2 = Convert.ToDouble(txtPantalla.Text);
                    operaciones(operador);
                    val1 = Convert.ToDouble(txtPantalla.Text);
                    ban_num = true;
                    ban_btn = true;
                }
            }
        }
        private Double operaciones(string operacion)
        {
            switch (operador)
            {
                case "+":
                    resultado = val1 + val2;
                    break;
                case "-":
                    resultado = val1 - val2;
                    break;
                case "x":
                    resultado = val1 * val2;
                    break;
                case "/":
                    resultado = val1 / val2;
                    break;
            }

            txtPantalla.Text = resultado.ToString();
            return resultado;
        }
    }
}
