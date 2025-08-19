using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estão preenchidos:
            if(txbPeso.Text == "")
            {
                MessageBox.Show("Digite o Peso: ",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(txbAltura.Text == "") 
            {
                MessageBox.Show("Digite a Altura: ",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // Declarar os valores do TextBox:
            double peso = double.Parse(txbPeso.Text);
            double altura = double.Parse(txbAltura.Text);

            // Cálculo do IMC:
            double imc = peso / (altura * altura);

            // Resultado do IMC:

            if (imc < 18.5) { 
                    lblResultado.Text = "Abaixo do peso";
                lblResultado.ForeColor = Color.Yellow;
            }
            else if (imc < 24.9)
            {
                lblResultado.Text = "Peso ideal";
                lblResultado.ForeColor = Color.Green;
            } 
            else if (imc < 29.9)
            {
                lblResultado.Text = "Levemente acima do peso";
                lblResultado.ForeColor = Color.Orange;
            }
            else if (imc < 34.9)
            {
                lblResultado.Text = "Obesidade Grau I";
                lblResultado.ForeColor= Color.OrangeRed;
            }
            else if (imc < 39.9)
            {
                lblResultado.Text = "Obesidade Grau II";
                lblResultado.ForeColor = Color.DarkRed;
            }
            else if (imc > 40.0)
            {
                lblResultado.Text = "Obesidade Grau III";
                lblResultado.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.",
                               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Mostrar o resultado:
            txbIMC.Text = imc.ToString();
              





           
                   
            

           
               
        }
    }
}
