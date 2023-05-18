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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio1>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["FrmExercicio1"].BringToFront();
            }

            else {
                FrmExercicio1 objEx1 = new FrmExercicio1();
                objEx1.MdiParent = this;
                objEx1.WindowState = FormWindowState.Maximized;
                objEx1.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio2>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["FrmExercicio2"].BringToFront();
            }

            else
            {
                FrmExercicio2 objEx2 = new FrmExercicio2();
                objEx2.MdiParent = this;
                objEx2.WindowState = FormWindowState.Maximized;
                objEx2.Show();
            }
        }
    }
}
