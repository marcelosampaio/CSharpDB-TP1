using System.Globalization;
using CSharpDBTP103.Services;

namespace CSharpDBTP103;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo cultura = CultureInfo.GetCultureInfo("pt-BR");

        Console.Write("Informe a base do retângulo: ");
        string? entradaBase = Console.ReadLine();

        if (!TentarLerDimensao(entradaBase, cultura, out double baseRetangulo))
        {
            Console.WriteLine("Base inválida. Informe um número não negativo.");
            return;
        }

        Console.Write("Informe a altura do retângulo: ");
        string? entradaAltura = Console.ReadLine();

        if (!TentarLerDimensao(entradaAltura, cultura, out double altura))
        {
            Console.WriteLine("Altura inválida. Informe um número não negativo.");
            return;
        }

        AreaService areaService = new();

        double area = areaService.CalcularArea(baseRetangulo, altura);

        Console.WriteLine($"Área do retângulo: {area.ToString("N2", cultura)}");
    }

    private static bool TentarLerDimensao(
        string? entrada,
        CultureInfo cultura,
        out double dimensao)
    {
        dimensao = 0;

        return entrada != null
               && !entrada.Contains('.')
               && double.TryParse(
                   entrada,
                   NumberStyles.Number,
                   cultura,
                   out dimensao)
               && dimensao >= 0;
    }
}