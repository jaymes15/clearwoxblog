using System;
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
    public class IndexModel : PageModel
    {
        private readonly clearwox.Data.clearwoxContext _context;

        public IndexModel(clearwox.Data.clearwoxContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; }

        public async Task OnGetAsync()
        {
            Blog = await _context.Blog.ToListAsync();
        }
    }
}
