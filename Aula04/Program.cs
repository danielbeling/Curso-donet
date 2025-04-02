namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------ Cadastro do Usuario ------");

        //Solicitar o nome do Usuario
        Console.WriteLine("Escreva o seu nome: ");
        string name = Console.ReadLine();

        //Solicitar a idade do Usuario
        Console.WriteLine("Escreva sua Idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("--------------------------------");


         Console.WriteLine("Nome do Usuario: " + name);
         Console.WriteLine("Idade do Usuario: " + age);
    }
}