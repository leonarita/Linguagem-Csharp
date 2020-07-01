using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35_Banco_de_Dados
{
    public partial class Form1 : Form
    {
        public static SqlDataReader dados;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(txtNome.Text, txtTelefone.Text);
            MessageBox.Show("Cadastro bem sucedido!", "Tudo ocorreu certo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {   con.ConnectionString = @"Data Source=NAOKI\SQLEXPRESS;Initial Catalog=BDCADASTRO;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            //Se a conexão estiver fechada
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();

            return con;
        }

        public void Desconetar()
        {
            //Se a conexão estiver aberta
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }

    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public string mensagem = "";

        public Cadastro(string nome, string telefone)
        {
            //Comando sql (comando em forma de texto)
            cmd.CommandText = "INSERT INTO exemplo (nome, telefone) VALUES (@nome, @telefone)";

            //Parâmetros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            try
            {
                //Conectar com o banco
                cmd.Connection = conexao.Conectar();

                //Executar o comando
                cmd.ExecuteNonQuery();

                //Desconectar com o banco
                conexao.Desconetar();

                //Mostrar a mensagem de erro ou sucesso
                this.mensagem = "Cadastro efetuado com sucesso!";

            }
            catch (Exception)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados!";
            }
        }
    }
}
