﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjPages.Models;

namespace ProjPages.Pages.Alunos
{
    public class DeleteModel : PageModel
    {
        private readonly ProjPages.Models.ApplicationDbContext _context;

        public DeleteModel(ProjPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Aluno Aluno { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aluno = await _context.Alunos.FirstOrDefaultAsync(m => m.Id == id);

            if (Aluno == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aluno = await _context.Alunos.FindAsync(id);

            if (Aluno != null)
            {
                _context.Alunos.Remove(Aluno);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
