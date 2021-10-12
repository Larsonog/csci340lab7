using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Csci340lab7.Data;
using Csci340lab7.Models;

namespace Csci340lab7.Pages.Avocados
{
    public class EditModel : PageModel
    {
        private readonly Csci340lab7.Data.Csci340lab7Context _context;

        public EditModel(Csci340lab7.Data.Csci340lab7Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Avocado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvocadoExists(Avocado.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AvocadoExists(int id)
        {
            return _context.Avocado.Any(e => e.ID == id);
        }
    }
}
