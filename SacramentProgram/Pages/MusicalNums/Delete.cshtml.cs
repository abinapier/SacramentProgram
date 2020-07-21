using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentProgram.Data;
using SacramentProgram.Models;

namespace SacramentProgram.Pages.MusicalNums
{
    public class DeleteModel : PageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public DeleteModel(SacramentProgram.Data.SacramentProgramContext context)
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

            if (MusicalNum == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MusicalNum = await _context.MusicalNum.FindAsync(id);

            if (MusicalNum != null)
            {
                _context.MusicalNum.Remove(MusicalNum);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
