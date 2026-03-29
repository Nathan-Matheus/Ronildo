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
    public partial class frm_ndd : Form
    {
        double idade;

        public frm_ndd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            idade = Convert.ToDouble(txt1.Text);
            if (idade >= 5 && idade <=7)
            {
                MessageBox.Show("Categoria: Infantil A");
            }
            if (idade >= 8 && idade <= 10)
            {
                MessageBox.Show("Categoria: Infantil B");
            }
            if (idade >= 11 && idade <= 13)
            {
                MessageBox.Show("Categoria: Juvenil A");
            }
            if (idade >= 14 && idade <= 17)
            {
                MessageBox.Show("Categoria: Juvenil B");
            }
            if (idade >= 18 && idade <= 25)
            {
                MessageBox.Show("Categoria: Sênior");
            }
            else
            {
                MessageBox.Show("Idade fora da faixa etária");
            }


        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void imcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_imc frm_imc = new frm_imc();
            frm_imc.Show();
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
