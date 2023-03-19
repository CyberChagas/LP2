using System.Security.Cryptography.Xml;

namespace Exercicio_de_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== (char)(13)) {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            // endereço
            if((textBox2.Text=="") || (textBox2.Text.Length < 15)){
                MessageBox.Show("Endereço Inválido");
                textBox2.Focus();
            }
        }

        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // email
            if (textBox3.Text == "")
            {
                MessageBox.Show("E-mail vazio");
                e.Cancel = true;
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Celular perdeu o foco");
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("CPF ganhou o foco");
        }
    }
}