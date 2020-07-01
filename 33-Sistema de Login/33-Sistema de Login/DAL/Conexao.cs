using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Sistema_de_Login.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=NAOKI\SQLEXPRESS;Initial Catalog=BDCADASTRO;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            //Se a conexão estiver fechada
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();

            return con;
        }

        public void desconetar()
        {
            //Se a conexão estiver aberta
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
