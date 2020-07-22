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

namespace SacramentProgram.Pages.Speakers
{
    public class EditModel : PersonPageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public EditModel(SacramentProgram.Data.SacramentProgramContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Speaker Speaker { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Speaker = await _context.Speaker.FirstOrDefaultAsync(m => m.ID == id);
            

            if (Speaker == null)
            {
                return NotFound();
            }

            PopulatePersonDropDownList(_context);
            PopulateMeetingsDropDownList(_context);

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

            var speakerToUpdate = await _context.Speaker.FindAsync(id);

                if (await TryUpdateModelAsync<Speaker>(
                    speakerToUpdate,
                    "speaker",
                    s => s.ID, s => s.MeetingID, s => s.PersonID, s => s.Topic
                    ))
            
            

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpeakerExists(Speaker.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            PopulatePersonDropDownList(_context);
            PopulateMeetingsDropDownList(_context);
            return RedirectToPage("./Index");
        }

        private bool SpeakerExists(int id)
        {
            return _context.Speaker.Any(e => e.ID == id);
        }
    }
}
