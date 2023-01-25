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
    public class DetailsModel : PageModel
    {
        private readonly Library.Data.ApplicationDbContext _context;

        public DetailsModel(Library.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Library.Models.Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publishers.FirstOrDefaultAsync(m => m.PublisherId == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
