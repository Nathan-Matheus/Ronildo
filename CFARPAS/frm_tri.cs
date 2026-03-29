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
    public partial class frm_tri : Form
    {
        double a, b, c;
        public frm_tri()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void imcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_imc frm_imc = new frm_imc();
            frm_imc.Show();
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

        private void btn1_Click(object sender, EventArgs e)
        {

           a = Convert.ToDouble(txt1.Text);
           b = Convert.ToDouble(txt2.Text);
           c = Convert.ToDouble(txt3.Text);
         
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("Não é um triângulo.");
            }

            
            if (a == b && b == c)
            {
                MessageBox.Show("Triângulo Equilátero");
            }
            else if (a == b || a == c || b == c)
            {
                MessageBox.Show("Triângulo Isósceles");
            }
            else
            {
                MessageBox.Show("Triângulo Escaleno");
            }
        }
    }
 }

