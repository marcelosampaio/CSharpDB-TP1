using CSharpDBTP106.Services;

namespace CSharpDBTP106;

internal class Program
{
    private static void Main(string[] args)
    {
        Logger logger = new();

        Action<string> registrarLog = logger.LogToConsole;

        registrarLog += logger.LogToFile;
        registrarLog += logger.LogToDatabase;

        registrarLog("Sistema iniciado.");
    }
}