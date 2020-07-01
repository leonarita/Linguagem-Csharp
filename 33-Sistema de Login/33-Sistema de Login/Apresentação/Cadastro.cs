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

namespace _33_Sistema_de_Login.Apresentação
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtLogin.Text, txtSenha.Text, txtConfirmar.Text);

            if (controle.tem)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!", "Acessando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(mensagem, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
