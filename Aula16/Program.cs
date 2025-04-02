namespace Aula16;

public class Program
{
    public static void Main()
    {
        string separator = "------------------";

        //1. Declaração de Array
        string[] fruits = { "Maçã, ", "Banana", "Caju", "Manga" };

        //2. Acessar os valores
        Console.WriteLine(fruits[1]);
        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine(separator);

        //3. Contagem de Indices
        Console.WriteLine("Quantidade de Índices: " + fruits.Length);

        //4. Alterar os Valores
        fruits[1] = "Abacaxi";
        Console.WriteLine(fruits[1]);

       
    }
}