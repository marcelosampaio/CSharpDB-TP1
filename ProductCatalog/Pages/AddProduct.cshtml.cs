using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductCatalog.Pages;

public class AddProductModel : PageModel
{
    [BindProperty]
    public string Nome { get; set; } = string.Empty;

    [BindProperty]
    public decimal Preco { get; set; }

    public bool ProdutoAdicionado { get; set; }

    public void OnPost()
    {
        ProdutoAdicionado = true;
    }
}