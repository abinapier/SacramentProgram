using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentProgram.Data;
using SacramentProgram.Models;
using SacramentProgram.Pages.Meetings;

namespace SacramentProgram.Pages.MusicalNums
{
    public class CreateModel : PersonPageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public CreateModel(SacramentProgram.Data.SacramentProgramContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            
            PopulateSongDropDownList(_context);
           
            return Page();
        }

        [BindProperty]
        public MusicalNum MusicalNum { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyMusicnum = new MusicalNum();
            if (await TryUpdateModelAsync<MusicalNum>(
                 emptyMusicnum,
                 "Musicalnum",   // Prefix for form value.
                  s => s.ID, s => s.SongID, s => s.Performer))
            {
                _context.MusicalNum.Add(emptyMusicnum);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            // Select DepartmentID if TryUpdateModelAsync fails.

            PopulateSongDropDownList(_context);
            
            return Page();
        }
    }
}
