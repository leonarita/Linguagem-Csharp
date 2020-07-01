namespace _15_Interface_GUI
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.Conta = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Conta.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(223, 37);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(121, 22);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.TextChanged += new System.EventHandler(this.textoTitular_TextChanged);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(223, 91);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(121, 22);
            this.textoNumero.TabIndex = 1;
            this.textoNumero.TextChanged += new System.EventHandler(this.textoNumero_TextChanged);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(223, 144);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(121, 22);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(223, 198);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(121, 22);
            this.textoValor.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(240, 264);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(110, 40);
            this.botaoSaque.TabIndex = 5;
            this.botaoSaque.Text = "Sacar";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // Conta
            // 
            this.Conta.Controls.Add(this.label4);
            this.Conta.Controls.Add(this.label3);
            this.Conta.Controls.Add(this.label2);
            this.Conta.Controls.Add(this.label1);
            this.Conta.Controls.Add(this.button1);
            this.Conta.Controls.Add(this.textoValor);
            this.Conta.Controls.Add(this.botaoSaque);
            this.Conta.Controls.Add(this.textoSaldo);
            this.Conta.Controls.Add(this.textoTitular);
            this.Conta.Controls.Add(this.textoNumero);
            this.Conta.Location = new System.Drawing.Point(60, 28);
            this.Conta.Name = "Conta";
            this.Conta.Size = new System.Drawing.Size(467, 339);
            this.Conta.TabIndex = 6;
            this.Conta.TabStop = false;
            this.Conta.Text = "Conta";
            this.Conta.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 392);
            this.Controls.Add(this.Conta);
            this.Name = "Form1";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Conta.ResumeLayout(false);
            this.Conta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.GroupBox Conta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

