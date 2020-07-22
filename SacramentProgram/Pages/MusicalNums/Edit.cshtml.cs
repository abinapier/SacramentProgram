using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentProgram.Data;
using SacramentProgram.Models;
using SacramentProgram.Pages.Meetings;

namespace SacramentProgram.Pages.MusicalNums
{
    public class EditModel : PersonPageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public EditModel(SacramentProgram.Data.SacramentProgramContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MusicalNum MusicalNum { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MusicalNum = await _context.MusicalNum.FirstOrDefaultAsync(m => m.ID == id);
            
            await _context.Song.ToListAsync();
            


            if (MusicalNum == null)
            {
                return NotFound();
            }

            PopulateSongDropDownList(_context);

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var Musictoupdate = await _context.MusicalNum.FindAsync(id);

            if (await TryUpdateModelAsync<MusicalNum>(
                 Musictoupdate,
                 "Musicalnum",   // Prefix for form value.
                  s => s.ID, s => s.SongID, s => s.Performer))

                try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicalNumExists(MusicalNum.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            PopulateSongDropDownList(_context);
            return RedirectToPage("./Index");
        }

        private bool MusicalNumExists(int id)
        {
            return _context.MusicalNum.Any(e => e.ID == id);
        }
    }
}
