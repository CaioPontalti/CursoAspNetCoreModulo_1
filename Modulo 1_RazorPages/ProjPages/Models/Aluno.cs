using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjPages.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Display(Name ="Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        public bool Burro { get; set; }
    }
}
