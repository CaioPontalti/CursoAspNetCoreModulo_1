using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InjecaoDependencia.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InjecaoDependencia.Pages
{
    public class IndexModel : PageModel
    {
        public IEmailService EMailService { get; set; }

        public string Mensagem { get; set; }

        public IndexModel(IEmailService emailService)
        {
            EMailService = emailService;
        }

        public void OnGet()
        {
            Mensagem = EMailService.EnviarEmail();
        }
    }
}
