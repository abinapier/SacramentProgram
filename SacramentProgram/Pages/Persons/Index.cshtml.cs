using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentProgram.Data;
using SacramentProgram.Models;

namespace SacramentProgram.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public IndexModel(SacramentProgram.Data.SacramentProgramContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public async Task OnGetAsync()
        {
            var persons = from p in _context.Person
                           select p;
            if (!string.IsNullOrEmpty(SearchString))
            {
                persons = persons.Where(p => p.FirstName.Contains(SearchString) || p.LastName.Contains(SearchString));
            }

            persons = persons.OrderBy(p => p.LastName);

            Person = await persons.ToListAsync();
        }
    }
}
