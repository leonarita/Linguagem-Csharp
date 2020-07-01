using System;

namespace _38_Módulos_no_curso_de_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] basic =
            {
                "Aula 01 - Introdução e Apresentação do Curso",
                "Aula 02 - Alocação de memória em .NET",
                "Aula 03 - Referenciando Objetos",
                "Aula 04 - Assessores e Propriedades",
                "Aula 05 - Construtores e Overloads",
                "Aula 06 - Métodos Assessores",
                "Aula 07 - Assessores e Propriedades",
                "Aula 08 - Propriedades Automáticas",
                "Aula 09 - Inicializadores de Objetos",
                "Aula 10 - Tipos de Inferências",
                "Aula 11 - Classes - Membros Estáticos e de Instância",
                "Aula 12 - Classes e Métodos de Extensão",
                "Aula 13 - Classes Parciais",
                "Aula 14 - Criando Classes Genéricas",
                "Aula 15 - Parâmetros Nomeados",
                "Aula 16 - Parâmetros Opcionais",
                "Aula 17 - Sobrecarga de Métodos (Overload)",
                "Aula 18 - Propriedades Indexadas",
                "Aula 19 - Sobrecarga de Métodos (Override)",
                "Aula 20 - Aplicando a Sobrecarga de Métodos (Override)",
                "Aula 21 - Entendendo o processo de Delegação em C#",
                "Aula 22 - Eventos e Delegação",
                "Aula 23 - Eventos e Métodos",
                "Aula 24 - Definindo Delegates",
                "Aula 25 - AnonymousMethods e Delegates",
                "Aula 26 - Lambdas e Parameters",
                "Aula 27 - ActionDelegate",
                "Aula 28 - Predicate Delegate",
                "Aula 29 - Func Delegate"
            };

            string[] intermediary =
            {
                "Aula 30 - Introdução à Exceptions",
                "Aula 31 - Tratamento Estruturado de Exceções",
                "Aula 32 - Tratamento Exceções pelo Tipo",
                "Aula 33 - Instâncias de Exceção",
                "Aula 34 - Propagando Exceptions com Throw",
                "Aula 35 - Criando Custom Exceptions",
                "Aula 36 - Introdução à Interfaces em C#",
                "Aula 37 - Interfaces e Classes Abstratas",
                "Aula 38 - Implementando várias interfaces",
                "Aula 39 - Implementando IDisposable",
                "Aula 40 - Implementando IEnumerable",
                "Aula 41 - ArrayList",
                "Aula 42 - ListT",
                "Aula 43 - HashTable",
                "Aula 44 - Dictionary",
                "Aula 45 - Stack",
                "Aula 46 - Queue (filas)",
                "Aula 47 - Type Casting",
                "Aula 48 - Diretivas de Compilação",
                "Aula 49 - Assemblies",
                "Aula 50 - Namespaces"
            };

            string[] advanced =
            {
                "Aula 51 - Introdução à LINQ",
                "Aula 52 - LINQ Providers e Standard Query Operators",
                "Aula 53 - Expressões de consulta LINQ",
                "Aula 54 - Cláusulas from, select e tipos anônimos",
                "Aula 55 - Cláusulas let, orderby, ascending e descending",
                "Aula 56 - Curso C#: Cláusula where",
                "Aula 57 - Cláusulas group, by e into",
                "Aula 58 - Group composto",
                "Aula 59 - Cláusulas join, in, on e equals",
                "Aula 60 - Task, Async e Awai",
                "Aula 61 - Curso de C#: Reflexão de Classes",
                "Aula 62 - Reflexão em Métodos",
                "Aula 63 - Invocando Métodos e Construtores em RunTime",
                "Aula 64 - Curso de C#: StringBuilder",
                "Aula 65 - StringWriter e StringReader",
                "Aula 66 - DriveInfo",
                "Aula 67 - ZipFile",
                "Aula 68 - StreamReader e FileStream",
                "Aula 69 - FileInfo",
                "Aula 70 - Debug",
                "Aula 71 - Código Fonte - Curso de C# Avançado"
            };

            Console.WriteLine("\n\n\t\t\tC# Básico\n");
            foreach (string i in basic)
            {   Console.WriteLine($"\t{i}");
            }

            Console.WriteLine("\n\n\t\t\tC# Intermediário\n");
            foreach (string i in intermediary)
            {
                Console.WriteLine($"\t{i}");
            }

            Console.WriteLine("\n\n\t\t\tC# Avançado\n");
            foreach (string i in advanced)
            {
                Console.WriteLine($"\t{i}");
            }

            Console.ReadKey();
        }
    }
}
