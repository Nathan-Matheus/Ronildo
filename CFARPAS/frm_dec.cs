using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CFARPAS
{
    public partial class frm_dec : Form
    {
        double n1, n2, n3;

        private void btn1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txt1.Text);
            n2 = Convert.ToDouble(txt2.Text);
            n3 = Convert.ToDouble(txt3.Text);

            if (n1 > n2 && n2 > n3)
            {
                MessageBox.Show("Os números em ordem decrescente ficam: " + n1 +", " + n2 + ", " + n3 + ";");
            }
            if (n1 > n2 && n2 < n3)
            {
                MessageBox.Show("Os números em ordem decrescente ficam: " + n1 + ", " + n3 + ", " + n2 + ";");
            }
            if (n1 < n2 && n1 > n3)
            {
                MessageBox.Show("Os números em ordem decrescente ficam: " + n2 + ", " + n1 + ", " + n3 + ";");
            }
            if (n1 < n2 && n1 < n3)
            {
                MessageBox.Show("Os números em ordem decrescente ficam: " + n2 + ", " + n3 + ", " + n1 + ";");
            }
            if (n1 > n2 && n1 < n3)
            {
                MessageBox.Show("Os números em ordem decrescente ficam: " + n3 + ", " + n1 + ", " + n2 + ";");
            }
            else
            {
                MessageBox.Show("Os números em ordem decrescente ficam: " + n3 + ", " + n2 + ", " + n1 + ";");
            }

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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public frm_dec()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
