namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Verificador de Numeros");

        Console.WriteLine("Digite um numero: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = number % 2;

        if (result == 0) {
            Console.WriteLine("Numero digitado é par!");
        } else
        {
            Console.WriteLine("Numero digitado é Impar!");
        }
    }
}