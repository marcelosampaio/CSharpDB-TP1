namespace CSharpDBTP103.Services;

public class AreaService
{
    public double CalcularArea(double baseRetangulo, double altura)
    {
        Func<double, double, double> calcularArea =
            (baseRetangulo, altura) => baseRetangulo * altura;

        return calcularArea(baseRetangulo, altura);
    }
}