using CSharpDBTP102.Enums;
using CSharpDBTP102.Services;

namespace CSharpDBTP102;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Selecione o idioma:");
        Console.WriteLine("1 - Português (default)");
        Console.WriteLine("2 - Inglês");
        Console.WriteLine("3 - Espanhol");
        Console.Write("Opção: ");

        string? entrada = Console.ReadLine();

        Idioma idioma = int.TryParse(entrada, out int opcao) &&
                        Enum.IsDefined(typeof(Idioma), opcao)
            ? (Idioma)opcao
            : Idioma.Portugues;

        MensagemService mensagemService = new();

        mensagemService.ExibirBoasVindas(idioma);
    }
}