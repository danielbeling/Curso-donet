namespace Aula11;

public class Program
{
    public static void Main()
    {
        //int number = 1;

        //switch (number)
        //{
        //    case 1:
        //        Console.WriteLine("O número é 1");
        //        break;

        //    case 2:
        //        Console.WriteLine("O número é igual a 2");
        //        break;
        //}

        //Console.WriteLine("========== Dia da Semana ==========");
        //Console.WriteLine("Digite um numero de 1 a 7:");
        //int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        //switch (dayOfWeek)
        //    {
        //    case 1:
        //        Console.WriteLine("O dia da semana é Domingo");
        //        break;
        //    case 2:
        //        Console.WriteLine("O dia da semana é Segunda-Feira");
        //        break;
        //    case 3:
        //        Console.WriteLine("O dia da semana é Terça-Feira");
        //        break;
        //    case 4:
        //        Console.WriteLine("O dia da semana é Quarta-Feira");
        //        break;
        //    case 5:
        //        Console.WriteLine("O dia da semana é Quinta-Feira");
        //        break;
        //    case 6:
        //        Console.WriteLine("O dia da semana é Sexta-Feira");
        //        break;
        //    case 7:
        //        Console.WriteLine("O dia da semana é Sábado");
        //        break;
        //    default:
        //         Console.WriteLine("Dia Invalido!");
        //         break;
        // }

        //EX3:

        Console.WriteLine("====== Desempenho Escolar ======");
        Console.WriteLine("Digite sua nota: ");
        int score = Convert.ToInt32(Console.ReadLine());

        switch (score)
        {
            case 10:
            case 9:
                Console.WriteLine("Otimo!");
                break;
            case 8:
            case 7:
                Console.WriteLine("Bom!");
                break;
            case 6:
                Console.WriteLine("Regular!");
                break;
            case 5:
                Console.WriteLine("Ruim!");
                break;
            default:
                Console.WriteLine("Horrivel!");
                break;
        }
    }
}