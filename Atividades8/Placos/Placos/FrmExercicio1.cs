using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placos
{
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEspacoBranco_Click(object sender, EventArgs e)
        {
            string Branco = rtbFrase1.Text;
            int vezes = 0;
            int i = 0;

            while (i < Branco.Length){
                if (Branco[i] == ' ')
                {
                    vezes++;
                }
                i++;
            }

            MessageBox.Show($"A frase tem {vezes} espaços em branco!");
        }

        private void BtnLetraR_Click(object sender, EventArgs e)
        {
            string frase = rtbFrase1.Text;
            int contagem = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'R' || frase[i] == 'r')
                {
                    contagem++;
                }
            }

            MessageBox.Show($"A letra 'R' aparece {contagem} vezes na frase.");
;
        }

        private void BtnPar_Click(object sender, EventArgs e)
        {
            int i = 0;
            int contagem = 0;
            string teste = rtbFrase1.Text;
            string teste2 = teste.ToLower();
            do
            {
                if(teste2[i] == teste2[i+1])
                {
                    contagem++;
                }
                i++;
            } while (i < (rtbFrase1.TextLength-1));
            MessageBox.Show($"A frase {teste} contem {contagem} pares de letras.");
        }
    }
}
