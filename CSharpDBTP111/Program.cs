using CSharpDBTP111.Services;

namespace CSharpDBTP111;

internal class Program
{
    private static void Main(string[] args)
    {
        StringProcessor processor = new();

        Func<string, string, string> processarNome =
            processor.ConcatenarNomeSobrenome;

        processarNome += processor.ConverterParaMaiusculas;
        processarNome += processor.RemoverEspacos;

        string resultado = processarNome("Marcelo", "Sampaio");

        Console.WriteLine();
        Console.WriteLine($"Resultado retornado: {resultado}");
    }
}