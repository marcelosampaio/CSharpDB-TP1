using CSharpDBTP108.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpDBTP108.Pages;

public class IndexModel : PageModel
{
    public List<Produto> Produtos { get; set; } = [];

    public void OnGet()
    {
        Produtos =
        [
            new Produto { Nome = "Teclado", Preco = 149.90m },
            new Produto { Nome = "Mouse", Preco = 79.90m },
            new Produto { Nome = "Monitor", Preco = 899.90m }
        ];
    }
}