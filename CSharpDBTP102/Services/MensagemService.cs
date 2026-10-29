using CSharpDBTP102.Enums;

namespace CSharpDBTP102.Services;

public class MensagemService
{
    private static void ExibirBoasVindasPortugues(string mensagem)
    {
        Console.WriteLine("Bem-vindo!");
    }

    private static void ExibirBoasVindasIngles(string mensagem)
    {
        Console.WriteLine("Welcome!");
    }

    private static void ExibirBoasVindasEspanhol(string mensagem)
    {
        Console.WriteLine("¡Bienvenido!");
    }

    public void ExibirBoasVindas(Idioma idioma)
    {
        Action<string> acaoBoasVindas = idioma switch
        {
            Idioma.Ingles => ExibirBoasVindasIngles,
            Idioma.Espanhol => ExibirBoasVindasEspanhol,
            _ => ExibirBoasVindasPortugues
        };

        acaoBoasVindas(string.Empty);
    }
}