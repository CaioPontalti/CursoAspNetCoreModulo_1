﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjPages.Pages.teste
{
    public class testeModel : PageModel
    {
        [TempData]
        public string Nome { get; set; }

        public void OnGet()
        {

        }
    }
}