using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroducaoLogin.Data;
using IntroducaoLogin.Models;

namespace IntroducaoLogin.Services
{
    public class PaisesRepositorioBanco : IPaisesRepositorioMemoria
    {
        public ApplicationDbContext DbContext { get; set; }

        public PaisesRepositorioBanco(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public List<Models.Pais> ObterPaises()
        {
            return DbContext.Paises.ToList();
        }
    }
}
