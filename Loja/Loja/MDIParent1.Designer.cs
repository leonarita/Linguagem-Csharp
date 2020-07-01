namespace Loja
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastro,
            this.Estoque,
            this.Sobre});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(706, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // Cadastro
            // 
            this.Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(82, 24);
            this.Cadastro.Text = "Cadastro";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // Estoque
            // 
            this.Estoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.saídaToolStripMenuItem});
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(76, 24);
            this.Estoque.Text = "Estoque";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // saídaToolStripMenuItem
            // 
            this.saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            this.saídaToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.saídaToolStripMenuItem.Text = "Saída";
            // 
            // Sobre
            // 
            this.Sobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçõesDoSistemaToolStripMenuItem});
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(62, 24);
            this.Sobre.Text = "Sobre";
            // 
            // informaçõesDoSistemaToolStripMenuItem
            // 
            this.informaçõesDoSistemaToolStripMenuItem.Name = "informaçõesDoSistemaToolStripMenuItem";
            this.informaçõesDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.informaçõesDoSistemaToolStripMenuItem.Text = "Informações do Sistema";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 627);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(706, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 653);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIParent1";
            this.Text = "Cadastro de Usuários";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem Cadastro;
        private System.Windows.Forms.ToolStripMenuItem Estoque;
        private System.Windows.Forms.ToolStripMenuItem Sobre;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesDoSistemaToolStripMenuItem;
    }
}



