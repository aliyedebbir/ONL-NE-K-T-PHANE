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

namespace Library.Pages.Admin.Book
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly Library.Data.ApplicationDbContext _context;

        public IndexModel(Library.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Library.Models.Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.Category)
                .Include(b => b.Language)
                .Include(b => b.Publisher).ToListAsync();
        }
    }
}
