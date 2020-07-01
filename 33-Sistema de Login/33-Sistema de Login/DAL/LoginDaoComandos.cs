using _33_Sistema_de_Login.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Sistema_de_Login.Modelo
{
    class LoginDaoComandos
    {
        public bool tem=false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin (String login, String senha)
        {
            //Comandos SQL para verificar se tem no banco

            cmd.CommandText = "SELECT * FROM logins WHERE email=@login and senha=@senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();

                //Armazenar os dados buscados do insert no dr
                dr =  cmd.ExecuteReader();

                //Se encontrar a linha solicitada
                if (dr.HasRows)
                {
                    tem = true;
                }

                con.desconetar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }

            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            tem = false;

            //comandos para cadastrar

            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "INSERT INTO logins VALUES (@e, @s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();

                    //Armazenar os dados buscados do insert no dr
                    cmd.ExecuteNonQuery();

                    con.desconetar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados!";
                }
            }
            else
                this.mensagem = "Senhas não correspondem!";

            //Comandos para inserir
            return mensagem;
        }
    }
}
