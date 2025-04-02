namespace Aula08;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("====== Operadores Relacionais ======");
        Console.WriteLine("Digite o primeiro numero: ");

        int x = Convert.ToInt32 (Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        int y = Convert.ToInt32 (Console.ReadLine());

        string result;
        //Operador de Igualdade


        if (x == y)
        {
            result = "Os Valores são iguais!";
        }
        else
        {
            result = "Os valores são Diferentes";
        }
        Console.WriteLine("\nIgualdade (==) : " + result);
    }
}