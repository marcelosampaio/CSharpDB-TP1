namespace CSharpDBTP101.Services;

public class DescontoService
{
    public delegate decimal CalculateDiscount(decimal price);

    public decimal AplicarDesconto(decimal preco)
    {
        CalculateDiscount calcularDesconto = CalcularDescontoDezPorCento;

        return calcularDesconto(preco);
    }

    private static decimal CalcularDescontoDezPorCento(decimal preco)
    {
        return preco * 0.90m;
    }
}