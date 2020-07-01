using System;
using System.Reflection;

namespace _61_Reflexão
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 10;
            string texto = "DevMedia";
            float Flutuante = 10.2f;

            Type Tipo = null;
            Tipo = inteiro.GetType();
            Console.WriteLine(Tipo.Name);
            Console.WriteLine(texto.GetType().Name);
            Console.WriteLine(Flutuante.GetType().Name);
            Console.WriteLine(Flutuante.GetType());

            Console.Read();

            //Capturar uma classe dentro do namespace
            var animaisType = Type.GetType("Terra.Animais");

            //Captura o type da classe e cria um instância (sem o new)
            Type humanoType = typeof(Humano);
            object newHuman = Activator.CreateInstance(humanoType);

            //Carregar o Assembly
            var Assembly = typeof(Humano).Assembly;

            //Usando o método GetProperties
            PropertyInfo[] properties = humanoType.GetProperties();
            foreach (var propertyInfo in properties)
                Console.WriteLine(propertyInfo.Name);

            //Capturando uma propriedade com GetProperty
            PropertyInfo property = humanoType.GetProperty("Idade");
            Console.WriteLine(property.GetValue(newHuman, null));

            //Atribuindo valores usando o SetValue
            PropertyInfo propertySet = humanoType.GetProperty("Idade");
            propertySet.SetValue(newHuman, 23, null);
            Console.WriteLine(propertySet.GetValue(newHuman, null));

            //Acessar métodos públicos
            humanoType.InvokeMember("Respirar", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance, null, newHuman, null);
            humanoType.InvokeMember("Piscar", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance, null, newHuman, null);
            humanoType.InvokeMember("SentirFome", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance, null, newHuman, null);

            //Acessar métodos privados
            humanoType.InvokeMember("CantarNoBanheiro", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic, null, newHuman, null);
            humanoType.InvokeMember("PensarAlgo", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, null, newHuman, new object[] { "em viajar.", DateTime.Now });

        }
    }

    public class Humano
    {
        private string TipoSanguineo { get; set; }
        public int Idade { get; set; }
        public int Altura { get; set; }
        public Double Peso { get; set; }
        public string Nome { get; set; }

        public void Piscar()
        {
            Console.WriteLine("Piscar os olhos agora.");
        }
        public void Respirar()
        {
            Console.WriteLine("Repirar 1...2...3");
        }
        public void PensarAlgo(string pensamentos, DateTime quando)
        {
            Console.WriteLine("Estou pensando em : " + pensamentos + " pensei nisso agora : " + quando.ToShortTimeString());
        }

        public void SentirFome()
        {
            Console.WriteLine("Estou ficando com fome. Hora do Lanche.");
        }
        private void CantarNoBanheiro()
        {
            Console.WriteLine("Bla ... Bla ... Bla ...");
        }
    }
}
