using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Csci340lab7.Data;
using Csci340lab7.Models;

namespace Csci340lab7.Pages.Avocados
{
    public class DeleteModel : PageModel
    {
        private readonly Csci340lab7.Data.Csci340lab7Context _context;

        public DeleteModel(Csci340lab7.Data.Csci340lab7Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Avocado Avocado { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Avocado = await _context.Avocado.FirstOrDefaultAsync(m => m.ID == id);

            if (Avocado == null)
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

            Avocado = await _context.Avocado.FindAsync(id);

            if (Avocado != null)
            {
                _context.Avocado.Remove(Avocado);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
