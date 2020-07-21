using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentProgram.Data;
using SacramentProgram.Models;

namespace SacramentProgram.Pages.Meetings
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
            PopulatePersonDropDownList(_context);
            PopulateSongDropDownList(_context);
            PopulateMusicNumDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Meeting Meeting { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyMeeting = new Meeting();

           // if (await TryUpdateModelAsync<Meeting>(
                // emptyMeeting,
                // "Meeting",   // Prefix for form value.
                // s => s.ID, s => s.MeetingDate, s => s.Conducting, s => s.Presiding, s => s.Accompaniment, s => s.LeadingMusic, s => s.OpeningSong, s => s.OpeningPrayer, s => s.SacramentSong, s => s.MusicalNumber, s => s.IntermediateSong, s => s.ClosingSong, s => s.ClosingPrayerId, s => s.WardName, s => s.Speakers))
            //{
               // _context.Meeting.Add(emptyMeeting);
              //  await _context.SaveChangesAsync();
              //  return RedirectToPage("./Index");
           // }

            // Select DepartmentID if TryUpdateModelAsync fails.
            PopulatePersonDropDownList(_context);
            PopulateSongDropDownList(_context);
            PopulateMusicNumDropDownList(_context);
            return Page();
        }
    }
}
