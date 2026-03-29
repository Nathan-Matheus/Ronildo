namespace CFARPAS
{
    partial class frm_ndd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maiorEMenorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polígonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triânguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descubra sua categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(67, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite sua idade em anos";
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.White;
            this.txt1.Location = new System.Drawing.Point(72, 134);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(281, 20);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Categorias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imcToolStripMenuItem,
            this.médiaToolStripMenuItem,
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
            // médiaToolStripMenuItem
            // 
            this.médiaToolStripMenuItem.Name = "médiaToolStripMenuItem";
            this.médiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.médiaToolStripMenuItem.Text = "média";
            this.médiaToolStripMenuItem.Click += new System.EventHandler(this.médiaToolStripMenuItem_Click);
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
            // frm_ndd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CFARPAS.Properties.Resources.c0c62776ee0c0e317ed2286cf0f6bcf8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_ndd";
            this.Text = "frm_ndd";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maiorEMenorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polígonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triânguloToolStripMenuItem;
    }
}