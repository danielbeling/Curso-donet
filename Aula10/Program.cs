namespace Aula10;

public class Program
{
    public static void Main()
    {
        bool varContinue = true;

        while (varContinue)
        {
            //Inicialização do programa
            Console.WriteLine("========== Calculadora Simples ==========\n");
            Console.WriteLine("Digite o Primeiro Numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Selecionar o tipo de operação

            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1: Adição (+)");
            Console.WriteLine("2: Subtração (-)");
            Console.WriteLine("3: Multiplicação (*)");
            Console.WriteLine("4: Divisão (/)");
            Console.WriteLine("Digite o número da operação: ");

            int operation = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            //Condições

            if (operation == 1)
            {
                result = num1 + num2;
            }
            else if (operation == 2)
            {
                result = num1 - num2;
            }
            else if (operation == 3)
            {
                result = num1 * num2;
            }
            else if (operation == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Não é possivel dividir um numero por 0");
                }
            }
            else
            {
                Console.WriteLine("Operação Invalida!");
            }

            Console.WriteLine("\nResultado: " + result + "\n");


            Console.WriteLine("\nDeseja Continuar outra operação (S/N) ?");

            string response = Console.ReadLine();

            if (response != "s")
            {
                varContinue = false;
            }
        }
        Console.WriteLine("Obrigado por utilizar a calculadora simples!");
    }
}