using CSharpDBTP107.Services;

namespace CSharpDBTP107;

internal class Program
{
    private static void Main(string[] args)
    {
        Logger logger = new();

        Console.WriteLine("CENÁRIO 1 - Delegate associado\n");

        Action<string>? registrarLog = logger.LogToConsole;

        registrarLog += logger.LogToFile;
        registrarLog += logger.LogToDatabase;

        registrarLog?.Invoke("Sistema iniciado.");

        Console.WriteLine("\nCENÁRIO 2 - Delegate sem métodos associados\n");

        Action<string>? registrarLogVazio = null;

        registrarLogVazio?.Invoke("Teste sem métodos associados.");

        Console.WriteLine("Execução finalizada sem exceções.");
    }
}