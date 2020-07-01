using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Interface_GUI
{
    public partial class Form1 : Form
    {
        private Conta c;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // carregue os campos de seu formulário aqui

            //Inicia os valores
            this.c = new Conta();
            this.c.Numero = 1;
            Cliente cliente = new Cliente("victor");
            this.c.Titular = cliente;

            //Exibe os dados iniciais acima nos Entry 
            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);
            textoTitular.Text = this.c.Titular.Nome;
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;                     //Pega o que foi digitado
            double valorOperacao = Convert.ToDouble(valorDigitado);     //Converte para Double
            this.c.Deposita(valorOperacao);                             //Faz depositar o valor na conta
            textoSaldo.Text = Convert.ToString(this.c.Saldo);           //Exibe o saldo final
            MessageBox.Show("Sucesso");                                 //Exibe mensagem de sucesso
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;                     //Pega o que foi digitado
            double valorOperacao = Convert.ToDouble(valorDigitado);     //Converte para Double
            this.c.Saca(valorOperacao);                                 //Faz sacar o valor na conta
            textoSaldo.Text = Convert.ToString(this.c.Saldo);           //Exibe o saldo final
            MessageBox.Show("Sucesso");                                 //Exibe mensagem de sucesso
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
