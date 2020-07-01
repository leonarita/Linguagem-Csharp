using System;

namespace _73_Enum
{
    //Conjunto de constantes/valores discretos
    //Ao não declarar explicitamente um tipo, é int
    enum Cor
    {
        Vermelho,
        Verde,
        Azul
    }

    enum Alinhamento : sbyte
    {
        Esquerda = -1,
        Centro = 0,
        Direita = 1
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cor cor = Cor.Azul;
            EscreverCor(cor);
        }

        static void EscreverCor (Cor c)
        {
            switch (c)
            {
                case Cor.Vermelho:
                    Console.WriteLine("Vermelho");
                    break;

                case Cor.Verde:
                    Console.WriteLine("Verde");
                    break;

                case Cor.Azul:
                    Console.WriteLine("Azul");
                    break;
            }
        }
    }
}
