using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoLogin.ViewComponents
{
    public class PaisesViewComponent : ViewComponent
    {
        public Services.IPaisesRepositorioMemoria Rep { get; set; }

        public PaisesViewComponent(Services.IPaisesRepositorioMemoria rep)
        {
            Rep = rep;
        }

        public IViewComponentResult Invoke()
        {
            var paises = Rep.ObterPaises();
            return View(paises);
         }
    }
}
