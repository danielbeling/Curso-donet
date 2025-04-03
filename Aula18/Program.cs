namespace Aula18;

using System.IO;

public class Program
{
    public static void Main()
    {
        ////1. Criar um arquivo
        //string content = "Olá Mundo!";
        //System.IO.File.WriteAllText("file.txt", content);
        //Console.WriteLine("Arquivo Criado com Sucesso!");

        //2. Criar arquivo em um lugar especifico

        //string path = @"C:\\Users\\Daniel\\Desktop\\dotnet\\Aula18\filename.txt";
        //string content = "Olá Mundo!";
        //File.WriteAllText(path, content);
        //Console.WriteLine("Arquivo Criado com Sucesso!");

        //3. Criar arquivo word
        //string path = @"C:\\Users\\Daniel\\Desktop\\dotnet\\Aula18\";
        //string fileName = "myDocument.Doc";
        //string filePath = path + fileName;

        //string content = "Olá Mundo!";
        //File.WriteAllText(filePath, content);
        //Console.WriteLine("Arquivo Criado com Sucesso!");

        //4. Inserir um paragrafo em um arquivo

        string path = @"C:\\Users\\Daniel\\Desktop\\dotnet\\Aula18\";
        string fileName = "myDocument.Doc";
        string filePath = path + fileName;

        string additionalContent = "Estudando C# e .NET";

        File.AppendAllText(filePath, additionalContent);

        Console.WriteLine("Texto adicional criado com Sucesso!");

        //5. Ler o arquivo

        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("Conteudo do Arquivo: " + fileContent);

    }
}