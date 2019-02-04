using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroducaoLogin.Models;

namespace IntroducaoLogin.Services
{
    public class PaisesRepositorioMemoria: IPaisesRepositorioMemoria
    {
        //public List<string> ObterPaises()
        //{
        //    List<string> Paises = new List<string>() { "Paises da lista fixa", "Brasil", "Portugal", "Estados Unidos" };
        //    return Paises;
        //}

        public List<Pais> ObterPaises()
        {
            List<Pais> Paises = new List<Pais>()
            {
                //new Pais("BrasilManual"),
                //new Pais("CanadáManual")
            };

            return Paises;
        }
    }
}
