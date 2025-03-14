using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacioEvaluacionIIGabrielArevalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer los valores de los TextBox
            string input1 = textBox2.Text;
            string input2 = textBox1.Text;

            // Validar si los valores de los números son válidos
            if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
            {
                // Comparar los dos números
                if (num1 > num2)
                {
                    MessageBox.Show($"El número {num1} es mayor que {num2}");
                }
                else if (num1 < num2)
                {
                    MessageBox.Show($"El número {num2} es mayor que {num1}");
                }
                else
                {
                    MessageBox.Show($"Ambos números, {num1} y {num2}, son iguales");
                }
            }
            if (num1 < 0)
            {
                MessageBox.Show("Por favor ingrese números válidos en ambos campos.");
            }


        }

          private void label4_Click(object sender, EventArgs e)
        {

        }

          
          private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

          private void label3_Click(object sender, EventArgs e)
        {
  
        }
    }
}
