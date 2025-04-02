namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("====== Operadores Lógicos ======");

        bool isLogged = true;
        bool hasAdminAcces = false;

        Console.WriteLine("\nINformações do Usuário:");
        Console.WriteLine("Usuário logado: " + isLogged);
        Console.WriteLine("Acesso ao painel de administrador: " + hasAdminAcces);

        //Operador (||) - Ou

        if (isLogged || hasAdminAcces)
        {
            Console.WriteLine("Acesso ao sistema concedido!");
        }
        else
        {
            Console.WriteLine("Acesso ao sistema negado!");
        }

        //Operador (&&)

        if (isLogged && hasAdminAcces)
        {
            Console.WriteLine("Acesso ao painel de administrador concedido!");
        }
        else
        {
            Console.WriteLine("Acesso ao painel administrador negado!");
        }

        //Operador de Negação (!) "não..."

        if (!isLogged)
        {
            Console.WriteLine("Usuário não está logado!");
        }
        else
        {
            Console.WriteLine("Usuário está logado!");    
        }




    }
}