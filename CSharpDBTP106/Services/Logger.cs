namespace CSharpDBTP106.Services;

public class Logger
{
    public void LogToConsole(string mensagem)
    {
        Console.WriteLine($"[CONSOLE] {mensagem}");
    }

    public void LogToFile(string mensagem)
    {
        Console.WriteLine($"[ARQUIVO] {mensagem}");
    }

    public void LogToDatabase(string mensagem)
    {
        Console.WriteLine($"[BANCO DE DADOS] {mensagem}");
    }
}