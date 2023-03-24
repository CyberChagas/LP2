using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
    double raio, altura, volume; // Variáveis globais

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if(!Double.TryParse(textBox2.Text, out altura))
            {
                MessageBox.Show("Altura inválida");
            }
            else
                if (altura <= 0)
            {
                MessageBox.Show("Altura deve ser maior que zero");
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((!double.TryParse(textBox1.Text, out raio)) || (!double.TryParse(textBox2.Text, out altura)))
            {
                MessageBox.Show("Valores inválidos");
            }
            else {
                if((altura<=0) || (raio <= 0)){
                    MessageBox.Show("Valores não podem ser menores que zero");
                }
                else
                {
                    volume = Math.PI*Math.Pow(raio, 2) * altura;
                    textBox3.Text = volume.ToString("N2");
                }
            }
        }

        private void TextBox1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out raio))
            {
                MessageBox.Show("Raio inválido");
                textBox1.Focus();
            }
            else
            {
                if (raio <= 0)
                {
                    MessageBox.Show("Raio deve ser maior que zero");
                }
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
