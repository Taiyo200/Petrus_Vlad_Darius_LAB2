using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Petrus_Vlad_Darius_LAB2.Data;
using Petrus_Vlad_Darius_LAB2.Models;

namespace Petrus_Vlad_Darius_LAB2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Petrus_Vlad_Darius_LAB2.Data.Petrus_Vlad_Darius_LAB2Context _context;

        public IndexModel(Petrus_Vlad_Darius_LAB2.Data.Petrus_Vlad_Darius_LAB2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .Include(a => a.Author)
                    .ToListAsync();
            }
        }
    }
}
