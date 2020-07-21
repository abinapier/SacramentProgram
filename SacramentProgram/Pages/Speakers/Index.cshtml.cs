using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentProgram.Data;
using SacramentProgram.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SacramentProgram.Pages.Speakers
{
    public class IndexModel : PageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public IndexModel(SacramentProgram.Data.SacramentProgramContext context)
        {
            _context = context;
        }

        public IList<Speaker> Speaker { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Person { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SpeakerPersons { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> personQuery = from p in _context.Person
                                            orderby p.LastName
                                            select p.FullName;

            var speaker = from s in _context.Speaker
                          select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                speaker = speaker.Where(s => s.Topic.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(SpeakerPersons))
            {
                speaker = speaker.Where(x => x.Person == Speaker);
            }
            Person = new SelectList(await personQuery.Distinct().ToListAsync());
            Speaker = await _context.Speaker.ToListAsync();
        }
    }
}

