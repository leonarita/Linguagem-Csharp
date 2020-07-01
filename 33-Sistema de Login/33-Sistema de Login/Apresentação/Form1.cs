using _33_Sistema_de_Login.Apresentação;
using _33_Sistema_de_Login.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_Sistema_de_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                    MessageBox.Show("Logado com sucesso!", "Acessando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Login não encontrado!: Verifique login e senha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(controle.mensagem, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
