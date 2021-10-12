using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Csci340lab7.Data;
using Csci340lab7.Models;

namespace Csci340lab7.Pages.Avocados
{
    public class CreateModel : PageModel
    {
        private readonly Csci340lab7.Data.Csci340lab7Context _context;

        public CreateModel(Csci340lab7.Data.Csci340lab7Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Avocado Avocado { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Avocado.Add(Avocado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
