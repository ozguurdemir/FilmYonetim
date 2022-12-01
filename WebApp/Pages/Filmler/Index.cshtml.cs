using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FilmYonetim.Domain.Entities;
using WebApp.Data;
using Microsoft.IdentityModel.Tokens;

namespace WebApp.Pages.Filmler
{
    public class IndexModel : PageModel
    {
        private readonly WebApp.Data.MovieContext _context;

        public IndexModel(WebApp.Data.MovieContext context)
        {
            _context = context;
        }

        public int Date1 { get; set; }
        public int Date2 { get; set; }
        public IList<Movies> Movies { get;set; } = default!;

        public async Task OnGetAsync(int firstYear, int lastYear)
        {
            Date1 = firstYear; Date2 = lastYear;
            IQueryable<Movies> movieIQ = from m in _context.Movies select m;


            if (Date1 != 0 || Date2 != 0)
            {
                movieIQ = movieIQ.Where(m => m.Date >= Date1 &  m.Date <= Date2);
                
            }






            Movies = await movieIQ.AsNoTracking().ToListAsync();


        }
    }
}
