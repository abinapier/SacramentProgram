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
    public class IndexModel : PageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public IndexModel(SacramentProgram.Data.SacramentProgramContext context)
        {
            _context = context;
        }

        public IList<MusicalNum> MusicalNum { get;set; }

        public async Task OnGetAsync()
        {
            await _context.Song.ToListAsync();
            MusicalNum = await _context.MusicalNum.ToListAsync();
        }
    }
}
