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

namespace Library.Pages.Admin.Language
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly Library.Data.ApplicationDbContext _context;

        public IndexModel(Library.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Library.Models.Language> Language { get;set; }

        public async Task OnGetAsync()
        {
            Language = await _context.Languages.ToListAsync();
        }
    }
}
