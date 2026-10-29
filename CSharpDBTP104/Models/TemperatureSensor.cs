namespace CSharpDBTP104.Models;

public class TemperatureSensor
{
    public event EventHandler<double>? TemperatureExceeded;

    public void ReadTemperature(double temperature)
    {
        if (temperature > 100)
        {
            TemperatureExceeded?.Invoke(this, temperature);
        }
    }
}