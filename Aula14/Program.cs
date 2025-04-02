using System.Runtime.CompilerServices;

namespace Aula14;

public class Program
{
    public static void Main()
    {
        //Ex1:
        //for (int i = 0; i < 10; i++)
        //{

        //    Console.WriteLine(i);
        //}

        //Ex2:
        Console.WriteLine("====== Tabela de Multiplicação ======");

        for (int i = 1; i <= 10; i++) // Percorre as linhas (1 a 10)
        {
            for (int j = 1; j <= 10; j++) // Percorre as colunas (1 a 10)
            {
                Console.Write($"{i * j}\t"); // Exibe o resultado com tabulação
            }
            Console.WriteLine(); // Quebra de linha ao final de cada linha da tabela
        }

    }
}