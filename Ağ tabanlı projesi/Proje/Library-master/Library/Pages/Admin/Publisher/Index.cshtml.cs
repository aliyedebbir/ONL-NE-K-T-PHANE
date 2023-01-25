using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Authorization;

namespace Library.Pages.Admin.Publisher
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly Library.Data.ApplicationDbContext _context;

        public IndexModel(Library.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Library.Models.Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publishers.ToListAsync();
        }
    }
}
