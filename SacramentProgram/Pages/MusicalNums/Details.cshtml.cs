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
    public class DetailsModel : PageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public DetailsModel(SacramentProgram.Data.SacramentProgramContext context)
        {
            _context = context;
        }

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
    }
}
