using System.Globalization;
using CSharpDBTP104.Models;
using CSharpDBTP104.Services;

namespace CSharpDBTP104;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

        TemperatureSensor sensor = new();
        TemperatureMonitorService monitorService = new();

        sensor.TemperatureExceeded += monitorService.OnTemperatureExceeded;

        double[] leiturasTemperatura = { 28, 29, 100, 109, 95, 125 };

        Console.WriteLine("Iniciando monitoramento de temperatura...\n");

        foreach (double temperatura in leiturasTemperatura)
        {
            Console.WriteLine($"Leitura do sensor: {temperatura:F2} °C");
            sensor.ReadTemperature(temperatura);
        }

        sensor.TemperatureExceeded -= monitorService.OnTemperatureExceeded;

        Console.WriteLine("\nMonitoramento finalizado.");
    }
}