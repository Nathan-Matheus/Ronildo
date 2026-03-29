using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFARPAS
{
    public partial class frm_imc : Form
    {

        double peso, altura, imc;
        public frm_imc()
        {
            InitializeComponent();
        }

        private void frm_imc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nataçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ndd frm_ndd = new frm_ndd();
            frm_ndd.Show();
        }

        private void maiorEMenorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ler4num frm_ler4num = new frm_ler4num();
            frm_ler4num.Show();
        }

        private void decrescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_dec frm_dec = new frm_dec();
            frm_dec.Show();
        }

        private void polígonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_pol frm_pol = new frm_pol();
            frm_pol.Show();
        }

        private void triânguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_tri frm_tri = new frm_tri();
            frm_tri.Show();
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            altura = Convert.ToDouble(txt1.Text);
            peso = Convert.ToDouble(txt2.Text);

            imc = (peso / (altura * altura));

            if (imc <= 18.5)
            {
                MessageBox.Show("IMC: Muito magro!");
            }
            else if (imc > 18.5 && imc < 25)
            {
                MessageBox.Show("IMC: Normal!");
            }
            else if (imc > 25 && imc < 30)
            {
                MessageBox.Show("IMC: Sobrepeso!");
            }
            else if (imc >= 30 && imc < 35)
            {
                MessageBox.Show("IMC: Obesidade Grau 1!");
            }
            else if (imc > 35 && imc < 40)
            {
                MessageBox.Show("IMC: Obesidade severa!");
            }
            else if (imc >= 40)
            {
                MessageBox.Show("IMC: Obesidade mórbida!");
            }
        }
    }
}
