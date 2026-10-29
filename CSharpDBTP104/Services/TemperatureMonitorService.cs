namespace CSharpDBTP104.Services;

public class TemperatureMonitorService
{
    public void OnTemperatureExceeded(object? sender, double temperature)
    {
        Console.WriteLine(
            $"ALERTA: Temperatura acima do limite seguro! Leitura: {temperature:F2} °C");
    }
}