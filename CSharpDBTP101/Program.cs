using System.Globalization;
using CSharpDBTP101.Services;

namespace CSharpDBTP101;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo cultura = CultureInfo.GetCultureInfo("pt-BR");

        Console.Write("Informe o preço original do produto (ex.: 100,50): R$ ");

        string? entrada = Console.ReadLine();

        if (entrada == null ||
            entrada.Contains('.') ||
            !decimal.TryParse(
                entrada,
                NumberStyles.Number,
                cultura,
                out decimal precoOriginal) ||
            precoOriginal < 0)
        {
            Console.WriteLine("Preço inválido. Informe um valor numérico não negativo.");
            return;
        }

        DescontoService descontoService = new();

        decimal precoFinal = descontoService.AplicarDesconto(precoOriginal);

        Console.WriteLine();
        Console.WriteLine($"Preço original: {precoOriginal.ToString("C", cultura)}");
        Console.WriteLine("Desconto aplicado: 10%");
        Console.WriteLine($"Preço final: {precoFinal.ToString("C", cultura)}");
    }
}