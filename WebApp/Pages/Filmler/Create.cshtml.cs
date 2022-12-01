using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FilmYonetim.Domain.Entities;
using WebApp.Data;

namespace WebApp.Pages.Filmler
{
    public class CreateModel : PageModel
    {
        private readonly WebApp.Data.MovieContext _context;

        public CreateModel(WebApp.Data.MovieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movies Movies { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movies.Add(Movies);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
