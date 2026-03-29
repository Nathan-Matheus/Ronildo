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
    public partial class frm_pol : Form
    {
        int lados;
        double cm, area = 0;

        public frm_pol()
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

        private void triânguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_tri frm_tri = new frm_tri();
            frm_tri.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lados = Convert.ToInt32(txt1.Text);
            cm = Convert.ToDouble(txt2.Text);

            if (lados < 3)
            {
                MessageBox.Show("Não é um polígono");
            }

            else if (lados > 5)
            {
                MessageBox.Show("Polígono não identificado");
            }
            else
            {
                if (lados == 3)
                {
                    area = (cm * cm) / 2;
                    MessageBox.Show("Triângulo\nÁrea: " + area);
                }

                if (lados == 4)
                {
                    area = cm * cm;
                    MessageBox.Show("Quadrado\nÁrea: " + area);
                }

                if (lados == 5)
                {
                    area = cm * cm * 1.7;
                    MessageBox.Show("Pentágono\nÁrea: " + area);
                }

            }
        }
    }
}