using System;
using System.Text;

namespace _60_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente()
            {
                Id = 10,
                Nome = "Macoratti",
                Endereco = "Rua Projetada, 100"
            };

            var produto = new Produto()
            {
                Id = 1,
                Nome = "Caderno",
                Descricao = "Caderno Espiral 100 folhas",
                Estoque = 100,
                Preco = 3.99M
            };

            var pedido = new Pedido()
            {
                Id = 1,
                ClienteId = 1,
                DataPedido = DateTime.Now
            };

            Console.WriteLine("***** Logando sem usar Reflection ****");
            LogarSemReflection(cliente, produto, pedido);

            Console.WriteLine(" ---------- Logando usando Reflection ----------");
            LogarUsandoReflection(cliente, produto, pedido);
            Console.ReadKey();
        }

        //Precisa ter uma função de log para cada classe
        public static void LogarSemReflection(Cliente cli, Produto prod, Pedido ped)
        {
            LogSemReflection.LogClientes(cli);
            LogSemReflection.LogProdutos(prod);
            LogSemReflection.LogPedidos(ped);
        }

        //Uma função consegue realizar log de todas as classes
        public static void LogarUsandoReflection(Cliente cli, Produto prod, Pedido ped)
        {
            LogComReflection.Log(cli);
            LogComReflection.Log(prod);
            LogComReflection.Log(ped);
        }
    }

    public class LogComReflection
    {
        //método genérico para criar um log /para qualquer classe
        public static void Log(object obj)
        {
            //obtem o tipo do objeto esse tipo não tem relação com a instância de obj
            var tipo = obj.GetType();

            StringBuilder builder = new StringBuilder();

            //obtem o nome do tipo
            builder.AppendLine("Log do " + tipo.Name);
            builder.AppendLine("Data: " + DateTime.Now);

            //Vamos obter agora todas as propriedades do tipo
            //Usamos o método GetProperties para obter o nome das propriedades do tipo
            foreach (var prop in tipo.GetProperties())
            {
                //usa a propriedade Name para obter o nome da propriedade e o método GetValue() para obter o valor da instância desse tipo
                builder.AppendLine(prop.Name + ": " + prop.GetValue(obj));
            }
            ImprimeLog(builder.ToString());
        }

        public static void ImprimeLog(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
