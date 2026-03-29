namespace CFARPAS
{
    partial class frm_imc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nataçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maiorEMenorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polígonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triânguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(562, 386);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Calcular";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(104, 261);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(264, 20);
            this.txt2.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(104, 190);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(264, 20);
            this.txt1.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Green;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lbl1.Location = new System.Drawing.Point(-7, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(701, 38);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Digite suas informações para calcular seu IMC.";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Green;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbl2.Location = new System.Drawing.Point(101, 159);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(273, 25);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Digite sua Altura (ex: 1,70):";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Green;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbl3.Location = new System.Drawing.Point(101, 230);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(267, 25);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Digite seu Peso em quilos:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médiaToolStripMenuItem,
            this.nataçãoToolStripMenuItem,
            this.maiorEMenorToolStripMenuItem,
            this.decrescenteToolStripMenuItem,
            this.polígonoToolStripMenuItem,
            this.triânguloToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // médiaToolStripMenuItem
            // 
            this.médiaToolStripMenuItem.Name = "médiaToolStripMenuItem";
            this.médiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.médiaToolStripMenuItem.Text = "média";
            this.médiaToolStripMenuItem.Click += new System.EventHandler(this.médiaToolStripMenuItem_Click);
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
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // decrescenteToolStripMenuItem
            // 
            this.decrescenteToolStripMenuItem.Name = "decrescenteToolStripMenuItem";
            this.decrescenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decrescenteToolStripMenuItem.Text = "decrescente";
            this.decrescenteToolStripMenuItem.Click += new System.EventHandler(this.decrescenteToolStripMenuItem_Click);
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
            // frm_imc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CFARPAS.Properties.Resources.b5d28e9438acd6e00c1da3a7c841af85;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_imc";
            this.Text = "frm_imc";
            this.Load += new System.EventHandler(this.frm_imc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nataçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maiorEMenorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polígonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triânguloToolStripMenuItem;
    }
}