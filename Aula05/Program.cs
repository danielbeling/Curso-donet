namespace Aula05;

public class Program
{
    public static void Main()
    {
        // int number1 = 10;
        // int number2 = 20;

        // int sum = number1 + number2;

        // Console.WriteLine("Soma dos numeros são: " + sum);

        Console.WriteLine("-----Calculadora em .NET-----");

        Console.WriteLine("Digite um numero: ");

        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite outro numero: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;

        Console.WriteLine("Soma dos valores é : " + sum);
    }
}