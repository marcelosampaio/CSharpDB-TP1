namespace CSharpDBTP111.Services;

public class StringProcessor
{
    public string ConcatenarNomeSobrenome(string nome, string sobrenome)
    {
        Console.WriteLine("Executando: ConcatenarNomeSobrenome");

        return $"{nome} {sobrenome}";
    }

    public string ConverterParaMaiusculas(string nome, string sobrenome)
    {
        Console.WriteLine("Executando: ConverterParaMaiusculas");

        return $"{nome} {sobrenome}".ToUpper();
    }

    public string RemoverEspacos(string nome, string sobrenome)
    {
        Console.WriteLine("Executando: RemoverEspacos");

        return $"{nome} {sobrenome}".Replace(" ", "");
    }
}