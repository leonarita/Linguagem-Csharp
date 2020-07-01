using System;

namespace _71_Structs
{
    class Program
    {
        //Requerem realocação de heap
        //Armazena a referência a um objeto alocado na memória
        //Chamado por new
        //Aloca dinamicamente um objeto no heap gerenciado e retorna uma referência a ele
        public class ClassePonto
        {
            public int x, y;

            public ClassePonto(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        //Estruturas de dados que podem conter dados e membros de ação
        //Alocadas na stack
        //São tipos de valor
        //Não requerem realocação de heap
        //Armazena diretamente os dados da estrutura
        //Chamado por new
        //Retorna o próprio valor struct (local temporária na stack)
        public struct StructPonto
        {
            public int x, y;

            public StructPonto(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        static void Main(string[] args)
        {
            ClassePonto[] ArrayClass = new ClassePonto[100];
            StructPonto[] ArrayStruct = new StructPonto[100];

            for (int i = 0; i < 99; i++)
            {
                ArrayClass[i] = new ClassePonto(i, i);
                ArrayStruct[i] = new StructPonto(i, i);
            }
        }
    }
}
