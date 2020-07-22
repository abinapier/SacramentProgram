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
using SacramentProgram.Pages;

namespace SacramentProgram.Pages.Meetings
{
    public class EditModel : PersonPageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public EditModel(SacramentProgram.Data.SacramentProgramContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meeting = await _context.Meeting.FirstOrDefaultAsync(m => m.ID == id);

            if (Meeting == null)
            {
                return NotFound();
            }
            PopulatePersonDropDownList(_context);
            PopulateSongDropDownList(_context);
            PopulateMusicNumDropDownList(_context);
            PopulateMusicNumDropDownList(_context);
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

            _context.Attach(Meeting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeetingExists(Meeting.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            PopulatePersonDropDownList(_context);
            PopulateSongDropDownList(_context);
            PopulateMusicNumDropDownList(_context);
            PopulateMusicNumDropDownList(_context);
            return RedirectToPage("./Index");
        }

        private bool MeetingExists(int id)
        {
            return _context.Meeting.Any(e => e.ID == id);
        }
    }
}
