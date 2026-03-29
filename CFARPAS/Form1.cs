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
    public partial class Form1 : Form
    {
        double nota1, nota2, nota3, media;
        string nome;
        private void btn2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void imcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_imc frm_imc = new frm_imc();
            frm_imc.Show();
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

        private void btn1_Click(object sender, EventArgs e)
        {

          
            

            nota1 = Convert.ToDouble(txt1.Text);
            nota2 = Convert.ToDouble(txt2.Text);
            nota3 = Convert.ToDouble(txt3.Text);
            nome = txtnome.Text;

            media = (nota1 + nota2 + nota3) / 3;

            if (media >= 5)
            {
                MessageBox.Show("Aluno: " + nome +
                                "\nMédia: " + media +
                                "\nResultado: Aprovado!");
            }
            else
            {
                MessageBox.Show("Aluno: " + nome +
                                "\nMédia: " + media +
                                "\nResultado: Reprovado!");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
