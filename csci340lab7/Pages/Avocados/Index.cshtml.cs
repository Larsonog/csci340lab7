using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Csci340lab7.Data;
using Csci340lab7.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Csci340lab7.Pages.Avocados
{
    public class IndexModel : PageModel
    {
        private readonly Csci340lab7.Data.Csci340lab7Context _context;

        public IndexModel(Csci340lab7.Data.Csci340lab7Context context)
        {
            _context = context;
        }

        public IList<Avocado> Avocado { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Type { get; set; }
        [BindProperty(SupportsGet = true)]
        public string AvocadoTypes { get; set; }

        public async Task OnGetAsync()
        {
            var avocados = from a in _context.Avocado
                         select a;
            if (!string.IsNullOrEmpty(SearchString))
            {
                avocados = avocados.Where(s => s.Type.Contains(SearchString));
            }

            Avocado = await avocados.ToListAsync();
        }
    }
}
