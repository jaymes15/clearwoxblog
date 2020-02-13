﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using clearwox.Data;
using clearwox.Models;

namespace clearwox
{
    public class DeleteModel : PageModel
    {
        private readonly clearwox.Data.clearwoxContext _context;

        public DeleteModel(clearwox.Data.clearwoxContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Blog Blog { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog = await _context.Blog.FirstOrDefaultAsync(m => m.ID == id);

            if (Blog == null)
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

            Blog = await _context.Blog.FindAsync(id);

            if (Blog != null)
            {
                _context.Blog.Remove(Blog);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
