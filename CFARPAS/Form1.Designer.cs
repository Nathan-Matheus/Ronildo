namespace CFARPAS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nataçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maiorEMenorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polígonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triânguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Green;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbl1.Location = new System.Drawing.Point(48, 168);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(222, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Digite a primeira nota:";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txt1.Location = new System.Drawing.Point(53, 196);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(217, 23);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txt2.Location = new System.Drawing.Point(53, 283);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(217, 23);
            this.txt2.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Green;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbl2.Location = new System.Drawing.Point(48, 255);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(228, 25);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Digite a segunda nota:";
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txt3.Location = new System.Drawing.Point(48, 377);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(217, 23);
            this.txt3.TabIndex = 6;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Green;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbl3.Location = new System.Drawing.Point(48, 349);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(217, 25);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Digite a terceira nota:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Green;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblnome.Location = new System.Drawing.Point(48, 63);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(173, 25);
            this.lblnome.TabIndex = 7;
            this.lblnome.Text = "Digite seu nome.";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtnome.Location = new System.Drawing.Point(53, 91);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(168, 26);
            this.txtnome.TabIndex = 8;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(378, 415);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "Confirmar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imcToolStripMenuItem,
            this.nataçãoToolStripMenuItem,
            this.maiorEMenorToolStripMenuItem,
            this.decrescenteToolStripMenuItem,
            this.polígonoToolStripMenuItem,
            this.triânguloToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // imcToolStripMenuItem
            // 
            this.imcToolStripMenuItem.Name = "imcToolStripMenuItem";
            this.imcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imcToolStripMenuItem.Text = "imc";
            this.imcToolStripMenuItem.Click += new System.EventHandler(this.imcToolStripMenuItem_Click);
            // 
            // nataçãoToolStripMenuItem
            // 
            this.nataçãoToolStripMenuItem.Name = "nataçãoToolStripMenuItem";
            this.nataçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nataçãoToolStripMenuItem.Text = "natação";
            this.nataçãoToolStripMenuItem.Click += new System.EventHandler(this.nataçãoToolStripMenuItem_Click);
            // 
            // maiorEMenorToolStripMenuItem
            // 
            this.maiorEMenorToolStripMenuItem.Name = "maiorEMenorToolStripMenuItem";
            this.maiorEMenorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maiorEMenorToolStripMenuItem.Text = "maior e menor";
            this.maiorEMenorToolStripMenuItem.Click += new System.EventHandler(this.maiorEMenorToolStripMenuItem_Click);
            // 
            // decrescenteToolStripMenuItem
            // 
            this.decrescenteToolStripMenuItem.Name = "decrescenteToolStripMenuItem";
            this.decrescenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decrescenteToolStripMenuItem.Text = "decrescente";
            this.decrescenteToolStripMenuItem.Click += new System.EventHandler(this.decrescenteToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // polígonoToolStripMenuItem
            // 
            this.polígonoToolStripMenuItem.Name = "polígonoToolStripMenuItem";
            this.polígonoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.polígonoToolStripMenuItem.Text = "polígono";
            this.polígonoToolStripMenuItem.Click += new System.EventHandler(this.polígonoToolStripMenuItem_Click);
            // 
            // triânguloToolStripMenuItem
            // 
            this.triânguloToolStripMenuItem.Name = "triânguloToolStripMenuItem";
            this.triânguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.triânguloToolStripMenuItem.Text = "triângulo";
            this.triânguloToolStripMenuItem.Click += new System.EventHandler(this.triânguloToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nataçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maiorEMenorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polígonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triânguloToolStripMenuItem;
    }
}

