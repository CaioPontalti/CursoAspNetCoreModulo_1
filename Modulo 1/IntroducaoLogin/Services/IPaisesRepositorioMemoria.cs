using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoLogin.Services
{
    public interface IPaisesRepositorioMemoria
    {
        List<Models.Pais> ObterPaises();
    }
}
