using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty] //Propriedade que referencia a classe Pessoa e passa as propriedade via DataBinding direto no formulário
        public Pessoa Pessoa { get; set; }

        [BindProperty]
        public Cidade Cidade { get; set; }

        [TempData]
        public string Nome { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost(string parametro1)
        {
            Nome = parametro1;
            return RedirectToPage("teste/teste");//Redireciona para a pagina Contact
        }

        public void OnPostPessoa()
        {

        }

        public void OnPostPessoaCidade()
        {

        }
    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
    }
}
