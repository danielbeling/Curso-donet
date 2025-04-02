namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("======== Operadores de Atribuições ========");

        //Inicializar a variável
        int x = 10;
        Console.WriteLine("\nValor inicial da Variável X:  " + x);

        //Operador de Atribuição Simples (=)

        Console.WriteLine("\nAtribuição Simples (=)");
        Console.WriteLine("Valor de X: " + x);

        //Atribuição COmposta (incremento) (++)

        x++; //Equivale a x = x +1

        Console.WriteLine("\nAtribuição Composta Incremento (++)");

        Console.WriteLine("Novo Valor de x: " + x);
    }
}